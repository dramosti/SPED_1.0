using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Hlp.Sped.Repository.Implementation.Contabil.Mappers
{
    public class FilterByCdEmpresaNumLctoParameterMapper : IParameterMapper
    {
        private readonly Database db;

        public FilterByCdEmpresaNumLctoParameterMapper(Database db)
        {
            this.db = db;
        }

        public void AssignParameters(DbCommand command, object[] parameterValues)
        {
            InitializeParameters(command);
            db.SetParameterValue(command, "@CD_EMPRESA", parameterValues[0]);
            db.SetParameterValue(command, "@NUM_LCTO", parameterValues[1]);
        }

        private void InitializeParameters(DbCommand command)
        {
            if (!command.Parameters.Contains("@CD_EMPRESA"))
            {
                db.AddInParameter(command, "@CD_EMPRESA", DbType.String);
            }
            if (!command.Parameters.Contains("@NUM_LCTO"))
            {
                db.AddInParameter(command, "@NUM_LCTO", DbType.String);
            }
        }
    }
}
