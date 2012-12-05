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

namespace Hlp.Sped.Repository.Implementation
{
    public class ConexoesRepository : IConexoesRepository
    {
        public Conexao Obter(string nomeConexao)
        {
            Conexao conexao = new Conexao();

            conexao.NOME = nomeConexao;
            string[] propriedades = 
                ConfigurationManager.ConnectionStrings[nomeConexao].ConnectionString.Split(
                    new string[]{";"}, StringSplitOptions.RemoveEmptyEntries);
            string[] prop;
            for (int i = 0; i < propriedades.Length; i++)
            {
                prop = propriedades[i].Split(new string[] { "=" }, StringSplitOptions.None);
                conexao.PROPRIEDADES.Add(prop[0], prop[1]);
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

        public void Salvar(Conexao conexao)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings[conexao.NOME].ConnectionString = 
                this.GetConnectionString(conexao);
            if (conexao.NOME == "DBArquivoSpedFiscal" || conexao.NOME == "DBArquivoSpedContabil")
            {
                config.AppSettings.Settings.Remove("ActiveRecordDialect");
                config.AppSettings.Settings.Add("ActiveRecordDialect", "NHibernate.Dialect.FirebirdDialect");
            }
            config.Save(ConfigurationSaveMode.Modified, false);
            ConfigurationManager.RefreshSection("connectionStrings");
        }

        private string GetConnectionString(Conexao conexao)
        {
            StringBuilder strb = new StringBuilder();
            foreach (KeyValuePair<string, string> propriedade in conexao.PROPRIEDADES)
            { 
                strb.Append(string.Format("{0}={1};", propriedade.Key, propriedade.Value));
            }
            
            return strb.ToString();
        }
    }
}
