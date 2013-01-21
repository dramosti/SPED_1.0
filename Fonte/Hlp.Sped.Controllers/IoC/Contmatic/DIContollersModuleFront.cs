using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Infrastructure.IoC;
using Hlp.Sped.Repository.Interfaces;
using Hlp.Sped.Repository.Interfaces.Contmatic;
using Hlp.Sped.Repository.Interfaces.SQLExpressions;
using Hlp.Sped.Repository.Implementation;
using Hlp.Sped.Repository.Implementation.Contmatic;
using Hlp.Sped.Repository.Implementation.SQLExpressions;
using Hlp.Sped.Services.Interfaces;
using Hlp.Sped.Services.Interfaces.Contmatic;
using Hlp.Sped.Services.Implementation;
using Hlp.Sped.Services.Implementation.Contmatic;

namespace Hlp.Sped.Controllers.IoC.Contmatic
{
    public class DIContollersModuleFront : DIContollersModuleBase<UnitOfWork>
    {
        protected override void ResolveRepositories()
        {
            Bind<ISqlExpressionsRepository>().ToConstant(new SqlExpressionsRepository());
            Bind<IEmpresasRepository>().To<EmpresasRepository>();
        }

        protected override void ResolveServices()
        {
           Bind<IEmpresasService>().To<EmpresasService>();
        }
    }
}
