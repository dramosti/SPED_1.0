using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;
using Hlp.Sped.Infrastructure;
using Hlp.Sped.Infrastructure.IoC;
using Hlp.Sped.Repository.Interfaces.PisCofins;
using Hlp.Sped.Repository.Interfaces.Files;
using Hlp.Sped.Repository.Interfaces.SQLExpressions.PisCofins;
using Hlp.Sped.Repository.Implementation;
using Hlp.Sped.Repository.Implementation.PisCofins;
using Hlp.Sped.Repository.Implementation.SQLExpressions.PisCofins;
using Hlp.Sped.Repository.Implementation.Files;
using Hlp.Sped.Services.Interfaces.PisCofins;
using Hlp.Sped.Services.Interfaces.Files;
using Hlp.Sped.Services.Implementation.PisCofins;
using Hlp.Sped.Services.Implementation.Files;

namespace Hlp.Sped.Controllers.IoC.PisCofins
{
    public class DIContollersModulePisCofins : DIContollersModuleBase<UnitOfWork>
    {
        protected override void ResolveRepositories()
        {
            Bind<ISqlExpressionsPisCofinsRepository>().ToConstant(new SqlExpressionsPisCofinsRepository());
            Bind<IDadosGeraisRepository>().To<DadosGeraisRepository>();
            Bind<IParticipantesRepository>().To<ParticipantesRepository>();
            Bind<IUnidadesRepository>().To<UnidadesRepository>();
            Bind<IProdutosRepository>().To<ProdutosRepository>();
            Bind<INotasFiscaisServicoRepository>().To<NotasFiscaisServicoRepository>();
            Bind<IDocumentosFiscaisMercadoriasRepository>().To<DocumentosFiscaisMercadoriasRepository>();
            Bind<INotasFiscaisMercadoriasRepository>().To<NotasFiscaisMercadoriasRepository>();
            Bind<IConsolidacaoNotasFiscaisRepository>().To<ConsolidacaoNotasFiscaisRepository>();
            Bind<ICuponsFiscaisRepository>().To<CuponsFiscaisRepository>();
            Bind<INotasFiscaisEnergiaAguaGasRepository>().To<NotasFiscaisEnergiaAguaGasRepository>();
            Bind<IDadosArquivoPisCofinsRepository>().To<DadosArquivoPisCofinsRepository>();
            Bind<ISpedFileWriterRepository>().To<SpedFileWriterRepository>();
        }

        protected override void ResolveServices()
        {
            Bind<IDadosGeraisService>().To<DadosGeraisService>();
            Bind<IParticipantesService>().To<ParticipantesService>();
            Bind<IUnidadesService>().To<UnidadesService>();
            Bind<IProdutosService>().To<ProdutosService>();
            Bind<INotasFiscaisServicoService>().To<NotasFiscaisServicoService>();
            Bind<IDocumentosFiscaisMercadoriasService>().To<DocumentosFiscaisMercadoriasService>();
            Bind<INotasFiscaisMercadoriasService>().To<NotasFiscaisMercadoriasService>();
            Bind<IConsolidacaoNotasFiscaisService>().To<ConsolidacaoNotasFiscaisService>();
            Bind<ICuponsFiscaisService>().To<CuponsFiscaisService>();
            Bind<INotasFiscaisEnergiaAguaGasService>().To<NotasFiscaisEnergiaAguaGasService>();
            Bind<IDadosArquivoPisCofinsService>().To<DadosArquivoPisCofinsService>();
            Bind<ISpedFileWriterService>().To<SpedFileWriterService>();
        }
    }
}