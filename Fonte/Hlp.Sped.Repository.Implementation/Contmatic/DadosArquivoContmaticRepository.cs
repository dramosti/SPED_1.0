using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Contmatic;
using System.Data;
using System.Data.Common;
using Castle.ActiveRecord;
using System.Configuration;
using Castle.ActiveRecord.Framework.Config;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Domain.Models.Contmatic;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Hlp.Sped.Repository.Implementation.Contmatic.Mappers;
using Hlp.Sped.Repository.Interfaces.Contmatic;

namespace Hlp.Sped.Repository.Implementation.Contmatic
{
    public class DadosArquivoContmaticRepository : IDadosArquivoContmaticRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsContmaticRepository SqlExpressionsContimaticRepository { get; set; }

        // Atributo que indica o código-chave do arquivo que estará sendo gerado
        private int _NumeroIdentificacaoArquivo;

        // Atributo que representa o DataReader através do qual será gerado o arquivo
        private IDataReader _ReaderRegistros;

        // Atributo que representa o objeto Command utilizado para verificar se um
        // registro já foi persistido
        private DbCommand _cmdRegistroJaExistente;

        // Atributo que representa o objeto Command empregado na gravação de registros
        // de um arquivo
        private DbCommand _cmdPersistirRegistro;

        // Atributo que representa o objeto Command utilizado para obter a
        // quantidade de registros gerados para um determinado bloco
        private DbCommand _cmdQtdRegistrosBloco;

        // Mantém uma relação dos último registro pesquisado e encontrado para
        // um determinado tipo de registro (este controle foi criado buscando melhorias
        // de performance)
        private Dictionary<string, string> _ultimoRegistroPesquisadoPorTipo =
            new Dictionary<string, string>();

        // Atributo que contém informações do arquivo que está sendo gerado
        private ArquivoContmaticRecord _informacoesArquivo;

        #region Métodos privados auxiliares

        private ArquivoContmaticRecord GetRecordInformacoesArquivo()
        {
            IDictionary<string, string> properties = new Dictionary<string, string>();

            properties.Add("connection.driver_class",
                ConfigurationManager.AppSettings["ActiveRecordDriver"]);
            properties.Add("dialect",
                ConfigurationManager.AppSettings["ActiveRecordDialect"]);
            properties.Add("connection.provider",
                ConfigurationManager.AppSettings["ActiveRecordConnectionProvider"]);
            properties.Add("connection.connection_string",
                ConfigurationManager.ConnectionStrings["DBArquivoSpedContmatic"].ConnectionString); //criar o config do contmatic
            properties.Add("proxyfactory.factory_class",
                ConfigurationManager.AppSettings["ActiveRecordProxyFactory"]);

            InPlaceConfigurationSource source = new InPlaceConfigurationSource();
            source.Add(typeof(ActiveRecordBase), properties);
            ActiveRecordStarter.Initialize(source, typeof(ArquivoContmaticRecord));

            return ArquivoContmaticRecord.Find(this._NumeroIdentificacaoArquivo);
        }

        #endregion

        public void Inicializar()
        {
            RegistroBase.InicializarProcessamentoRegistros();

            DbCommand cmd = UndTrabalho.DBArquivoSpedContabil.GetStoredProcCommand(
                SqlExpressionsContimaticRepository.GetExpressionNovaSequenciaArquivo());

            this._NumeroIdentificacaoArquivo = Convert.ToInt32(
                UndTrabalho.DBArquivoSpedContabil.ExecuteScalar(cmd));
            this._informacoesArquivo = this.GetRecordInformacoesArquivo();

            this._informacoesArquivo.CodigoEmpresa = UndTrabalho.CodigoEmpresa;
            this._informacoesArquivo.DataInicial = UndTrabalho.DataInicial;
            this._informacoesArquivo.DataFinal = UndTrabalho.DataFinal;
            this._informacoesArquivo.TipoArquivo = UndTrabalho.TipoArquivo.ToString().ToUpper();
            this._informacoesArquivo.TipoRemessa = UndTrabalho.TipoRemessa.ToString().ToUpper();
            this._informacoesArquivo.Save();
        }

