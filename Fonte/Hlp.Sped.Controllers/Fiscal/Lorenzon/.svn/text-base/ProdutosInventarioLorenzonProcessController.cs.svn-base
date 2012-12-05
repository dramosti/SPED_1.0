using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;
using Hlp.Sped.Infrastructure.Controllers;
using Hlp.Sped.Infrastructure.Files;
using Hlp.Sped.Services.Interfaces.Fiscal;
using Hlp.Sped.Services.Interfaces.Files;
using Hlp.Sped.Services.Interfaces.Fiscal.Lorenzon;
using Hlp.Sped.Domain.Models.Fiscal;
using Hlp.Sped.Domain.Models.Fiscal.Lorenzon;
using Hlp.Sped.Controllers.IoC.Fiscal.Lorenzon;
using Hlp.Sped.Controllers.Parameters.Fiscal;

namespace Hlp.Sped.Controllers.Fiscal.Lorenzon
{
    public class ProdutosInventarioLorenzonProcessController : BaseController
    {
        [Inject]
        public IDadosArquivoFiscalService DadosArquivoFiscalService { get; set; }

        [Inject]
        public ISpedFileWriterService SpedFileWriterService { get; set; }

        [Inject]
        public IInventarioLorenzonService InventarioLorenzonService { get; set; }

        private FiscalProcessParameters _parameters;


        #region Construtor

        public ProdutosInventarioLorenzonProcessController(FiscalProcessParameters parameters)
        {
            this._parameters = parameters;
            this.AsynchronousExecution +=
                new AsynchronousExecutionHandler(
                    LorenzonFiscalProcessController_AsynchronousExecution);
            this.AsynchronousExecutionAborted +=
                new AsynchronousExecutionAbortedHandler(
                    LorenzonFiscalProcessController_AsynchronousExecutionAborted);
        }

        #endregion


        #region Métodos protegidos

        protected override NinjectModule GetInstanceDIControllersModule()
        {
            DIContollersModuleFiscalLorenzon module = new DIContollersModuleFiscalLorenzon();

            module.UnitOfWork.CodigoEmpresa = this._parameters.CodigoEmpresa;
            module.UnitOfWork.DataInicial = this._parameters.DataInicial;
            module.UnitOfWork.DataFinal = this._parameters.DataFinal;
            module.UnitOfWork.TipoArquivo = this._parameters.TipoArquivo;
            module.UnitOfWork.TipoRemessa = this._parameters.TipoRemessa;
            module.UnitOfWork.CaminhoArquivo = this._parameters.CaminhoArquivo;

            return module;
        }

        #endregion


        #region Métodos privados

        private void ProcessarProdutosInventario()
        {
            DadosArquivoFiscalService.Inicializar();

            this.UpdateStatusAsynchronousExecution("Iniciando processamento de produtos");

            IEnumerable<Registro0200> registros0200 =
                InventarioLorenzonService.GetRegistros0200();
            foreach (Registro0200 reg0200 in registros0200)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro 0200");
                DadosArquivoFiscalService.PersistirRegistro(reg0200);
            }
        }

        private void ProcessarGravacaoArquivo()
        {
            try
            {
                this.UpdateStatusAsynchronousExecution("Iniciando gravação do arquivo");

                SpedFileWriterService.Initialize(this._parameters.CaminhoArquivo);
                DadosArquivoFiscalService.OpenRegistros();
                while (DadosArquivoFiscalService.ReadRegistro())
                {
                    // ATENÇÃO: Não atualizar o status de execução do form que invocou este
                    // Controller, uma vez que a manipulação de arquivos tende a levar a estouros
                    // de memória neste caso. Logo, evitar chamadas ao método "UpdateStatusAsynchronousExecution"
                    // dentro deste loop.
                    SpedFileWriterService.WriteLine(
                        DadosArquivoFiscalService.GetConteudoRegistro());
                }
                DadosArquivoFiscalService.Finalizar();
                this.UpdateStatusAsynchronousExecution("Gravação em arquivo finalizada");
            }
            finally
            {
                DadosArquivoFiscalService.CloseRegistros();
                SpedFileWriterService.Close();
            }
        }

        private void LorenzonFiscalProcessController_AsynchronousExecution()
        {
            this.ProcessarProdutosInventario();
            this.ProcessarGravacaoArquivo();
        }

        private void LorenzonFiscalProcessController_AsynchronousExecutionAborted(
            Exception ex)
        {
            DadosArquivoFiscalService.RegistrarExcecao(ex);
        }

        #endregion
    }
}