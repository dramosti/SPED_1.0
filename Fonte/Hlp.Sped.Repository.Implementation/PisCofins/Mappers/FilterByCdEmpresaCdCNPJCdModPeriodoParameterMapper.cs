using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Hlp.Sped.Repository.Implementation.PisCofins.Mappers
{
    public class FilterByCdEmpresaCdCNPJCdModPeriodoParameterMapper : IParameterMapper
    {
        private readonly Database db;

        public FilterByCdEmpresaCdCNPJCdModPeriodoParameterMapper(Database db)
        {
            this.db = db;
        }

        public void AssignParameters(DbCommand command, object[] parameterValues)
        {
            InitializeParameters(command);
            db.SetParameterValue(command, "@CD_EMPRESA", parameterValues[0]);
            db.SetParameterValue(command, "@CD_CNPJ", parameterValues[1]);
            db.SetParameterValue(command, "@CD_MOD", parameterValues[2]);
            db.SetParameterValue(command, "@DT_DOC_INI", parameterValues[3]);
            db.SetParameterValue(command, "@DT_DOC_FIN", parameterValues[4]);
        }

        private void InitializeParameters(DbCommand command)
        {
            if (!command.Parameters.Contains("@CD_EMPRESA"))
            {
                db.AddInParameter(command, "@CD_EMPRESA", DbType.String);
            }
            if (!command.Parameters.Contains("@CD_CNPJ"))
            {
                db.AddInParameter(command, "@CD_CNPJ", DbType.String);
            }
            if (!command.Parameters.Contains("@CD_MOD"))
            {
                db.AddInParameter(command, "@CD_MOD", DbType.String);
            }
            if (!command.Parameters.Contains("@DT_DOC_INI"))
            {
                db.AddInParameter(command, "@DT_DOC_INI", DbType.DateTime);
            }
            if (!command.Parameters.Contains("@DT_DOC_FIN"))
            {
                db.AddInParameter(command, "@DT_DOC_FIN", DbType.DateTime);
            }
        }
    }
}