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
    public class InventarioLorenzonProcessController : BaseController
    {
        [Inject]
        public IDadosArquivoFiscalService DadosArquivoFiscalService { get; set; }

        [Inject]
        public ISpedFileWriterService SpedFileWriterService { get; set; }

        [Inject]
        public IInventarioLorenzonService InventarioLorenzonService { get; set; }

        private FiscalProcessParameters _parameters;


        #region Construtor

        public InventarioLorenzonProcessController(FiscalProcessParameters parameters)
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

        private void ProcessarInventarioFisico()
        {
            DadosArquivoFiscalService.Inicializar();

            this.UpdateStatusAsynchronousExecution("Iniciando processamento do inventário");

            IEnumerable<RegistroH005Lorenzon> registrosH005 =
                InventarioLorenzonService.GetRegistrosH005();
            foreach (RegistroH005Lorenzon regH005 in registrosH005)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro H005");
                DadosArquivoFiscalService.PersistirRegistro(regH005);

                // Processsa informações dos itens da nota fiscal
                this.UpdateStatusAsynchronousExecution("Processando itens do inventário");
                IEnumerable<RegistroH010> registrosH010 =
                    InventarioLorenzonService.GetRegistrosH010(regH005.DT_INV.Value);
                foreach (RegistroH010 regH010 in registrosH010)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro H010");
                    DadosArquivoFiscalService.PersistirRegistro(regH010);
                }
            }

            // Monta o registro de abertura do bloco, verificando se realmente existem
            // movimentações para o período especificado
            this.UpdateStatusAsynchronousExecution("Gerando Registro H001");
            RegistroH001 regH001 = new RegistroH001();
            if (registrosH005.Count() > 0)
                regH001.IND_MOV = "0";
            else
                regH001.IND_MOV = "1";
            DadosArquivoFiscalService.PersistirRegistro(regH001);

            RegistroH990 regH990 = DadosArquivoFiscalService.GetRegistroH990();
            DadosArquivoFiscalService.PersistirRegistro(regH990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro H990");
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
            this.ProcessarInventarioFisico();
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