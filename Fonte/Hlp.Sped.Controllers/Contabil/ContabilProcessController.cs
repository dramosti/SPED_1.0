using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;
using Hlp.Sped.Infrastructure.Controllers;
using Hlp.Sped.Infrastructure.Files;
using Hlp.Sped.Services.Interfaces.Contabil;
using Hlp.Sped.Services.Interfaces.Files;
using Hlp.Sped.Domain.Models.Contabil;
using Hlp.Sped.Controllers.IoC.Contabil;
using Hlp.Sped.Controllers.Parameters.Contabil;

namespace Hlp.Sped.Controllers.Contabil
{
    public class ContabilProcessController : BaseController
    {
        #region Métodos públicos

        [Inject]
        public IAberturaService AberturaService { get; set; }

        [Inject]
        public ILancamentosService LancamentosService { get; set; }

        [Inject]
        public IBalancetesDiariosService BalancetesDiariosService { get; set; }

        [Inject]
        public ISaldosPeriodicosService SaldosPeriodicosService { get; set; }

        [Inject]
        public IPlanoContasService PlanoContasService { get; set; }

        [Inject]
        public IHistoricosContabeisService HistoricosContabeisService { get; set; }

        [Inject]
        public IDadosArquivoContabilService DadosArquivoContabilService { get; set; }

        [Inject]
        public ISpedFileWriterService SpedFileWriterService { get; set; }

        [Inject]
        public IDemonstracoesContabeisService DemonstracoesContabeisService { get; set; }

        public ContabilProcessController(ContabilProcessParameters parameters)
        {
            this._parameters = parameters;
            this.AsynchronousExecution += new AsynchronousExecutionHandler(ContabilProcessController_AsynchronousExecution);
            this.AsynchronousExecutionAborted +=
                new AsynchronousExecutionAbortedHandler(ContabilProcessController_AsynchronousExecutionAborted);
        }

        #endregion

        #region Métodos protegidos

        protected override NinjectModule GetInstanceDIControllersModule()
        {
            DIContollersModuleContabil module = new DIContollersModuleContabil();

            module.UnitOfWork.CodigoEmpresa = this._parameters.CodigoEmpresa;
            module.UnitOfWork.DataInicial = this._parameters.DataInicial;
            module.UnitOfWork.DataFinal = this._parameters.DataFinal;
            module.UnitOfWork.TipoArquivo = this._parameters.TipoArquivo;
            module.UnitOfWork.CaminhoArquivo = this._parameters.CaminhoArquivo;

            return module;
        }

        #endregion

        #region Métodos privados - Processamento da Abertura Contábil

        private void ProcessarAbertura()
        {
            this.UpdateStatusAsynchronousExecution("Iniciando processamento da abertura contábil");

            DadosArquivoContabilService.Inicializar();

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0000");
            Registro0000 reg0000 = AberturaService.GetRegistro0000();
            DadosArquivoContabilService.PersistirRegistro(reg0000);

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0001");
            Registro0001 reg0001 = AberturaService.GetRegistro0001();
            DadosArquivoContabilService.PersistirRegistro(reg0001);

            IEnumerable<Registro0007> registros0007 =
                AberturaService.GetRegistros0007();
            foreach (Registro0007 reg0007 in registros0007)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro 0007");
                DadosArquivoContabilService.PersistirRegistro(reg0007);
            }
        }

