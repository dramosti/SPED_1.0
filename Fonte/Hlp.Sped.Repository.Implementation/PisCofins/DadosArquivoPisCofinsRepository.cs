using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Castle.ActiveRecord;
using Castle.ActiveRecord.Framework.Config;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Repository.Interfaces.PisCofins;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.PisCofins;
using Hlp.Sped.Domain.Models.PisCofins;
using Hlp.Sped.Repository.Implementation.PisCofins.Mappers;

namespace Hlp.Sped.Repository.Implementation.PisCofins
{
    public class DadosArquivoPisCofinsRepository : IDadosArquivoPisCofinsRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsPisCofinsRepository SqlExpressionsPisCofinsRepository { get; set; }

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
        private ArquivoPisCofinsRecord _informacoesArquivo;

        #region Métodos privados auxiliares

        private ArquivoPisCofinsRecord GetRecordInformacoesArquivo()
        {
            IDictionary<string, string> properties = new Dictionary<string, string>();

            properties.Add("connection.driver_class",
                ConfigurationManager.AppSettings["ActiveRecordDriver"]);
            properties.Add("dialect",
                ConfigurationManager.AppSettings["ActiveRecordDialect"]);
            properties.Add("connection.provider",
                ConfigurationManager.AppSettings["ActiveRecordConnectionProvider"]);
            properties.Add("connection.connection_string",
                ConfigurationManager.ConnectionStrings["DBArquivoSpedFiscal"].ConnectionString);
            properties.Add("proxyfactory.factory_class",
                ConfigurationManager.AppSettings["ActiveRecordProxyFactory"]);

            InPlaceConfigurationSource source = new InPlaceConfigurationSource();
            source.Add(typeof(ActiveRecordBase), properties);
            ActiveRecordStarter.Initialize(source, typeof(ArquivoPisCofinsRecord));

            return ArquivoPisCofinsRecord.Find(this._NumeroIdentificacaoArquivo);
        }

        #endregion

        public void Inicializar()
        {
            RegistroBase.InicializarProcessamentoRegistros();

            DbCommand cmd = UndTrabalho.DBArquivoSpedFiscal.GetStoredProcCommand(
                SqlExpressionsPisCofinsRepository.GetExpressionNovaSequenciaArquivo());

            this._NumeroIdentificacaoArquivo = Convert.ToInt32(
                UndTrabalho.DBArquivoSpedFiscal.ExecuteScalar(cmd));
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
            string sCD_ORD = registro.CODIGO_ORDENACAO.Split('-')[0].Trim();
            

            if (sCD_ORD.Equals("0140"))
            {
                UndTrabalho.iCONTROLE_EMP++;
            }

            if (sCD_ORD.Contains("010"))
            {
                UndTrabalho.iCONTROLE_EMP++;
            }

            else if (sCD_ORD.Equals("9001"))
            {
                UndTrabalho.iCONTROLE_EMP++;
            }


            if (_cmdPersistirRegistro == null)
            {
                _cmdPersistirRegistro = UndTrabalho.DBArquivoSpedFiscal.GetSqlStringCommand(
                    SqlExpressionsPisCofinsRepository.GetInsertPersistirRegistro());
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

                //tratamento específico para piscofins
                //UndTrabalho.AddParameterToCommand(_cmdPersistirRegistro, "@CD_COLTROLE_EMP",
                //    DbType.Int32, UndTrabalho.iCONTROLE_EMP);
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
                //_cmdPersistirRegistro.Parameters["@CD_COLTROLE_EMP"].Value =
                //   UndTrabalho.iCONTROLE_EMP;
            }

            UndTrabalho.DBArquivoSpedFiscal.ExecuteNonQuery(_cmdPersistirRegistro);
        }

