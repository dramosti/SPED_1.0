using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Controllers;
using Hlp.Sped.Controllers.IoC.Contmatic;
using Hlp.Sped.Controllers.Parameters.Contmatic;
using Ninject;
using Hlp.Sped.Services.Interfaces.Contmatic;
using Hlp.Sped.Services.Interfaces.Files;
using Hlp.Sped.Controllers.Parameters.Fiscal;
using Hlp.Sped.Services.Implementation.Contmatic;
using Hlp.Sped.Domain.Models.Contmatic;
using System.Collections;

namespace Hlp.Sped.Controllers.Contmatic
{
    public class ContmaticProcessController : BaseController
    {
        private ContmaticProcessParameters _parameters;

        [Inject]
        public IDadosArquivoContmaticService dadosArquivoContmaticService { get; set; }

        [Inject]
        public IConhecimentoTransporteService conhecimentoTransporteService { get; set; }
        [Inject]
        public IDadosGeraisService dadosGeraisService { get; set; }
        [Inject]
        public INotasFiscaisMercadoriasService notasFiscaisMercadoriasService { get; set; }
        [Inject]
        public INotasFiscaisServicoService notasFiscaisService { get; set; }
        [Inject]
        public IOutrasInformacoesService outrasInformacoesService { get; set; }
        [Inject]
        public IParticipantesService ParticipantesService { get; set; }
        [Inject]
        public IUnidadesService unidadesService { get; set; }
        [Inject]
        public IProdutosService produtosService { get; set; }
        [Inject]
        public INotasFiscaisServicoService notasFiscaisServicoService { get; set; }

        [Inject]
        public ISpedFileWriterService SpedFileWriterService { get; set; }

        #region Métodos privados - Processamento de Blocos

        private void ProcessarDadosGerais()
        {
            dadosArquivoContmaticService.Inicializar();

            //0000 ok
            //0100 ok
            //0150 ok
            //0190 ok
            //0200 ok
            //0220 ok
            //0400 ok
            //0600 ok

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0000");
            Registro0000 reg0000 = dadosGeraisService.GetRegistro0000();
            dadosArquivoContmaticService.PersistirRegistro(reg0000);

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0001");
            Registro0001 reg0001 = dadosGeraisService.GetRegistro0001();
            dadosArquivoContmaticService.PersistirRegistro(reg0001);

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0100");
            Registro0100 reg0100 = dadosGeraisService.GetRegistro0100();
            dadosArquivoContmaticService.PersistirRegistro(reg0100);

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0400");
            foreach (Registro0400 reg0400 in dadosGeraisService.GetRegistro0400())
            {
                dadosArquivoContmaticService.PersistirRegistro(reg0400);
            }

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0600");
            foreach (Registro0600 reg0600 in dadosGeraisService.GetRegistro0600())
            {
                dadosArquivoContmaticService.PersistirRegistro(reg0600);
            }


        }

        private void ProcessarParticipante(string codigoParticipante)
        {
            if (String.IsNullOrWhiteSpace(codigoParticipante))
                return;

            if (!dadosArquivoContmaticService.RegistroJaExistente("0150", codigoParticipante))
            {
                // Caso o cliente ou fornecedor ainda não tenha sido processado,
                // persiste o mesmo para posterior geração do arquivo
                this.UpdateStatusAsynchronousExecution("Gerando Registro 0150");
                Registro0150 reg0150 = ParticipantesService.GetRegistro0150(codigoParticipante);
                if (reg0150 != null)
                    dadosArquivoContmaticService.PersistirRegistro(reg0150);
            }
        }

        private void ProcessarUnidade(string codigoUnidade)
        {
            if (String.IsNullOrWhiteSpace(codigoUnidade))
                return;

            if (!dadosArquivoContmaticService.RegistroJaExistente("0190", codigoUnidade))
            {
                // Apenas persiste uma unidade se a mesma ainda não tiver sido processada
                this.UpdateStatusAsynchronousExecution("Gerando Registro 0190");
                Registro0190 reg0190 = unidadesService.GetRegistro0190(codigoUnidade);
                if (reg0190 != null)
                    dadosArquivoContmaticService.PersistirRegistro(reg0190);
            }
        }

