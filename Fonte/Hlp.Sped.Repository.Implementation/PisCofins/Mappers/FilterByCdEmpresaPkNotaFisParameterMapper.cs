using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Hlp.Sped.Repository.Implementation.PisCofins.Mappers
{
    public class FilterByCdEmpresaPkNotaFisParameterMapper : IParameterMapper
    {
        private readonly Database db;

        public FilterByCdEmpresaPkNotaFisParameterMapper(Database db)
        {
            this.db = db;
        }

        public void AssignParameters(DbCommand command, object[] parameterValues)
        {
            InitializeParameters(command);
            db.SetParameterValue(command, "@CD_EMPRESA", parameterValues[0]);
            db.SetParameterValue(command, "@NR_SEQNF", parameterValues[1]);
        }

        private void InitializeParameters(DbCommand command)
        {
            if (!command.Parameters.Contains("@CD_EMPRESA"))
            {
                db.AddInParameter(command, "@CD_EMPRESA", DbType.String);
            }
            if (!command.Parameters.Contains("@NR_SEQNF"))
            {
                db.AddInParameter(command, "@NR_SEQNF", DbType.String);
            }
        }
    }
}