        private void ProcessarRelacionamentoParticipante(Registro0150 reg0150)
        {
            this.UpdateStatusAsynchronousExecution("Processando Relacionamento dos Participantes");

            if (!DadosArquivoContabilService.RegistroJaExistente("0180", reg0150.COD_PART))
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro 0180");
                Registro0180 reg0180 = AberturaService.GetRegistro0180(reg0150.COD_PART);
                DadosArquivoContabilService.PersistirRegistro(reg0180);
            }
        }

        #endregion

        #region Métodos privados - Processamento dos Lançamentos Contábeis

        private void ProcessarLancamentos()
        {
            this.UpdateStatusAsynchronousExecution("Iniciando processamento dos lançamentos contábeis");

            this.UpdateStatusAsynchronousExecution("Gerando Registro I001");
            RegistroI001 regI001 = LancamentosService.GetRegistroI001();
            DadosArquivoContabilService.PersistirRegistro(regI001);

            this.UpdateStatusAsynchronousExecution("Gerando Registro I010");
            RegistroI010 regI010 = LancamentosService.GetRegistroI010();
            DadosArquivoContabilService.PersistirRegistro(regI010);

            this.ProcessarPlanoContas();
            this.ProcessarSaldosPeriodicos(); // método com problema decimal
            this.ProcessarLancamentosPeriodo();
            this.ProcessarBalancetesPeriodo();
            
            this.UpdateStatusAsynchronousExecution("Gerando Registro I990");
            RegistroI990 regI990 = DadosArquivoContabilService.GetRegistroI990();
            DadosArquivoContabilService.PersistirRegistro(regI990);
        }

        private void ProcessarPlanoContas()
        {
            // Processamento do Plano de Contas
            IEnumerable<RegistroI050> registrosI050 =
                PlanoContasService.GetRegistrosI050();
            foreach (RegistroI050 regI050 in registrosI050)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro I050");
                DadosArquivoContabilService.PersistirRegistro(regI050);
            }
        }

        private void ProcessarSaldosPeriodicos()
        {
            this.UpdateStatusAsynchronousExecution("Processando saldos periódicos");

            RegistroI150 regI150 =
                SaldosPeriodicosService.GetRegistroI150();
            this.UpdateStatusAsynchronousExecution("Gerando Registro I150");
            DadosArquivoContabilService.PersistirRegistro(regI150);

            IEnumerable<RegistroI155> registrosI155 =
                SaldosPeriodicosService.GetRegistrosI155();
            foreach (RegistroI155 regI155 in registrosI155)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro I155");
                DadosArquivoContabilService.PersistirRegistro(regI155);
            }
        }

        private void ProcessarLancamentosPeriodo()
        {
            if (!LancamentosService.EfetuarProcessamentoLancamentosContabeis())
                return;

            this.UpdateStatusAsynchronousExecution("Iniciando processamento de lançamentos contábeis");

            IEnumerable<RegistroI200> registrosI200 =
                            LancamentosService.GetRegistrosI200();
            foreach (RegistroI200 regI200 in registrosI200)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro I200");
                DadosArquivoContabilService.PersistirRegistro(regI200);

                this.ProcessarDetalhesLancamentosContabeis(regI200);
            }
        }

        private void ProcessarDetalhesLancamentosContabeis(RegistroI200 regI200)
        {
            this.UpdateStatusAsynchronousExecution("Processando detalhes de lançamento contábil");

            IEnumerable<RegistroI250> registrosI250 =
                LancamentosService.GetRegistrosI250(regI200.NUM_LCTO);
            foreach (RegistroI250 regI250 in registrosI250)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro I250");
                DadosArquivoContabilService.PersistirRegistro(regI250);

                this.ProcessarHistoricoPadrao(regI250.COD_HIST_PAD);
            }
        }

        private void ProcessarHistoricoPadrao(string codigoHistorico)
        {
            if (String.IsNullOrWhiteSpace(codigoHistorico))
                return;

            if (!DadosArquivoContabilService.RegistroJaExistente("I075", codigoHistorico))
            {
                // Apenas persiste uma unidade se a mesma ainda não tiver sido processada
                this.UpdateStatusAsynchronousExecution("Gerando Registro I075");
                RegistroI075 regI075 = HistoricosContabeisService.GetRegistroI075(codigoHistorico);
                if (regI075 != null)
                    DadosArquivoContabilService.PersistirRegistro(regI075);
            }
        }

        private void ProcessarBalancetesPeriodo()
        {
            if (!BalancetesDiariosService.EfetuarProcessamentoBalancetesDiarios())
                return;

            this.UpdateStatusAsynchronousExecution("Iniciando processamento de balancetes diários");

            IEnumerable<RegistroI300> registrosI300 =
                BalancetesDiariosService.GetRegistrosI300();
            foreach (RegistroI300 regI300 in registrosI300)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro I300");
                DadosArquivoContabilService.PersistirRegistro(regI300);

                this.ProcessarDetalhesBalancetesDiarios(regI300);
            }
        }

        private void ProcessarDetalhesBalancetesDiarios(RegistroI300 regI300)
        {
            this.UpdateStatusAsynchronousExecution("Processando detalhes de balancetes diários");

            IEnumerable<RegistroI310> registrosI310 =
                BalancetesDiariosService.GetRegistrosI310(regI300.DT_BCTE);
            foreach (RegistroI310 regI310 in registrosI310)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro I310");
                DadosArquivoContabilService.PersistirRegistro(regI310);
            }
        }

        #endregion


        #region Métodos privados - Processamento de Demonstrações Contábeis

        private void ProcessarDemonstracoesContabeis()
        {
            this.UpdateStatusAsynchronousExecution("Iniciando processamento das demonstrações contábeis");

            this.UpdateStatusAsynchronousExecution("Gerando Registro J001");
            RegistroJ001 regJ001 = DemonstracoesContabeisService.GetRegistroJ001();
            DadosArquivoContabilService.PersistirRegistro(regJ001);

            IEnumerable<RegistroJ930> registrosJ930 =
                DemonstracoesContabeisService.GetRegistrosJ930();
            foreach (RegistroJ930 regJ930 in registrosJ930)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro J930");
                DadosArquivoContabilService.PersistirRegistro(regJ930);
            }

            this.UpdateStatusAsynchronousExecution("Gerando Registro J990");
            RegistroJ990 regJ990 = DadosArquivoContabilService.GetRegistroJ990();
            DadosArquivoContabilService.PersistirRegistro(regJ990);
        }

        #endregion


        #region Outros métodos privados

        private ContabilProcessParameters _parameters;

        private void ProcessarControlesEncerramento()
        {
            this.UpdateStatusAsynchronousExecution("Iniciando geração dos controles de encerramento");

            // Como pode ocorrer a inclusão de dados de Participantes, Produtos e Unidades
            // em outros blocos, a geração do registro 0990 deve ocorrer somente neste momento
            this.UpdateStatusAsynchronousExecution("Gerando Registro 0990");
            Registro0990 reg0990 = DadosArquivoContabilService.GetRegistro0990();
            DadosArquivoContabilService.PersistirRegistro(reg0990);

            Registro9001 reg9001 = DadosArquivoContabilService.GetRegistro9001();
            DadosArquivoContabilService.PersistirRegistro(reg9001);
            this.UpdateStatusAsynchronousExecution("Gerando Registro 9001");

            List<Registro9900> registros9900 = DadosArquivoContabilService.GetRegistros9900().ToList();
            foreach (Registro9900 reg9900 in registros9900)
            {
                DadosArquivoContabilService.PersistirRegistro(reg9900);
                this.UpdateStatusAsynchronousExecution("Gerando Registro 9900");
            }

            Registro9990 reg9990 = DadosArquivoContabilService.GetRegistro9990();
            DadosArquivoContabilService.PersistirRegistro(reg9990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro 9990");

            Registro9999 reg9999 = DadosArquivoContabilService.GetRegistro9999();
            DadosArquivoContabilService.PersistirRegistro(reg9999);
            this.UpdateStatusAsynchronousExecution("Gerando Registro 9999");
        }

        private void ProcessarGravacaoArquivo()
        {
            try
            {
                this.UpdateStatusAsynchronousExecution("Iniciando gravação do arquivo");

                SpedFileWriterService.Initialize(this._parameters.CaminhoArquivo);
                DadosArquivoContabilService.OpenRegistros();
                while (DadosArquivoContabilService.ReadRegistro())
                {
                    SpedFileWriterService.WriteLine(
                        DadosArquivoContabilService.GetConteudoRegistro());
                }
                DadosArquivoContabilService.Finalizar();
                this.UpdateStatusAsynchronousExecution("Gravação em arquivo finalizada");
            }
            finally
            {
                DadosArquivoContabilService.CloseRegistros();
                SpedFileWriterService.Close();
            }
        }

        private void ContabilProcessController_AsynchronousExecution()
        {
            this.ProcessarAbertura();
            this.ProcessarLancamentos();
            this.ProcessarDemonstracoesContabeis();
            this.ProcessarControlesEncerramento();
            this.ProcessarGravacaoArquivo();
        }

        private void ContabilProcessController_AsynchronousExecutionAborted(Exception ex)
        {
            DadosArquivoContabilService.RegistrarExcecao(ex);
        }
        
        #endregion
    }
}