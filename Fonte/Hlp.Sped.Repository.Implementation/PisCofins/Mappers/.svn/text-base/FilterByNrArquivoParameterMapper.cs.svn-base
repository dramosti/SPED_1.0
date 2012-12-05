using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Hlp.Sped.Repository.Implementation.PisCofins.Mappers
{
    public class FilterByNrArquivoParameterMapper : IParameterMapper
    {
        private readonly Database db;

        public FilterByNrArquivoParameterMapper(Database db)
        {
            this.db = db;
        }

        public void AssignParameters(DbCommand command, object[] parameterValues)
        {
            InitializeParameters(command);
            db.SetParameterValue(command, "@NR_ARQUIVO", parameterValues[0]);
        }

        private void InitializeParameters(DbCommand command)
        {
            if (!command.Parameters.Contains("@NR_ARQUIVO"))
            {
                db.AddInParameter(command, "@NR_ARQUIVO", DbType.Int32);
            }
        }
    }
}