        private void ProcessarProduto(string codigoProduto)
        {
            if (String.IsNullOrWhiteSpace(codigoProduto))
                return;

            IEnumerable<Registro0220> lreg220;
            if (!dadosArquivoContmaticService.RegistroJaExistente("0200", codigoProduto))
            {
                // Apenas persiste uma unidade se a mesma ainda não tiver sido processada
                this.UpdateStatusAsynchronousExecution("Gerando Registro 0200");
                Registro0200 reg0200 = produtosService.GetRegistro0200(codigoProduto);
                if (reg0200 != null)
                {
                    dadosArquivoContmaticService.PersistirRegistro(reg0200);
                    this.ProcessarUnidade(reg0200.UNID_INV);

                    lreg220 = produtosService.GetRegistros0220(reg0200.COD_ITEM);
                    foreach (Registro0220 item in lreg220)
                    {
                        this.UpdateStatusAsynchronousExecution("Gerando Registros 0220");
                        //item.FAT_CONV
                        if (!dadosArquivoContmaticService.RegistroJaExistente("0190", item.UNID_CONV))
                        {
                            // Apenas persiste uma unidade se a mesma ainda não tiver sido processada
                            this.UpdateStatusAsynchronousExecution("Gerando Registro 0190");
                            Registro0190 reg0190 = unidadesService.GetRegistro0190(item.UNID_CONV);
                            if (reg0190 != null)
                                dadosArquivoContmaticService.PersistirRegistro(reg0190);
                        }
                        dadosArquivoContmaticService.PersistirRegistro(item);
                    }
                }
            }
        }

        private void ProcessarDocumentosFiscaisServico()
        {
            IEnumerable<RegistroA100> registrosA100;
            registrosA100 = notasFiscaisServicoService.GetRegistrosA100();
            foreach (RegistroA100 regA100 in registrosA100)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro A100");
                dadosArquivoContmaticService.PersistirRegistro(regA100);

                // Processa informações do cliente ou fornecedor vinculado a uma nota fiscal
                this.ProcessarParticipante(regA100.COD_PART);

                if (regA100.ST_DOC_CANCELADO != "S") // Não persiste registros filhos caso haja cancelamento
                    this.ProcessarDetalhesDocumentosFiscaisServico(regA100);
            }

            // Monta o registro de abertura do bloco, verificando se realmente existem
            // movimentações para o período especificado
            this.UpdateStatusAsynchronousExecution("Gerando Registro A001");
            RegistroA001 regA001 = new RegistroA001();
            if (dadosArquivoContmaticService.BlocoPossuiRegistros("A"))
                regA001.IND_MOV = "0";
            else
                regA001.IND_MOV = "1";
            dadosArquivoContmaticService.PersistirRegistro(regA001);

            RegistroA990 regA990 = dadosArquivoContmaticService.GetRegistroA990();
            dadosArquivoContmaticService.PersistirRegistro(regA990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro A990");
        }

        private void ProcessarDetalhesDocumentosFiscaisServico(RegistroA100 regA100)
        {
            this.UpdateStatusAsynchronousExecution("Processando detalhes de documento fiscal");

            // Processsa informações dos itens da nota fiscal
            this.UpdateStatusAsynchronousExecution("Processando itens de documento fiscal");
            IEnumerable<RegistroA170> registrosA170 =
                notasFiscaisServicoService.GetRegistrosA170(regA100.PK_NOTAFIS);
            foreach (RegistroA170 regA170 in registrosA170)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro A170");
                dadosArquivoContmaticService.PersistirRegistro(regA170);

                this.ProcessarProduto(regA170.COD_ITEM);
            }
        }

