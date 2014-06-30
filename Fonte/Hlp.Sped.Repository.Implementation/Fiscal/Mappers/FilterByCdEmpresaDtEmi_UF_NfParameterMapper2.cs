using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Repository.Implementation.Fiscal.Mappers
{
    public class FilterByCdEmpresaDtEmi_UF_NfParameterMapper2 : IParameterMapper
    {
        private readonly Database db;

        public FilterByCdEmpresaDtEmi_UF_NfParameterMapper2(Database db)
        {
            this.db = db;
        }

        public void AssignParameters(DbCommand command, object[] parameterValues)
        {
            InitializeParameters(command);
            db.SetParameterValue(command, "@CD_UF", parameterValues[0]);
            db.SetParameterValue(command, "@CD_EMPRESA", parameterValues[1]);
            db.SetParameterValue(command, "@DT_EMI_INICIAL", parameterValues[2]);
            db.SetParameterValue(command, "@DT_EMI_FINAL", parameterValues[3]);
            
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
            if (!command.Parameters.Contains("@CD_UF"))
            {
                db.AddInParameter(command, "@CD_UF", DbType.String);
            }
        }
    }
}
