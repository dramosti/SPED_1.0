using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Hlp.Sped.Repository.Implementation.Fiscal.Mappers
{
    public class FilterByCdCliforParameterMapper : IParameterMapper
    {        
        private readonly Database db;

        public FilterByCdCliforParameterMapper(Database db)
        {
            this.db = db;
        }

        public void AssignParameters(DbCommand command, object[] parameterValues)
        {
            InitializeParameters(command);
            db.SetParameterValue(command, "@CD_CLIFOR", parameterValues[0]);
        }

        private void InitializeParameters(DbCommand command)
        {
            if (!command.Parameters.Contains("@CD_CLIFOR"))
            {
                db.AddInParameter(command, "@CD_CLIFOR", DbType.String);
            }
        }
    }
}
