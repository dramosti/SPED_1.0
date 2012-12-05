using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Infrastructure.IoC;
using Hlp.Sped.Repository.Interfaces;
using Hlp.Sped.Repository.Interfaces.SQLExpressions;
using Hlp.Sped.Repository.Implementation;
using Hlp.Sped.Repository.Implementation.SQLExpressions;
using Hlp.Sped.Services.Interfaces;
using Hlp.Sped.Services.Implementation;

namespace Hlp.Sped.Controllers.IoC
{
    public class DIContollersModuleConfigConnections : DIContollersModuleBase<UnitOfWork>
    {
        protected override void ResolveRepositories()
        {
            Bind<IConexoesRepository>().To<ConexoesRepository>();
        }

        protected override void ResolveServices()
        {
            Bind<IConexoesService>().To<ConexoesService>();
        }
    }
}
