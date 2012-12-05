using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Infrastructure.IoC;
using Hlp.Sped.Repository.Implementation;
using Hlp.Sped.Repository.Interfaces.Fiscal;
using Hlp.Sped.Repository.Implementation.Fiscal;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Fiscal;
using Hlp.Sped.Repository.Implementation.SQLExpressions.Fiscal;
using Hlp.Sped.Services.Interfaces.Fiscal;
using Hlp.Sped.Services.Implementation.Fiscal;
using Hlp.Sped.Repository.Interfaces.Fiscal.Lorenzon;
using Hlp.Sped.Repository.Implementation.Fiscal.Lorenzon;
using Hlp.Sped.Services.Interfaces.Fiscal.Lorenzon;
using Hlp.Sped.Services.Implementation.Fiscal.Lorenzon;
using Hlp.Sped.Repository.Interfaces.Files;
using Hlp.Sped.Repository.Implementation.Files;
using Hlp.Sped.Services.Interfaces.Files;
using Hlp.Sped.Services.Implementation.Files;

namespace Hlp.Sped.Controllers.IoC.Fiscal.Lorenzon
{
    public class DIContollersModuleFiscalLorenzon : DIContollersModuleBase<UnitOfWork>
    {
        protected override void ResolveRepositories()
        {
            Bind<ISqlExpressionsFiscalRepository>().ToConstant(new SqlExpressionsFiscalRepository());
            Bind<IDadosArquivoFiscalRepository>().To<DadosArquivoFiscalRepository>();
            Bind<IParticipantesLorenzonRepository>().To<ParticipantesLorenzonRepository>();
            Bind<IInventarioLorenzonRepository>().To<InventarioLorenzonRepository>();
            Bind<ISpedFileWriterRepository>().To<SpedFileWriterRepository>();
        }

        protected override void ResolveServices()
        {
            Bind<IDadosArquivoFiscalService>().To<DadosArquivoFiscalService>();
            Bind<IParticipantesLorenzonService>().To<ParticipantesLorenzonService>();
            Bind<IInventarioLorenzonService>().To<InventarioLorenzonService>();
            Bind<ISpedFileWriterService>().To<SpedFileWriterService>();
        }
    }
}
