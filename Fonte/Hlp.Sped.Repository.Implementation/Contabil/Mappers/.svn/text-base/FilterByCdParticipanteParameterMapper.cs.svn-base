using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Hlp.Sped.Repository.Implementation.Contabil.Mappers
{
    public class FilterByCdParticipanteParameterMapper : IParameterMapper
    {
        private readonly Database db;

        public FilterByCdParticipanteParameterMapper(Database db)
        {
            this.db = db;
        }

        public void AssignParameters(DbCommand command, object[] parameterValues)
        {
            InitializeParameters(command);
            db.SetParameterValue(command, "@COD_PART", parameterValues[0]);
        }

        private void InitializeParameters(DbCommand command)
        {
            if (!command.Parameters.Contains("@COD_PART"))
            {
                db.AddInParameter(command, "@COD_PART", DbType.String);
            }
        }
    }
}
