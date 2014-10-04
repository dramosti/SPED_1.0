using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Infrastructure.IoC;
using Hlp.Sped.Repository.Interfaces.Fiscal;
using Hlp.Sped.Repository.Interfaces.Files;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.Fiscal;
using Hlp.Sped.Repository.Implementation;
using Hlp.Sped.Repository.Implementation.Fiscal;
using Hlp.Sped.Repository.Implementation.SQLExpressions.Fiscal;
using Hlp.Sped.Repository.Implementation.Files;
using Hlp.Sped.Services.Interfaces.Fiscal;
using Hlp.Sped.Services.Interfaces.Files;
using Hlp.Sped.Services.Implementation.Fiscal;
using Hlp.Sped.Services.Implementation.Files;

namespace Hlp.Sped.Controllers.IoC.Fiscal
{
    public class DIContollersModuleFiscal : DIContollersModuleBase<UnitOfWork>
    {
        protected override void ResolveRepositories()
        {
            Bind<ISqlExpressionsFiscalRepository>().ToConstant(new SqlExpressionsFiscalRepository());
            Bind<IDadosGeraisRepository>().To<DadosGeraisRepository>();
            Bind<IDadosArquivoFiscalRepository>().To<DadosArquivoFiscalRepository>();
            Bind<INotasFiscaisMercadoriasRepository>().To<NotasFiscaisMercadoriasRepository>();
            Bind<ICuponsFiscaisRepository>().To<CuponsFiscaisRepository>();
            Bind<INotasFiscaisEnergiaAguaGasRepository>().To<NotasFiscaisEnergiaAguaGasRepository>();
            Bind<IConhecimentoTransporteRepository>().To<ConhecimentoTransporteRepository>();
            Bind<INotasFiscaisServComunicacaoRepository>().To<NotasFiscaisServComunicacaoRepository>();
            Bind<IApuracaoRepository>().To<ApuracaoRepository>();
            Bind<IInventarioRepository>().To<InventarioRepository>();
            Bind<IParticipantesRepository>().To<ParticipantesRepository>();
            Bind<IProdutosRepository>().To<ProdutosRepository>();
            Bind<IUnidadesRepository>().To<UnidadesRepository>();
            Bind<IOutrasInformacoesRepository>().To<OutrasInformacoesRepository>();
            Bind<ISpedFileWriterRepository>().To<SpedFileWriterRepository>();
            Bind<IProducaoRepository>().To<ProducaoRepository>();
        }

        protected override void ResolveServices()
        {
            Bind<IDadosGeraisService>().To<DadosGeraisService>();
            Bind<IDadosArquivoFiscalService>().To<DadosArquivoFiscalService>();
            Bind<INotasFiscaisMercadoriasService>().To<NotasFiscaisMercadoriasService>();
            Bind<ICuponsFiscaisService>().To<CuponsFiscaisService>();
            Bind<INotasFiscaisEnergiaAguaGasService>().To<NotasFiscaisEnergiaAguaGasService>();
            Bind<IConhecimentoTransporteService>().To<ConhecimentoTransporteService>();
            Bind<INotasFiscaisServComunicacaoService>().To<NotasFiscaisServComunicacaoService>();
            Bind<IApuracaoServices>().To<ApuracaoServices>();
            Bind<IInventarioService>().To<InventarioService>();
            Bind<IParticipantesService>().To<ParticipantesService>();
            Bind<IProdutosService>().To<ProdutosService>();
            Bind<IUnidadesService>().To<UnidadesService>();
            Bind<IOutrasInformacoesService>().To<OutrasInformacoesService>();
            Bind<ISpedFileWriterService>().To<SpedFileWriterService>();
            Bind<IProducaoService>().To<ProducaoService>();
        }
    }
}