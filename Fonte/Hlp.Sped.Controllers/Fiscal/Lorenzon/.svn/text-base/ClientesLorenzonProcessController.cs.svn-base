using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Ninject;
using Ninject.Modules;
using Hlp.Sped.Infrastructure.Controllers;
using Hlp.Sped.Infrastructure.Files;
using Hlp.Sped.Services.Interfaces.Fiscal;
using Hlp.Sped.Services.Interfaces.Files;
using Hlp.Sped.Services.Interfaces.Fiscal.Lorenzon;
using Hlp.Sped.Domain.Models.Fiscal;
using Hlp.Sped.Controllers.IoC.Fiscal.Lorenzon;
using Hlp.Sped.Controllers.Parameters.Fiscal;

namespace Hlp.Sped.Controllers.Fiscal.Lorenzon
{
    public class ClientesLorenzonProcessController : BaseController
    {
        [Inject]
        public IDadosArquivoFiscalService DadosArquivoFiscalService { get; set; }

        [Inject]
        public ISpedFileWriterService SpedFileWriterService { get; set; }

        [Inject]
        public IParticipantesLorenzonService ParticipantesLorenzonService { get; set; }

        private FiscalProcessParameters _parameters;
        private List<string> _simbolosEspeciaisAEliminarIE;

        #region Construtor

        public ClientesLorenzonProcessController(FiscalProcessParameters parameters)
        {
            this.CarregarSimbolosEspeciaisAEliminarIE();
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

        private void CarregarSimbolosEspeciaisAEliminarIE()
        {
            this._simbolosEspeciaisAEliminarIE = new List<string>();
            
            if (!String.IsNullOrWhiteSpace(ConfigurationManager
                .AppSettings["SimbolosEspeciaisAEliminarIE"]))
            {
                char[] simbolos = ConfigurationManager
                    .AppSettings["SimbolosEspeciaisAEliminarIE"].Trim().ToCharArray();
                foreach (char caracter in simbolos)
                    _simbolosEspeciaisAEliminarIE.Add(caracter.ToString());
            }

            if (this._simbolosEspeciaisAEliminarIE.Count == 0)
            {
                this._simbolosEspeciaisAEliminarIE.Add(".");
                this._simbolosEspeciaisAEliminarIE.Add("/");
            }
        }

        private void ProcessarClientes()
        {
            DadosArquivoFiscalService.Inicializar();

            this.UpdateStatusAsynchronousExecution(
                "Iniciando processamento de informações de clientes");

            IEnumerable<Registro0150> registros0150 =
                ParticipantesLorenzonService.GetRegistros0150();
            foreach (Registro0150 reg0150 in registros0150)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro 0150");
                if (!String.IsNullOrWhiteSpace(reg0150.IE))
                {
                    foreach (string caracter in this._simbolosEspeciaisAEliminarIE)
                        reg0150.IE = reg0150.IE.Replace(caracter, "");
                }
                DadosArquivoFiscalService.PersistirRegistro(reg0150);
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
            this.ProcessarClientes();
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
