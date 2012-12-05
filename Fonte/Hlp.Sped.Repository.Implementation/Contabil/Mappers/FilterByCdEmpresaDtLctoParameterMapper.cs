using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Hlp.Sped.Repository.Implementation.Contabil.Mappers
{
    public class FilterByCdEmpresaDtLctoParameterMapper : IParameterMapper
    {        
        private readonly Database db;

        public FilterByCdEmpresaDtLctoParameterMapper(Database db)
        {
            this.db = db;
        }

        public void AssignParameters(DbCommand command, object[] parameterValues)
        {
            InitializeParameters(command);
            db.SetParameterValue(command, "@CD_EMPRESA", parameterValues[0]);
            db.SetParameterValue(command, "@DT_LCTO_INICIAL", parameterValues[1]);
            db.SetParameterValue(command, "@DT_LCTO_FINAL", parameterValues[2]);
        }

        private void InitializeParameters(DbCommand command)
        {
            if (!command.Parameters.Contains("@CD_EMPRESA"))
            {
                db.AddInParameter(command, "@CD_EMPRESA", DbType.String);
            }
            if (!command.Parameters.Contains("@DT_LCTO_INICIAL"))
            {
                db.AddInParameter(command, "@DT_LCTO_INICIAL", DbType.DateTime);
            }
            if (!command.Parameters.Contains("@DT_LCTO_FINAL"))
            {
                db.AddInParameter(command, "@DT_LCTO_FINAL", DbType.DateTime);
            }
        }
    }
}
