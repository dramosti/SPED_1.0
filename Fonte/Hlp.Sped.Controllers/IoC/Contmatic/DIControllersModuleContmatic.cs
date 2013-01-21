using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.IoC;
using Hlp.Sped.Repository.Implementation;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Contmatic;
using Hlp.Sped.Repository.Implementation.SQLExpressions.Contimatic;
using Hlp.Sped.Repository.Interfaces.Contmatic;
using Hlp.Sped.Repository.Implementation.Contmatic;
using Hlp.Sped.Services.Interfaces.Contmatic;
using Hlp.Sped.Services.Implementation.Contmatic;
using Hlp.Sped.Services.Interfaces.Files;
using Hlp.Sped.Services.Implementation.Files;
using Hlp.Sped.Repository.Interfaces.Files;
using Hlp.Sped.Repository.Implementation.Files;

namespace Hlp.Sped.Controllers.IoC.Contmatic
{
    public class DIControllersModuleContmatic : DIContollersModuleBase<UnitOfWork>
    {
        protected override void ResolveRepositories()
        {
            Bind<ISqlExpressionsContmaticRepository>().ToConstant(new SqlExpressionsContmaticRepository());
            Bind<IConhecimentoTransporteRepository>().To<ConhecimentoTransporteRepository>();
            Bind<IDadosGeraisRepository>().To<DadosGeraisRepository>();
            Bind<INotasFiscaisMercadoriasRepository>().To<NotasFiscaisMercadoriasRepository>();
            Bind<INotasFiscaisServicoRepository>().To<NotasFiscaisServicoRepository>();
            Bind<IOutrasInformacoesRepository>().To<OutrasInformacoesRepository>();

            Bind<IUnidadesRepository>().To<UnidadesRepository>();
            Bind<IProdutosRepository>().To<ProdutosRepository>();
            Bind<IParticipantesRepository>().To<ParticipantesRepository>();
            Bind<IDadosArquivoContmaticRepository>().To<DadosArquivoContmaticRepository>();

            Bind<ISpedFileWriterRepository>().To<SpedFileWriterRepository>();
        }

        protected override void ResolveServices()
        {
            Bind<IConhecimentoTransporteService>().To<Hlp.Sped.Services.Implementation.Contmatic.ConhecimentoTransporteService>();
            Bind<IDadosGeraisService>().To<DadosGeraisService>();
            Bind<INotasFiscaisMercadoriasService>().To<NotasFiscaisMercadoriasService>();
            Bind<INotasFiscaisServicoService>().To<NotasFiscaisServicoService>();
            Bind<IOutrasInformacoesService>().To<OutrasInformacoesService>();


            Bind<IUnidadesService>().To<UnidadesService>();
            Bind<IProdutosService>().To<ProdutosService>();
            Bind<IParticipantesService>().To<ParticipantesService>();
            Bind<IDadosArquivoContmaticService>().To<DadosArquivoContmaticService>();

            Bind<ISpedFileWriterService>().To<SpedFileWriterService>();

        }


    }
}
