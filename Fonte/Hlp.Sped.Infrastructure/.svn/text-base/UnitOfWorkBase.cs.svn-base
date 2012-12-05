using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Hlp.Sped.Infrastructure.Files;

namespace Hlp.Sped.Infrastructure
{
    public abstract class UnitOfWorkBase
    {
        private Guid _Id;

        public Guid Id 
        {
            get
            {
                return _Id;
            }
        }

        public string CodigoEmpresa { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public TipoArquivo TipoArquivo { get; set; }
        public TipoRemessa TipoRemessa { get; set; }
        public string CaminhoArquivo { get; set; }
        public string NumeroReciboAnterior { get; set; }

        public abstract Database DBOrigemDadosFiscal { get; }

        public abstract Database DBOrigemDadosContabil { get; }

        public abstract Database DBArquivoSpedFiscal { get; }

        public abstract Database DBArquivoSpedContabil { get; }

        public UnitOfWorkBase()
        {
            this._Id = Guid.NewGuid();
        }

        public void AddParameterToCommand(DbCommand cmd, string parameterName, DbType type, object value)
        {
            DbParameter param = cmd.CreateParameter();
            
            param.ParameterName = parameterName;
            param.DbType = type;
            param.Value = value;
            
            cmd.Parameters.Add(param);
        }
    }
}