        public bool RegistroJaExistente(string tipoRegistro, string valorChaveRegistro)
        {
            if (_cmdRegistroJaExistente == null)
            {
                _cmdRegistroJaExistente = UndTrabalho.DBArquivoSpedFiscal.GetSqlStringCommand(
                    SqlExpressionsPisCofinsRepository.GetSelectRegistroJaExistente());
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
                    UndTrabalho.DBArquivoSpedFiscal.ExecuteScalar(_cmdRegistroJaExistente)) > 0);

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
                _cmdQtdRegistrosBloco = UndTrabalho.DBArquivoSpedFiscal.GetSqlStringCommand(
                    SqlExpressionsPisCofinsRepository.GetSelectQuantidadeRegistrosBloco());
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
                UndTrabalho.DBArquivoSpedFiscal.ExecuteScalar(_cmdQtdRegistrosBloco)) > 0);
        }

        public Registro0990 GetRegistro0990()
        {
            DataAccessor<Registro0990> registro0990Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistro0990(),
                  new FilterByNrArquivoParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro0990>.MapAllProperties().Build());

            return registro0990Accessor.Execute(this._NumeroIdentificacaoArquivo).First();
        }

        public RegistroA990 GetRegistroA990()
        {
            DataAccessor<RegistroA990> registroA990Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistroA990(),
                  new FilterByNrArquivoParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroA990>.MapAllProperties().Build());

            return registroA990Accessor.Execute(this._NumeroIdentificacaoArquivo).First();
        }

        public RegistroC990 GetRegistroC990()
        {
            DataAccessor<RegistroC990> registroC990Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistroC990(),
                  new FilterByNrArquivoParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroC990>.MapAllProperties().Build());

            return registroC990Accessor.Execute(this._NumeroIdentificacaoArquivo).First();
        }

        public RegistroD990 GetRegistroD990()
        {
            DataAccessor<RegistroD990> registroD990Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistroD990(),
                  new FilterByNrArquivoParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroD990>.MapAllProperties().Build());

            return registroD990Accessor.Execute(this._NumeroIdentificacaoArquivo).First();
        }

        public RegistroF990 GetRegistroF990()
        {
            DataAccessor<RegistroF990> registroF990Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistroF990(),
                  new FilterByNrArquivoParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroF990>.MapAllProperties().Build());

            return registroF990Accessor.Execute(this._NumeroIdentificacaoArquivo).First();
        }

        public RegistroM990 GetRegistroM990()
        {
            DataAccessor<RegistroM990> registroM990Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistroM990(),
                  new FilterByNrArquivoParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroM990>.MapAllProperties().Build());

            return registroM990Accessor.Execute(this._NumeroIdentificacaoArquivo).First();
        }

        public RegistroP990 GetRegistroP990()
        {
            DataAccessor<RegistroP990> registroP990Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistroP990(),
                  new FilterByNrArquivoParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<RegistroP990>.MapAllProperties().Build());

            return registroP990Accessor.Execute(this._NumeroIdentificacaoArquivo).First();
        }

        public Registro1990 GetRegistro1990()
        {
            DataAccessor<Registro1990> registro1990Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistro1990(),
                  new FilterByNrArquivoParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro1990>.MapAllProperties().Build());

            return registro1990Accessor.Execute(this._NumeroIdentificacaoArquivo).First();
        }

        public Registro9001 GetRegistro9001()
        {
            Registro9001 reg9001 = new Registro9001();
            reg9001.IND_MOV = "0"; // Sempre haverá um conjunto de informações no bloco 9

            return reg9001;
        }

        public IEnumerable<Registro9900> GetRegistros9900()
        {
            DataAccessor<Registro9900> registro9900Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistros9900(),
                  new FilterByNrArquivoParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro9900>.MapAllProperties().Build());

            List<Registro9900> resultado =
                registro9900Accessor.Execute(this._NumeroIdentificacaoArquivo).ToList();

            resultado.Add(
                new Registro9900()
                {
                    REG_BLC = "9990",
                    VL_ORDENACAO_BLOCO = RegistroBase.GetValorOrdenacaoBloco("9990"),
                    QTD_REG_BLC = 1
                });
            resultado.Add(
                new Registro9900()
                {
                    REG_BLC = "9999",
                    VL_ORDENACAO_BLOCO = RegistroBase.GetValorOrdenacaoBloco("9999"),
                    QTD_REG_BLC = 1
                });
            resultado.Add(
                new Registro9900()
                {
                    REG_BLC = "9900",
                    VL_ORDENACAO_BLOCO = RegistroBase.GetValorOrdenacaoBloco("9900"),
                    QTD_REG_BLC = resultado.Count + 1
                });

            return resultado.OrderBy(r => r.GetKeyValue());
        }

        public Registro9990 GetRegistro9990()
        {
            DataAccessor<Registro9990> registro9990Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistro9990(),
                  new FilterByNrArquivoParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro9990>.MapAllProperties().Build());

            return registro9990Accessor.Execute(this._NumeroIdentificacaoArquivo).First();
        }

        public Registro9999 GetRegistro9999()
        {
            DataAccessor<Registro9999> registro9999Accessor =
                UndTrabalho.DBArquivoSpedFiscal.CreateSqlStringAccessor(
                  SqlExpressionsPisCofinsRepository.GetSelectRegistro9999(),
                  new FilterByNrArquivoParameterMapper(UndTrabalho.DBArquivoSpedFiscal),
                  MapBuilder<Registro9999>.MapAllProperties().Build());

            return registro9999Accessor.Execute(this._NumeroIdentificacaoArquivo).First();
        }

        public void OpenRegistros()
        {
            DbCommand cmd = UndTrabalho.DBArquivoSpedFiscal.GetSqlStringCommand(
                SqlExpressionsPisCofinsRepository.GetSelectRegistrosGerados());

            UndTrabalho.AddParameterToCommand(cmd, "@NR_ARQUIVO", DbType.Int32,
                this._NumeroIdentificacaoArquivo);

            this._ReaderRegistros = UndTrabalho.DBArquivoSpedFiscal.ExecuteReader(cmd);
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
                DbCommand cmdExclusaoRegistros = UndTrabalho.DBArquivoSpedFiscal.GetSqlStringCommand(
                  SqlExpressionsPisCofinsRepository.GetDeleteRegistrosGerados());
                UndTrabalho.AddParameterToCommand(cmdExclusaoRegistros, "@NR_ARQUIVO",
                    DbType.Int32, this._NumeroIdentificacaoArquivo);
                UndTrabalho.DBArquivoSpedFiscal.ExecuteNonQuery(cmdExclusaoRegistros);
            }

            ActiveRecordStarter.ResetInitializationFlag();
            this._informacoesArquivo.CaminhoArquivo = UndTrabalho.CaminhoArquivo;
            this._informacoesArquivo.HorarioTerminoGeracaoArquivo = DateTime.Now;
            this._informacoesArquivo.Save();
        }
    }

    [ActiveRecord("SPEDPISCOFINS")]
    internal class ArquivoPisCofinsRecord : ActiveRecordBase<ArquivoPisCofinsRecord>
    {
        [PrimaryKey("NR_ARQUIVO")]
        public int NumeroIdentificacaoArquivo { get; set; }

        [Property("CD_EMPRESA")]
        public string CodigoEmpresa { get; set; }

        [Property("TP_ARQUIVO")]
        public string TipoArquivo { get; set; }

        [Property("TP_REMESSA")]
        public string TipoRemessa { get; set; }

        [Property("DS_CAMINHO_ARQUIVO_GERADO")]
        public string CaminhoArquivo { get; set; }

        [Property("DS_EXCECAO")]
        public string Excecao { get; set; }

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