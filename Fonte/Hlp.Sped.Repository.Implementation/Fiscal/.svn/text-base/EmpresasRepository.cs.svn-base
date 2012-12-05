using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Repository.Interfaces.Fiscal;
using Hlp.Sped.Repository.Interfaces.SQLExpressions;
using Hlp.Sped.Domain.Models;

namespace Hlp.Sped.Repository.Implementation.Fiscal
{
    public class EmpresasRepository : IEmpresasRepository
    {
        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }

        [Inject]
        public ISqlExpressionsRepository SqlExpressionsRepository { get; set; }

        private DataAccessor<Empresa> empresaAccessor;

        public IEnumerable<Empresa> ListAll()
        {
            if (empresaAccessor == null)
            {
                empresaAccessor = UndTrabalho.DBOrigemDadosFiscal.CreateSqlStringAccessor(
                  SqlExpressionsRepository.GetSelectListAllEmpresas(),
                  MapBuilder<Empresa>.MapAllProperties().Build());
            }
                
            return empresaAccessor.Execute();
        }
    }
}
