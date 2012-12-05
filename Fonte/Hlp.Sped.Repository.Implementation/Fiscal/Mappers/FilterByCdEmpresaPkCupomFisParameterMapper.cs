using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Hlp.Sped.Repository.Implementation.Fiscal.Mappers
{
    public class FilterByCdEmpresaPkCupomFisParameterMapper : IParameterMapper
    {
        private readonly Database db;

        public FilterByCdEmpresaPkCupomFisParameterMapper(Database db)
        {
            this.db = db;
        }

        public void AssignParameters(DbCommand command, object[] parameterValues)
        {
            InitializeParameters(command);
            db.SetParameterValue(command, "@CD_EMPRESA", parameterValues[0]);
            db.SetParameterValue(command, "@PK_CUPOMFIS", parameterValues[1]);
        }

        private void InitializeParameters(DbCommand command)
        {
            if (!command.Parameters.Contains("@CD_EMPRESA"))
            {
                db.AddInParameter(command, "@CD_EMPRESA", DbType.String);
            }
            if (!command.Parameters.Contains("@PK_CUPOMFIS"))
            {
                db.AddInParameter(command, "@PK_CUPOMFIS", DbType.String);
            }
        }
    }
}