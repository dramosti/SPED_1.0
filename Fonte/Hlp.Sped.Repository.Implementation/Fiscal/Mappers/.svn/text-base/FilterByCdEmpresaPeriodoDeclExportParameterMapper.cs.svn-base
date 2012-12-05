using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Hlp.Sped.Repository.Implementation.Fiscal.Mappers
{
    public class FilterByCdEmpresaPeriodoDeclExportParameterMapper : IParameterMapper
    {        
        private readonly Database db;

        public FilterByCdEmpresaPeriodoDeclExportParameterMapper(Database db)
        {
            this.db = db;
        }

        public void AssignParameters(DbCommand command, object[] parameterValues)
        {
            InitializeParameters(command);
            db.SetParameterValue(command, "@CD_EMPRESA", parameterValues[0]);
            db.SetParameterValue(command, "@DT_EMI_INICIAL", parameterValues[1]);
            db.SetParameterValue(command, "@DT_EMI_FINAL", parameterValues[2]);
            db.SetParameterValue(command, "@NRO_DE", parameterValues[3]);
        }

        private void InitializeParameters(DbCommand command)
        {
            if (!command.Parameters.Contains("@CD_EMPRESA"))
            {
                db.AddInParameter(command, "@CD_EMPRESA", DbType.String);
            }
            if (!command.Parameters.Contains("@DT_EMI_INICIAL"))
            {
                db.AddInParameter(command, "@DT_EMI_INICIAL", DbType.DateTime);
            }
            if (!command.Parameters.Contains("@DT_EMI_FINAL"))
            {
                db.AddInParameter(command, "@DT_EMI_FINAL", DbType.DateTime);
            }
            if (!command.Parameters.Contains("@NRO_DE"))
            {
                db.AddInParameter(command, "@NRO_DE", DbType.String);
            }
        }
    }
}