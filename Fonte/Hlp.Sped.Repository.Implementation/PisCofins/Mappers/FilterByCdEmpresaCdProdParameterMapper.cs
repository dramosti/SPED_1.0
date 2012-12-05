using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Hlp.Sped.Repository.Implementation.PisCofins.Mappers
{
    public class FilterByCdEmpresaCdProdParameterMapper : IParameterMapper
    {
        private readonly Database db;

        public FilterByCdEmpresaCdProdParameterMapper(Database db)
        {
            this.db = db;
        }

        public void AssignParameters(DbCommand command, object[] parameterValues)
        {
            InitializeParameters(command);
            db.SetParameterValue(command, "@CD_EMPRESA", parameterValues[0]);
            db.SetParameterValue(command, "@CD_PROD", parameterValues[1]);
        }

        private void InitializeParameters(DbCommand command)
        {
            if (!command.Parameters.Contains("@CD_EMPRESA"))
            {
                db.AddInParameter(command, "@CD_EMPRESA", DbType.String);
            }
            if (!command.Parameters.Contains("@CD_PROD"))
            {
                db.AddInParameter(command, "@CD_PROD", DbType.String);
            }
        }
    }
}
