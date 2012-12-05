using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Hlp.Sped.Repository.Implementation.Contabil.Mappers
{
    public class FilterByCdHistParameterMapper : IParameterMapper
    {
        private readonly Database db;

        public FilterByCdHistParameterMapper(Database db)
        {
            this.db = db;
        }

        public void AssignParameters(DbCommand command, object[] parameterValues)
        {
            InitializeParameters(command);
            db.SetParameterValue(command, "@CD_HIST", parameterValues[0]);
        }

        private void InitializeParameters(DbCommand command)
        {
            if (!command.Parameters.Contains("@CD_HIST"))
            {
                db.AddInParameter(command, "@CD_HIST", DbType.String);
            }
        }
    }
}