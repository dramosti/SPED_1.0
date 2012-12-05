using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Hlp.Sped.Repository.Implementation.Contabil.Mappers
{
    public class FilterByCdEmpresaContaSuperiorNivelParameterMapper : IParameterMapper
    {
        private readonly Database db;

        public FilterByCdEmpresaContaSuperiorNivelParameterMapper(Database db)
        {
            this.db = db;
        }

        public void AssignParameters(DbCommand command, object[] parameterValues)
        {
            InitializeParameters(command);
            db.SetParameterValue(command, "@CD_EMPRESA", parameterValues[0]);
            db.SetParameterValue(command, "@CD_CONTA_SUPERIOR", parameterValues[1]);
            db.SetParameterValue(command, "@CD_NIVEL", parameterValues[2]);
        }

        private void InitializeParameters(DbCommand command)
        {
            if (!command.Parameters.Contains("@CD_EMPRESA"))
            {
                db.AddInParameter(command, "@CD_EMPRESA", DbType.String);
            }
            if (!command.Parameters.Contains("@CD_CONTA_SUPERIOR"))
            {
                db.AddInParameter(command, "@CD_CONTA_SUPERIOR", DbType.String);
            }
            if (!command.Parameters.Contains("@CD_NIVEL"))
            {
                db.AddInParameter(command, "@CD_NIVEL", DbType.Int32);
            }
        }
    }
}