        public void PersistirRegistro(RegistroBase registro)
        {
            if (_cmdPersistirRegistro == null)
            {
                _cmdPersistirRegistro = UndTrabalho.DBOrigemDadosContmatic.GetSqlStringCommand(
                    SqlExpressionsContimaticRepository.GetInsertPersistirRegistro());
                UndTrabalho.AddParameterToCommand(_cmdPersistirRegistro, "@NR_ARQUIVO",
                    DbType.Int32, this._NumeroIdentificacaoArquivo);
                UndTrabalho.AddParameterToCommand(_cmdPersistirRegistro, "@VL_ORDENACAO_BLOCO",
                    DbType.Int32, RegistroBase.GetValorOrdenacaoBloco(registro.REG));
                UndTrabalho.AddParameterToCommand(_cmdPersistirRegistro, "@VL_CHAVE_REGISTRO",
                    DbType.String, registro.GetKeyValue());
                UndTrabalho.AddParameterToCommand(_cmdPersistirRegistro, "@TP_REGISTRO",
                    DbType.String, registro.REG);
                UndTrabalho.AddParameterToCommand(_cmdPersistirRegistro, "@DS_CONTEUDO_REGISTRO",
                    DbType.String, registro.ToString());
                UndTrabalho.AddParameterToCommand(_cmdPersistirRegistro, "@CD_ORDENACAO_REGISTRO",
                    DbType.String, registro.CODIGO_ORDENACAO);
            }
            else
            {
                _cmdPersistirRegistro.Parameters["@VL_ORDENACAO_BLOCO"].Value =
                    RegistroBase.GetValorOrdenacaoBloco(registro.REG);
                _cmdPersistirRegistro.Parameters["@VL_CHAVE_REGISTRO"].Value = registro.GetKeyValue();
                _cmdPersistirRegistro.Parameters["@TP_REGISTRO"].Value =
                    registro.REG;
                _cmdPersistirRegistro.Parameters["@DS_CONTEUDO_REGISTRO"].Value =
                    registro.ToString();
                _cmdPersistirRegistro.Parameters["@CD_ORDENACAO_REGISTRO"].Value =
                    registro.CODIGO_ORDENACAO;
            }

            UndTrabalho.DBOrigemDadosContmatic.ExecuteNonQuery(_cmdPersistirRegistro);
        }

        public bool RegistroJaExistente(string tipoRegistro, string valorChaveRegistro)
        {
            if (_cmdRegistroJaExistente == null)
            {
                _cmdRegistroJaExistente = UndTrabalho.DBArquivoSpedContabil.GetSqlStringCommand(
                  SqlExpressionsContimaticRepository.GetSelectRegistroJaExistente());
                UndTrabalho.AddParameterToCommand(_cmdRegistroJaExistente, "@NR_ARQUIVO",
                    DbType.Int32, this._NumeroIdentificacaoArquivo);
                UndTrabalho.AddParameterToCommand(_cmdRegistroJaExistente, "@TP_REGISTRO",
                    DbType.String, tipoRegistro);
                UndTrabalho.AddParameterToCommand(_cmdRegistroJaExistente, "@VL_CHAVE_REGISTRO",
                    DbType.String, valorChaveRegistro);
            }
            else
            {
                _cmdRegistroJaExistente.Parameters["@TP_REGISTRO"].Value = tipoRegistro;
                _cmdRegistroJaExistente.Parameters["@VL_CHAVE_REGISTRO"].Value = valorChaveRegistro;
            }

            bool jaExiste = (_ultimoRegistroPesquisadoPorTipo.ContainsKey(tipoRegistro) &&
                             _ultimoRegistroPesquisadoPorTipo[tipoRegistro] == valorChaveRegistro);
            if (!jaExiste)
            {
                jaExiste = (Convert.ToInt32(
                    UndTrabalho.DBArquivoSpedContabil.ExecuteScalar(_cmdRegistroJaExistente)) > 0);

                // Configura a lista com a última chave pesquisada para o tipo de registro em questão
                if (jaExiste)
                    _ultimoRegistroPesquisadoPorTipo[tipoRegistro] = valorChaveRegistro;
            }
            return jaExiste;
        }

