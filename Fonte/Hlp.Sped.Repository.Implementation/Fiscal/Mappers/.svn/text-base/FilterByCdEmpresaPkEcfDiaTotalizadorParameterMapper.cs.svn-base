using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Hlp.Sped.Repository.Implementation.Fiscal.Mappers
{
    public class FilterByCdEmpresaPkEcfDiaTotalizadorParameterMapper : IParameterMapper
    {
        private readonly Database db;

        public FilterByCdEmpresaPkEcfDiaTotalizadorParameterMapper(Database db)
        {
            this.db = db;
        }

        public void AssignParameters(DbCommand command, object[] parameterValues)
        {
            InitializeParameters(command);
            db.SetParameterValue(command, "@CD_EMPRESA", parameterValues[0]);
            db.SetParameterValue(command, "@CD_SEQECF", parameterValues[1]);
            db.SetParameterValue(command, "@DT_EMI", parameterValues[2]);
            db.SetParameterValue(command, "@COD_TOT_PAR", parameterValues[3]);
        }

        private void InitializeParameters(DbCommand command)
        {
            if (!command.Parameters.Contains("@CD_EMPRESA"))
            {
                db.AddInParameter(command, "@CD_EMPRESA", DbType.String);
            }
            if (!command.Parameters.Contains("@CD_SEQECF"))
            {
                db.AddInParameter(command, "@CD_SEQECF", DbType.String);
            }
            if (!command.Parameters.Contains("@DT_EMI"))
            {
                db.AddInParameter(command, "@DT_EMI", DbType.DateTime);
            }
            if (!command.Parameters.Contains("@COD_TOT_PAR"))
            {
                db.AddInParameter(command, "@COD_TOT_PAR", DbType.String);
            }
        }
    }
}