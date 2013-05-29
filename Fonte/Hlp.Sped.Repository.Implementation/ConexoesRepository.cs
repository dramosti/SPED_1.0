using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.Odbc;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Repository.Interfaces;
using Hlp.Sped.Repository.Interfaces.SQLExpressions;
using Hlp.Sped.Domain.Models;
using System.IO;

namespace Hlp.Sped.Repository.Implementation
{
    public class ConexoesRepository : IConexoesRepository
    {
        private ModelConexao ConfigConn { get; set; }

        public ModelConexao GetConfigConexoes()
        {
            ModelConexao objRet = null;
            string sPath = Util.GetPastaConfiguracao() + "\\SpedConfig.xml";
            if (sPath != "")
            {
                if (File.Exists(sPath))
                {
                    objRet = SerializeClassToXml.DeserializeClasse<ModelConexao>(sPath);
                }
            }
            return objRet;
        }

        public Conexao Obter(string nomeConexao)
        {
            Conexao conexao = null;
            ConfigConn = GetConfigConexoes();
            if (ConfigConn != null)
            {
                if (ConfigConn.CONEXOES.Where(c => c.NAME == nomeConexao).Count() > 0)
                {
                    conexao = new Conexao();
                    conexao.NOME = nomeConexao;
                    conexao.bCOMPLETO = ConfigConn.bCOMPLETO;
                    conexao.PROPRIEDADES.Add("dbname", ConfigConn.CONEXOES.FirstOrDefault(c => c.NAME == nomeConexao).PATH);
                    conexao.PROPRIEDADES.Add("Driver", "{Firebird/InterBase(r) driver}");
                    conexao.PROPRIEDADES.Add("Dialect", "3");
                    conexao.PROPRIEDADES.Add("uid", "SYSDBA");
                    conexao.PROPRIEDADES.Add("pwd", "masterkey");
                    conexao.sNM_EMPRESA = this.GetNomeBaseEmpresa(conexao);
                }
            }
            return conexao;
        }

        public bool Validar(Conexao conexao)
        {
            bool resultado = true;
            OdbcConnection conn = null;

            try
            {
                conn = new OdbcConnection(
                    this.GetConnectionString(conexao));
                conn.Open();
            }
            catch
            {
                resultado = false;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }

            return resultado;

        }
        public string GetNomeBaseEmpresa(Conexao conexao)
        {
            OdbcConnection conn = null;
            string sEmpresa = "";
            try
            {
                conn = new OdbcConnection(
                    this.GetConnectionString(conexao));
                conn.Open();

                OdbcCommand cmd = new OdbcCommand("select cd_conteud from control where cd_nivel = '0016'", conn);
                sEmpresa = cmd.ExecuteScalar().ToString();
                return sEmpresa;
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }
        public void Salvar(Conexao conexao)
        {
            if (conexao.PROPRIEDADES["dbname"].Split(':')[1] != "")
            {
                string sPath = Util.GetPastaConfiguracao();
                if (sPath == "")
                {
                    throw new Exception("Configure um diretório na rede para salvar as conexões.");
                }
                sPath += "\\SpedConfig.xml";
                ItemConn conn = null;
                if (ConfigConn == null)
                {
                    ConfigConn = new ModelConexao();
                    ConfigConn.CONEXOES = new List<ItemConn>();
                    conn = new ItemConn();
                    ConfigConn.CONEXOES.Add(conn);
                }
                else
                {
                    if (ConfigConn.CONEXOES.Where(c => c.NAME == conexao.NOME).Count() > 0)
                    {
                        conn = ConfigConn.CONEXOES.FirstOrDefault(c => c.NAME == conexao.NOME);
                    }
                    else
                    {
                        conn = new ItemConn();
                        ConfigConn.CONEXOES.Add(conn);
                    }
                }
                conn.NAME = conexao.NOME;
                ConfigConn.bCOMPLETO = conexao.bCOMPLETO;
                conn.PATH = conexao.PROPRIEDADES["dbname"];

                SerializeClassToXml.SerializeClasse<ModelConexao>(ConfigConn, sPath);


                //Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //config.ConnectionStrings.ConnectionStrings[conexao.NOME].ConnectionString =
                //    this.GetConnectionString(conexao);
                //if (conexao.NOME == "DBArquivoSpedFiscal" || conexao.NOME == "DBArquivoSpedContabil")
                //{
                //    config.AppSettings.Settings.Remove("ActiveRecordDialect");
                //    config.AppSettings.Settings.Add("ActiveRecordDialect", "NHibernate.Dialect.FirebirdDialect");
                //}
                //config.Save(ConfigurationSaveMode.Modified, false);
                //ConfigurationManager.RefreshSection("connectionStrings");
            }
        }
        public  string GetConnectionString(Conexao conexao)
        {
            StringBuilder strb = new StringBuilder();
            foreach (KeyValuePair<string, string> propriedade in conexao.PROPRIEDADES)
            {
                strb.Append(string.Format("{0}={1};", propriedade.Key, propriedade.Value));
            }

            return strb.ToString();
        }
        public void RemoveConexao(Conexao conexao)
        {
            string sPath = Util.GetPastaConfiguracao();
            if (sPath == "")
            {
                throw new Exception("Configure um diretório na rede para salvar as conexões.");
            }
            sPath += "\\SpedConfig.xml";
            ConfigConn = GetConfigConexoes();

            if (ConfigConn != null)
            {
                if (ConfigConn.CONEXOES.Where(c => c.NAME == conexao.NOME).Count() > 0)
                {
                    ConfigConn.CONEXOES.Remove(ConfigConn.CONEXOES.FirstOrDefault(c => c.NAME == conexao.NOME));
                }
                SerializeClassToXml.SerializeClasse<ModelConexao>(ConfigConn, sPath);
            }
        }

    }
}