        public bool BlocoPossuiRegistros(string identificadorBloco)
        {
            if (_cmdQtdRegistrosBloco == null)
            {
                _cmdQtdRegistrosBloco = UndTrabalho.DBArquivoSpedContabil.GetSqlStringCommand(
                    SqlExpressionsContimaticRepository.GetSelectQuantidadeRegistrosBloco());
                UndTrabalho.AddParameterToCommand(_cmdQtdRegistrosBloco, "@NR_ARQUIVO",
                    DbType.Int32, this._NumeroIdentificacaoArquivo);
                UndTrabalho.AddParameterToCommand(_cmdQtdRegistrosBloco, "@IDENTIFICADOR_BLOCO",
                    DbType.String, identificadorBloco);
            }
            else
            {
                _cmdQtdRegistrosBloco.Parameters["@IDENTIFICADOR_BLOCO"].Value = identificadorBloco;
            }

            return (Convert.ToInt32(
                UndTrabalho.DBArquivoSpedContabil.ExecuteScalar(_cmdQtdRegistrosBloco)) > 0);
        }

        public void OpenRegistros()
        {
            try
            {


                DbCommand cmd = UndTrabalho.DBArquivoSpedContabil.GetSqlStringCommand(
                    SqlExpressionsContimaticRepository.GetSelectRegistrosGerados());

                UndTrabalho.AddParameterToCommand(cmd, "@NR_ARQUIVO", DbType.Int32,
                    this._NumeroIdentificacaoArquivo);

                this._ReaderRegistros = UndTrabalho.DBArquivoSpedContabil.ExecuteReader(cmd);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool ReadRegistro()
        {
            return this._ReaderRegistros.Read();
        }

        public string GetConteudoRegistro()
        {
            return this._ReaderRegistros["DS_CONTEUDO_REGISTRO"].ToString();
        }

        public void CloseRegistros()
        {
            this._ReaderRegistros.Close();
        }

        public void RegistrarExcecao(Exception ex)
        {
            StringBuilder strb = new StringBuilder();
            strb.AppendLine("Exceção: " + ex.Message);
            strb.AppendLine("Stack Trace: " + ex.StackTrace);
            strb.Length = 4000;

            this._informacoesArquivo.Excecao = strb.ToString();
            this._informacoesArquivo.Save();
        }

        public void Finalizar()
        {
            if (Convert.ToBoolean(ConfigurationManager.AppSettings["LimparDadosAposGeracao"]))
            {
                DbCommand cmdExclusaoRegistros = UndTrabalho.DBArquivoSpedContabil.GetSqlStringCommand(
                  SqlExpressionsContimaticRepository.GetDeleteRegistrosGerados());
                UndTrabalho.AddParameterToCommand(cmdExclusaoRegistros, "@NR_ARQUIVO",
                    DbType.Int32, this._NumeroIdentificacaoArquivo);
                UndTrabalho.DBArquivoSpedContabil.ExecuteNonQuery(cmdExclusaoRegistros);
            }

            ActiveRecordStarter.ResetInitializationFlag();
            this._informacoesArquivo.CaminhoArquivo = UndTrabalho.CaminhoArquivo;
            this._informacoesArquivo.HorarioTerminoGeracaoArquivo = DateTime.Now;
            this._informacoesArquivo.Save();
        }


        public Registro0990 GetRegistro0990()
        {
            DataAccessor<Registro0990> registro0990Accessor =
                UndTrabalho.DBArquivoSpedContabil.CreateSqlStringAccessor(
                  SqlExpressionsContimaticRepository.GetSelectRegistro0990(),
                  new FilterByNrArquivoParameterMapper(UndTrabalho.DBArquivoSpedContabil),
                  MapBuilder<Registro0990>.MapAllProperties().Build());

            return registro0990Accessor.Execute(this._NumeroIdentificacaoArquivo).First();
        }
        public RegistroA990 GetRegistroA990()
        {
            DataAccessor<RegistroA990> registroA990Accessor =
                UndTrabalho.DBArquivoSpedContabil.CreateSqlStringAccessor(
                  SqlExpressionsContimaticRepository.GetSelectRegistroA990(),
                  new FilterByNrArquivoParameterMapper(UndTrabalho.DBArquivoSpedContabil),
                  MapBuilder<RegistroA990>.MapAllProperties().Build());

            return registroA990Accessor.Execute(this._NumeroIdentificacaoArquivo).First();
        }
        public RegistroC990 GetRegistroC990()
        {
            DataAccessor<RegistroC990> registroC990Accessor =
                UndTrabalho.DBArquivoSpedContabil.CreateSqlStringAccessor(
                  SqlExpressionsContimaticRepository.GetSelectRegistroC990(),
                  new FilterByNrArquivoParameterMapper(UndTrabalho.DBArquivoSpedContabil),
                  MapBuilder<RegistroC990>.MapAllProperties().Build());

            return registroC990Accessor.Execute(this._NumeroIdentificacaoArquivo).First();
        }
        public RegistroD990 GetRegistroD990()
        {
            DataAccessor<RegistroD990> registroD990Accessor =
                UndTrabalho.DBArquivoSpedContabil.CreateSqlStringAccessor(
                  SqlExpressionsContimaticRepository.GetSelectRegistroD990(),
                  new FilterByNrArquivoParameterMapper(UndTrabalho.DBArquivoSpedContabil),
                  MapBuilder<RegistroD990>.MapAllProperties().Build());

            return registroD990Accessor.Execute(this._NumeroIdentificacaoArquivo).First();
        }
        public Registro1990 GetRegistro1990()
        {
            DataAccessor<Registro1990> registro1990Accessor =
                UndTrabalho.DBArquivoSpedContabil.CreateSqlStringAccessor(
                  SqlExpressionsContimaticRepository.GetSelectRegistro1990(),
                  new FilterByNrArquivoParameterMapper(UndTrabalho.DBArquivoSpedContabil),
                  MapBuilder<Registro1990>.MapAllProperties().Build());

            return registro1990Accessor.Execute(this._NumeroIdentificacaoArquivo).First();
        }

    }


    [ActiveRecord("SPEDCONTMATIC")]
    internal class ArquivoContmaticRecord : ActiveRecordBase<ArquivoContmaticRecord>
    {
        [Property("CD_EMPRESA")]
        public string CodigoEmpresa { get; set; }

        [Property("DS_CAMINHO_ARQUIVO_GERADO")]
        public string CaminhoArquivo { get; set; }

        [PrimaryKey("NR_ARQUIVO")]
        public int NumeroIdentificacaoArquivo { get; set; }

        [Property("DS_EXCECAO")]
        public string Excecao { get; set; }


        [Property("TP_ARQUIVO")]
        public string TipoArquivo { get; set; }

        [Property("TP_REMESSA")]
        public string TipoRemessa { get; set; }





        [Property("DT_INICIAL_INFORMACOES")]
        public DateTime? DataInicial { get; set; }

        [Property("DT_FINAL_INFORMACOES")]
        public DateTime? DataFinal { get; set; }

        [Property("DT_INICIAL_GERACAO_ARQUIVO")]
        public DateTime? HorarioInicioGeracaoArquivo { get; set; }

        [Property("DT_FINAL_GERACAO_ARQUIVO")]
        public DateTime? HorarioTerminoGeracaoArquivo { get; set; }
    }
}
