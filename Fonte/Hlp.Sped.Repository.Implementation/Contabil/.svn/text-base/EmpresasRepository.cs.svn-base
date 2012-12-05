using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Ninject;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Domain.Models;
using Hlp.Sped.Repository.Interfaces.Contabil;
using Hlp.Sped.Repository.Interfaces.SQLExpressions;

namespace Hlp.Sped.Repository.Implementation.Contabil
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
                empresaAccessor = UndTrabalho.DBOrigemDadosContabil.CreateSqlStringAccessor(
                  SqlExpressionsRepository.GetSelectListAllEmpresas(),
                  MapBuilder<Empresa>.MapAllProperties().Build());
            }
                
            return empresaAccessor.Execute();
        }
    }
}
