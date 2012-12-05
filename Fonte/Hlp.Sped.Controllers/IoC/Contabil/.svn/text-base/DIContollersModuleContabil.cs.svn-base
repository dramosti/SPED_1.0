using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Infrastructure.IoC;
using Hlp.Sped.Repository.Interfaces.Contabil;
using Hlp.Sped.Repository.Interfaces.Files;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Contabil;
using Hlp.Sped.Repository.Implementation;
using Hlp.Sped.Repository.Implementation.Contabil;
using Hlp.Sped.Repository.Implementation.SQLExpressions.Contabil;
using Hlp.Sped.Repository.Implementation.Files;
using Hlp.Sped.Services.Interfaces.Contabil;
using Hlp.Sped.Services.Interfaces.Files;
using Hlp.Sped.Services.Implementation.Contabil;
using Hlp.Sped.Services.Implementation.Files;

namespace Hlp.Sped.Controllers.IoC.Contabil
{
    public class DIContollersModuleContabil : DIContollersModuleBase<UnitOfWork>
    {
        protected override void ResolveRepositories()
        {
            Bind<ISqlExpressionsContabilRepository>().ToConstant(new SqlExpressionsContabilRepository());
            Bind<IAberturaRepository>().To<AberturaRepository>();
            Bind<ILancamentosRepository>().To<LancamentosRepository>();
            Bind<IBalancetesDiariosRepository>().To<BalancetesDiariosRepository>();
            Bind<ISaldosPeriodicosRepository>().To<SaldosPeriodicosRepository>();
            Bind<IPlanoContasRepository>().To<PlanoContasRepository>();
            Bind<IHistoricosContabeisRepository>().To<HistoricosContabeisRepository>();
            Bind<IDemonstracoesContabeisRepository>().To<DemonstracoesContabeisRepository>();
            Bind<IDadosArquivoContabilRepository>().To<DadosArquivoContabilRepository>();
            Bind<ISpedFileWriterRepository>().To<SpedFileWriterRepository>();
        }

        protected override void ResolveServices()
        {
            Bind<IAberturaService>().To<AberturaService>();
            Bind<ILancamentosService>().To<LancamentosService>();
            Bind<IBalancetesDiariosService>().To<BalancetesDiariosService>();
            Bind<ISaldosPeriodicosService>().To<SaldosPeriodicosService>();
            Bind<IPlanoContasService>().To<PlanoContasService>();
            Bind<IHistoricosContabeisService>().To<HistoricosContabeisService>();
            Bind<IDemonstracoesContabeisService>().To<DemonstracoesContabeisService>();
            Bind<IDadosArquivoContabilService>().To<DadosArquivoContabilService>();
            Bind<ISpedFileWriterService>().To<SpedFileWriterService>();
        }
    }
}
