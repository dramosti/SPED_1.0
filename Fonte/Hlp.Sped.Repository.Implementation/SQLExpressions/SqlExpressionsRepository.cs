using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Repository.Interfaces.SQLExpressions;

namespace Hlp.Sped.Repository.Implementation.SQLExpressions
{
    public class SqlExpressionsRepository : ISqlExpressionsRepository
    {
        public string GetSelectListAllEmpresas()
        {
            return "SELECT CD_EMPRESA AS CODIGO_EMPRESA, NM_EMPRESA AS NOME_EMPRESA FROM EMPRESA ORDER BY CD_EMPRESA";
        }
    }
}