        private void ProcessarNotasFiscaisMercadorias()
        {
            IEnumerable<RegistroC100> registrosC100 =
                notasFiscaisMercadoriasService.GetRegistrosC100();
            foreach (RegistroC100 regC100 in registrosC100)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro C100");
                dadosArquivoContmaticService.PersistirRegistro(regC100);

                // Processa informações do cliente ou fornecedor vinculado a uma nota fiscal
                this.ProcessarParticipante(regC100.COD_PART);

                if (regC100.ST_DOC_CANCELADO != "S") // Não persiste registros filhos caso haja cancelamento
                    this.ProcessarDetalhesNotasFiscaisMercadorias(regC100);
            }

            // Monta o registro de abertura do bloco, verificando se realmente existem
            // movimentações para o período especificado
            this.UpdateStatusAsynchronousExecution("Gerando Registro C001");
            RegistroC001 regC001 = new RegistroC001();
            if (dadosArquivoContmaticService.BlocoPossuiRegistros("C"))
                regC001.IND_MOV = "0";
            else
                regC001.IND_MOV = "1";
            dadosArquivoContmaticService.PersistirRegistro(regC001);

            this.UpdateStatusAsynchronousExecution("Gerando Registro C990");
            RegistroC990 regC990 = dadosArquivoContmaticService.GetRegistroC990();
            dadosArquivoContmaticService.PersistirRegistro(regC990);
        }

        private void ProcessarDetalhesNotasFiscaisMercadorias(RegistroC100 regC100)
        {
            try
            {
                this.UpdateStatusAsynchronousExecution("Processando detalhes de documento fiscal");

                // Processsa informações dos itens da nota fiscal
                this.UpdateStatusAsynchronousExecution("Processando itens de documento fiscal");
                IEnumerable<RegistroC170> registrosC170 =
                    notasFiscaisMercadoriasService.GetRegistrosC170(regC100.PK_NOTAFIS);
                foreach (RegistroC170 regC170 in registrosC170)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro C170");
                    dadosArquivoContmaticService.PersistirRegistro(regC170);

                    this.ProcessarUnidade(regC170.UNID);
                    this.ProcessarProduto(regC170.COD_ITEM);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ProcessarCuponsFiscais()
        {
            //SP_SPED_CONTMAT_REGISTROC400
            IEnumerable<RegistroC400> registrosC400 =
                notasFiscaisMercadoriasService.GetRegistrosC400();
            IEnumerable<RegistroC405> registrosC405;
            IEnumerable<RegistroC460> registrosC460;
            IEnumerable<RegistroC470> registrosC470;

            foreach (RegistroC400 regC400 in registrosC400)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro C400");
                dadosArquivoContmaticService.PersistirRegistro(regC400);

                registrosC405 = notasFiscaisMercadoriasService
                    .GetRegistrosC405(regC400.PK_ECF);

                foreach (RegistroC405 regC405 in registrosC405)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro C405");
                    dadosArquivoContmaticService.PersistirRegistro(regC405);

                    registrosC460 = notasFiscaisMercadoriasService.GetRegistrosC460(
                        regC400.PK_ECF, regC405.DT_DOC.Value);
                    foreach (RegistroC460 regC460 in registrosC460)
                    {
                        this.UpdateStatusAsynchronousExecution("Gerando Registro C460");
                        dadosArquivoContmaticService.PersistirRegistro(regC460);

                        // Processsa informações dos resumo de itens do movimento diário
                        this.UpdateStatusAsynchronousExecution("Processando itens de Cupom Fiscal");
                        registrosC470 = notasFiscaisMercadoriasService.GetRegistrosC470(regC460.PK_CUPOMFIS);
                        foreach (RegistroC470 regC470 in registrosC470)
                        {
                            this.UpdateStatusAsynchronousExecution("Gerando Registro C470");
                            dadosArquivoContmaticService.PersistirRegistro(regC470);

                            this.ProcessarUnidade(regC470.UNID);
                            this.ProcessarProduto(regC470.COD_ITEM);
                        }
                    }

                    IEnumerable<RegistroC500> registrosC500 = notasFiscaisMercadoriasService.GetRegistrosC500();

                    foreach (RegistroC500 regC500 in registrosC500)
                    {
                        this.UpdateStatusAsynchronousExecution("Gerando Registro C500");
                        dadosArquivoContmaticService.PersistirRegistro(regC500);
                    }
                }
            }
        }

        private void ProcessarConhecimentosTransporte()
        {
            IEnumerable<RegistroD101> registrosD101;
            IEnumerable<RegistroD110> registrosD110;
            IEnumerable<RegistroD120> registrosD120;
            IEnumerable<RegistroD130> registrosD130;
            IEnumerable<RegistroD190> registrosD190;

            IEnumerable<RegistroD100> registrosD100 =
                conhecimentoTransporteService.GetRegistrosD100();
            foreach (RegistroD100 regD100 in registrosD100)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro D100");
                dadosArquivoContmaticService.PersistirRegistro(regD100);

                // Processa informações do cliente ou fornecedor vinculado a uma nota fiscal
                this.ProcessarParticipante(regD100.COD_PART);

                // registrosD101 = conhecimentoTransporteService.GetRegistrosD101(  VERIFICAR COM ÉRICK


                if (regD100.ST_DOC_CANCELADO != "S") // Não persiste registros filhos caso haja cancelamento
                {
                    registrosD110 = conhecimentoTransporteService.GetRegistrosD110(
                        regD100.PK_NOTAFIS);
                    foreach (RegistroD110 regD110 in registrosD110)
                    {
                        dadosArquivoContmaticService.PersistirRegistro(regD110);
                        this.UpdateStatusAsynchronousExecution("Gerando Registro D110");
                    }

                    registrosD120 = conhecimentoTransporteService.GetRegistrosD120(
                        regD100.PK_NOTAFIS);
                    foreach (RegistroD120 regD120 in registrosD120)
                    {
                        dadosArquivoContmaticService.PersistirRegistro(regD120);
                        this.UpdateStatusAsynchronousExecution("Gerando Registro D120");
                    }

                    registrosD130 = conhecimentoTransporteService.GetRegistrosD130(
                        regD100.PK_NOTAFIS);
                    foreach (RegistroD130 regD130 in registrosD130)
                    {
                        dadosArquivoContmaticService.PersistirRegistro(regD130);
                        this.UpdateStatusAsynchronousExecution("Gerando Registro D130");

                        // Gravação de informações de Participantes
                        this.ProcessarParticipante(regD130.COD_PART_CONSG);
                        this.ProcessarParticipante(regD130.COD_PART_RED);
                    }

                    registrosD190 = conhecimentoTransporteService.GetRegistrosD190(
                        regD100.PK_NOTAFIS);
                    foreach (RegistroD190 regD190 in registrosD190)
                    {
                        dadosArquivoContmaticService.PersistirRegistro(regD190);
                        this.UpdateStatusAsynchronousExecution("Gerando Registro D190");
                    }
                }
            }
            this.ProcessarNotaServicoComunicacao();

            RegistroD001 regD001 = new RegistroD001();
            if (dadosArquivoContmaticService.BlocoPossuiRegistros("D"))
                regD001.IND_MOV = "0";
            else
                regD001.IND_MOV = "1";

            dadosArquivoContmaticService.PersistirRegistro(regD001);
            this.UpdateStatusAsynchronousExecution("Gerando Registro D001");

            RegistroD990 regD990 = dadosArquivoContmaticService.GetRegistroD990();
            dadosArquivoContmaticService.PersistirRegistro(regD990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro D990");
        }

        private void ProcessarNotaServicoComunicacao()
        {
            IEnumerable<RegistroD500> registrosD500 = conhecimentoTransporteService.GetRegistrosD500();
            IEnumerable<RegistroD510> registrosD510;
            IEnumerable<RegistroD590> registrosD590;

            foreach (RegistroD500 regD500 in registrosD500)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro D500");
                dadosArquivoContmaticService.PersistirRegistro(regD500);


                registrosD510 = conhecimentoTransporteService.GetRegistrosD510(regD500.PK_NOTAFIS);
                foreach (RegistroD510 regD510 in registrosD510)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro D510");
                    dadosArquivoContmaticService.PersistirRegistro(regD510);
                }

                registrosD590 = conhecimentoTransporteService.GetRegistrosD590(regD500.PK_NOTAFIS);
                foreach (RegistroD590 regD590 in registrosD590)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro D590");
                    dadosArquivoContmaticService.PersistirRegistro(regD590);
                }
            }

        }

        private void ProcessarOutrasInformacoes()
        {
            // Nesta primeira versão isto ainda não será implementado; levantar posteriormente
            // se isto realmente é necessário
            this.UpdateStatusAsynchronousExecution("Iniciando processamento de outras informações");


            IEnumerable<Registro1010> registros1010 = outrasInformacoesService.GetRegistros1010();

            foreach (Registro1010 reg1010 in registros1010)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro 1010");
                dadosArquivoContmaticService.PersistirRegistro(reg1010);
            }



            IEnumerable<Registro1100> registros1100 =
                outrasInformacoesService.GetRegistros1100();
            foreach (Registro1100 reg1100 in registros1100)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro 1100");
                dadosArquivoContmaticService.PersistirRegistro(reg1100);
            }

            IEnumerable<Registro1200> registros1200 =
                outrasInformacoesService.GetRegistros1200();
            foreach (Registro1200 reg1200 in registros1200)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro 1200");
                dadosArquivoContmaticService.PersistirRegistro(reg1200);
            }


            IEnumerable<Registro1600> registros1600 =
                outrasInformacoesService.GetRegistros1600();
            foreach (Registro1600 reg1600 in registros1600)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro 1600");
                dadosArquivoContmaticService.PersistirRegistro(reg1600);

                //this.ProcessarParticipante(reg1600.COD_PART);
            }

            Registro1001 reg1001 = new Registro1001();
            if (dadosArquivoContmaticService.BlocoPossuiRegistros("E"))
                reg1001.IND_MOV = "0";
            else
                reg1001.IND_MOV = "1";
            dadosArquivoContmaticService.PersistirRegistro(reg1001);
            this.UpdateStatusAsynchronousExecution("Gerando Registro 1001");

            Registro1990 reg1990 = dadosArquivoContmaticService.GetRegistro1990();
            dadosArquivoContmaticService.PersistirRegistro(reg1990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro 1990");
        }

        private void ProcessarControlesEncerramento()
        {
            this.UpdateStatusAsynchronousExecution("Iniciando geração dos controles de encerramento");

            // Como pode ocorrer a inclusão de dados de Participantes, Produtos e Unidades
            // em outros blocos, a geração do registro 0990 deve ocorrer somente neste momento
            this.UpdateStatusAsynchronousExecution("Gerando Registro 0990");
            Registro0990 reg0990 = dadosArquivoContmaticService.GetRegistro0990();
            dadosArquivoContmaticService.PersistirRegistro(reg0990);

            //Registro9001 reg9001 = DadosArquivoFiscalService.GetRegistro9001();
            //DadosArquivoFiscalService.PersistirRegistro(reg9001);
            //this.UpdateStatusAsynchronousExecution("Gerando Registro 9001");

            //List<Registro9900> registros9900 = DadosArquivoFiscalService.GetRegistros9900().ToList();
            //foreach (Registro9900 reg9900 in registros9900)
            //{
            //    DadosArquivoFiscalService.PersistirRegistro(reg9900);
            //    this.UpdateStatusAsynchronousExecution("Gerando Registro 9900");
            //}

            //Registro9990 reg9990 = DadosArquivoFiscalService.GetRegistro9990();
            //DadosArquivoFiscalService.PersistirRegistro(reg9990);
            //this.UpdateStatusAsynchronousExecution("Gerando Registro 9990");

            //Registro9999 reg9999 = DadosArquivoFiscalService.GetRegistro9999();
            //DadosArquivoFiscalService.PersistirRegistro(reg9999);
            //this.UpdateStatusAsynchronousExecution("Gerando Registro 9999");
        }

        #endregion

        #region Métodos públicos
        public ContmaticProcessController(ContmaticProcessParameters parameters)
        {
            this._parameters = parameters;
            this.AsynchronousExecution +=
                new AsynchronousExecutionHandler(ContmaticProcessController_AsynchronousExecution);
            this.AsynchronousExecutionAborted +=
                new AsynchronousExecutionAbortedHandler(ContmaticProcessController_AsynchronousExecutionAborted);
        }
        #endregion


        #region Métodos protegidos
        protected override Ninject.Modules.NinjectModule GetInstanceDIControllersModule()
        {
            DIControllersModuleContmatic module = new DIControllersModuleContmatic();

            module.UnitOfWork.CodigoEmpresa = this._parameters.CodigoEmpresa;
            module.UnitOfWork.DataInicial = this._parameters.DataInicial;
            module.UnitOfWork.DataFinal = this._parameters.DataFinal;
            module.UnitOfWork.TipoArquivo = this._parameters.TipoArquivo;
            module.UnitOfWork.TipoRemessa = this._parameters.TipoRemessa;
            module.UnitOfWork.CaminhoArquivo = this._parameters.CaminhoArquivo;

            return module;
        }
        #endregion


        #region Outros métodos privados

        private void ProcessarGravacaoArquivo()
        {
            try
            {
                this.UpdateStatusAsynchronousExecution("Iniciando gravação do arquivo");

                SpedFileWriterService.Initialize(this._parameters.CaminhoArquivo);
                dadosArquivoContmaticService.OpenRegistros();
                while (dadosArquivoContmaticService.ReadRegistro())
                {
                    try
                    {


                        // ATENÇÃO: Não atualizar o status de execução do form que invocou este
                        // Controller, uma vez que a manipulação de arquivos tende a levar a estouros
                        // de memória neste caso. Logo, evitar chamadas ao método "UpdateStatusAsynchronousExecution"
                        // dentro deste loop.
                        SpedFileWriterService.WriteLine(
                            dadosArquivoContmaticService.GetConteudoRegistro());
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                dadosArquivoContmaticService.Finalizar();
                this.UpdateStatusAsynchronousExecution("Gravação em arquivo finalizada");
            }
            catch (Exception ex)
            {

            }
            finally
            {
                dadosArquivoContmaticService.CloseRegistros();
                SpedFileWriterService.Close();
            }
        }

        private void ContmaticProcessController_AsynchronousExecution()
        {
            this.ProcessarDadosGerais();
            this.ProcessarDocumentosFiscaisServico();
            this.ProcessarNotasFiscaisMercadorias();
            this.ProcessarCuponsFiscais();
            this.ProcessarConhecimentosTransporte();
            //this.ProcessarApuracaoIcmsIPI();
            //this.ProcessarControleCIAP();
            //this.ProcessarInventarioFisico();
            this.ProcessarOutrasInformacoes();
            this.ProcessarControlesEncerramento();
            this.ProcessarGravacaoArquivo();
        }

        private void ContmaticProcessController_AsynchronousExecutionAborted(Exception ex)
        {
            dadosArquivoContmaticService.RegistrarExcecao(ex);
        }

        #endregion

    }
}
