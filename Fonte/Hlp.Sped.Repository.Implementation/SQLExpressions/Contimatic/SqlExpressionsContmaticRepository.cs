using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Contmatic;

namespace Hlp.Sped.Repository.Implementation.SQLExpressions.Contimatic
{
    public class SqlExpressionsContmaticRepository : ISqlExpressionsContmaticRepository
    {
        public string GetSelectRegistro0000()
        {
            return @"SELECT * FROM SP_SPED_CONTMAT_REGISTRO0000(?)";
        }
    }
}
