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
using Hlp.Sped.Domain.Models.Fiscal;
using Hlp.Sped.Controllers.IoC.Fiscal;
using Hlp.Sped.Controllers.Parameters.Fiscal;

namespace Hlp.Sped.Controllers.Fiscal
{
    public class FiscalProcessController : BaseController
    {
        [Inject]
        public IDadosGeraisService DadosGeraisService { get; set; }

        [Inject]
        public IDadosArquivoFiscalService DadosArquivoFiscalService { get; set; }

        [Inject]
        public INotasFiscaisMercadoriasService NotasFiscaisMercadoriasService { get; set; }

        [Inject]
        public ICuponsFiscaisService CuponsFiscaisService { get; set; }

        [Inject]
        public INotasFiscaisEnergiaAguaGasService NotasFiscaisEnergiaAguaGasService { get; set; }

        [Inject]
        public IConhecimentoTransporteService ConhecimentoTransporteService { get; set; }

        [Inject]
        public INotasFiscaisServComunicacaoService NotasFiscaisServComunicacaoService { get; set; }

        [Inject]
        public IApuracaoServices ApuracaoServices { get; set; }

        [Inject]
        public IInventarioService InventarioService { get; set; }

        [Inject]
        public IParticipantesService ParticipantesService { get; set; }

        [Inject]
        public IOutrasInformacoesService OutrasInformacoesService { get; set; }

        [Inject]
        public ISpedFileWriterService SpedFileWriterService { get; set; }

        [Inject]
        public IProdutosService ProdutosService { get; set; }

        [Inject]
        public IUnidadesService UnidadesService { get; set; }

        private FiscalProcessParameters _parameters;


        #region Métodos públicos

        public FiscalProcessController(FiscalProcessParameters parameters)
        {
            this._parameters = parameters;
            this.AsynchronousExecution +=
                new AsynchronousExecutionHandler(FiscalProcessController_AsynchronousExecution);
            this.AsynchronousExecutionAborted +=
                new AsynchronousExecutionAbortedHandler(FiscalProcessController_AsynchronousExecutionAborted);
        }

        #endregion


        #region Métodos protegidos

        protected override NinjectModule GetInstanceDIControllersModule()
        {
            DIContollersModuleFiscal module = new DIContollersModuleFiscal();

            module.UnitOfWork.CodigoEmpresa = this._parameters.CodigoEmpresa;
            module.UnitOfWork.DataInicial = this._parameters.DataInicial;
            module.UnitOfWork.DataFinal = this._parameters.DataFinal;
            module.UnitOfWork.TipoArquivo = this._parameters.TipoArquivo;
            module.UnitOfWork.TipoRemessa = this._parameters.TipoRemessa;
            module.UnitOfWork.CaminhoArquivo = this._parameters.CaminhoArquivo;

            return module;
        }

        #endregion


        #region Métodos privados - Processamento de Blocos

        private void ProcessarDadosGerais()
        {
            DadosArquivoFiscalService.Inicializar();

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0000");
            Registro0000 reg0000 = DadosGeraisService.GetRegistro0000();
            DadosArquivoFiscalService.PersistirRegistro(reg0000);

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0001");
            Registro0001 reg0001 = DadosGeraisService.GetRegistro0001();
            DadosArquivoFiscalService.PersistirRegistro(reg0001);

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0005");
            Registro0005 reg0005 = DadosGeraisService.GetRegistro0005();
            DadosArquivoFiscalService.PersistirRegistro(reg0005);

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0100");
            Registro0100 reg0100 = DadosGeraisService.GetRegistro0100();
            DadosArquivoFiscalService.PersistirRegistro(reg0100);

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0400");
            foreach (Registro0400 reg0400 in DadosGeraisService.GetRegistro0400())
            {
                DadosArquivoFiscalService.PersistirRegistro(reg0400);
            }

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0500");
            foreach (Registro0500 reg0500 in DadosGeraisService.GetRegistro0500())
            {
                DadosArquivoFiscalService.PersistirRegistro(reg0500);
            }
        }

        private void ProcessarDocumentosFiscaisMercadorias()
        {
            this.UpdateStatusAsynchronousExecution("Iniciando processamento de documentos fiscais");

            this.ProcessarNotasFiscaisMercadorias();
            this.ProcessarCuponsFiscais();
            this.ProcessarNotasFiscaisEnergiaAguaGas();

            // Monta o registro de abertura do bloco, verificando se realmente existem
            // movimentações para o período especificado
            this.UpdateStatusAsynchronousExecution("Gerando Registro C001");
            RegistroC001 regC001 = new RegistroC001();
            if (DadosArquivoFiscalService.BlocoPossuiRegistros("C"))
                regC001.IND_MOV = "0";
            else
                regC001.IND_MOV = "1";
            DadosArquivoFiscalService.PersistirRegistro(regC001);

            this.UpdateStatusAsynchronousExecution("Gerando Registro C990");
            RegistroC990 regC990 = DadosArquivoFiscalService.GetRegistroC990();
            DadosArquivoFiscalService.PersistirRegistro(regC990);
        }

        private void ProcessarNotasFiscaisMercadorias()
        {
            IEnumerable<RegistroC100> registrosC100 =
                NotasFiscaisMercadoriasService.GetRegistrosC100();
            foreach (RegistroC100 regC100 in registrosC100)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro C100");
                DadosArquivoFiscalService.PersistirRegistro(regC100);

                // Processa informações do cliente ou fornecedor vinculado a uma nota fiscal
                this.ProcessarParticipante(regC100.COD_PART);

                if (regC100.ST_DOC_CANCELADO != "S") // Não persiste registros filhos caso haja cancelamento
                    this.ProcessarDetalhesNotasFiscaisMercadorias(regC100);
            }
        }

        private void ProcessarDetalhesNotasFiscaisMercadorias(RegistroC100 regC100)
        {
            this.UpdateStatusAsynchronousExecution("Processando detalhes de documento fiscal");

            // Processsa informações dos itens da nota fiscal
            this.UpdateStatusAsynchronousExecution("Processando itens de documento fiscal");
            IEnumerable<RegistroC170> registrosC170 =
                NotasFiscaisMercadoriasService.GetRegistrosC170(regC100.PK_NOTAFIS);
            foreach (RegistroC170 regC170 in registrosC170)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro C170");
                DadosArquivoFiscalService.PersistirRegistro(regC170);

                this.ProcessarUnidade(regC170.UNID);
                this.ProcessarProduto(regC170.COD_ITEM);
            }

            // Processa informações de impostos agrupadas por Situação Tributária, CFOP e
            // Alíquota de ICMS
            this.UpdateStatusAsynchronousExecution("Processando impostos de documento fiscal");
            IEnumerable<RegistroC190> registrosC190 =
                NotasFiscaisMercadoriasService.GetRegistrosC190(regC100.PK_NOTAFIS);
            foreach (RegistroC190 regC190 in registrosC190)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro C190");
                DadosArquivoFiscalService.PersistirRegistro(regC190);
            }
        }

        private void ProcessarCuponsFiscais()
        {
            IEnumerable<RegistroC400> registrosC400 =
                CuponsFiscaisService.GetRegistrosC400();
            IEnumerable<RegistroC405> registrosC405;
            IEnumerable<RegistroC420> registrosC420;
            IEnumerable<RegistroC425> registrosC425;
            IEnumerable<RegistroC460> registrosC460;
            IEnumerable<RegistroC470> registrosC470;
            IEnumerable<RegistroC490> registrosC490;

            foreach (RegistroC400 regC400 in registrosC400)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro C400");
                DadosArquivoFiscalService.PersistirRegistro(regC400);

                registrosC405 = CuponsFiscaisService
                    .GetRegistrosC405(regC400.PK_ECF);
                RegistroC410 regC410;
                foreach (RegistroC405 regC405 in registrosC405)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro C405");
                    DadosArquivoFiscalService.PersistirRegistro(regC405);

                    regC410 = CuponsFiscaisService.GetRegistroC410(
                        regC400.PK_ECF, regC405.DT_DOC.Value);
                    if (regC410 != null)
                    {
                        this.UpdateStatusAsynchronousExecution("Gerando Registro C410");
                        DadosArquivoFiscalService.PersistirRegistro(regC410);
                    }

                    registrosC420 = CuponsFiscaisService.GetRegistrosC420(
                        regC400.PK_ECF, regC405.DT_DOC.Value);
                    foreach (RegistroC420 regC420 in registrosC420)
                    {
                        this.UpdateStatusAsynchronousExecution("Gerando Registro C420");
                        DadosArquivoFiscalService.PersistirRegistro(regC420);

                        // Processsa informações dos resumo de itens do movimento diário
                        this.UpdateStatusAsynchronousExecution("Processando resumo de itens do movimento diário");
                        registrosC425 = CuponsFiscaisService.GetRegistrosC425(
                            regC400.PK_ECF, regC405.DT_DOC.Value, regC420.COD_TOT_PAR);
                        foreach (RegistroC425 regC425 in registrosC425)
                        {
                            this.UpdateStatusAsynchronousExecution("Gerando Registro C425");
                            DadosArquivoFiscalService.PersistirRegistro(regC425);

                            this.ProcessarUnidade(regC425.UNID);
                            this.ProcessarProduto(regC425.COD_ITEM);
                        }
                    }

                    registrosC460 = CuponsFiscaisService.GetRegistrosC460(
                        regC400.PK_ECF, regC405.DT_DOC.Value);
                    foreach (RegistroC460 regC460 in registrosC460)
                    {
                        this.UpdateStatusAsynchronousExecution("Gerando Registro C460");
                        DadosArquivoFiscalService.PersistirRegistro(regC460);

                        // Processsa informações dos resumo de itens do movimento diário
                        this.UpdateStatusAsynchronousExecution("Processando itens de Cupom Fiscal");
                        registrosC470 = CuponsFiscaisService.GetRegistrosC470(regC460.PK_CUPOMFIS);
                        foreach (RegistroC470 regC470 in registrosC470)
                        {
                            this.UpdateStatusAsynchronousExecution("Gerando Registro C470");
                            DadosArquivoFiscalService.PersistirRegistro(regC470);

                            this.ProcessarUnidade(regC470.UNID);
                            this.ProcessarProduto(regC470.COD_ITEM);
                        }
                    }

                    registrosC490 = CuponsFiscaisService.GetRegistrosC490(
                        regC400.PK_ECF, regC405.DT_DOC.Value);
                    foreach (RegistroC490 regC490 in registrosC490)
                    {
                        this.UpdateStatusAsynchronousExecution("Gerando Registro C490");
                        DadosArquivoFiscalService.PersistirRegistro(regC490);
                    }
                }
            }
        }

        private void ProcessarNotasFiscaisEnergiaAguaGas()
        {
            IEnumerable<RegistroC590> registrosC590;
            IEnumerable<RegistroC510> registrosC510;

            IEnumerable<RegistroC500> registrosC500 =
                NotasFiscaisEnergiaAguaGasService.GetRegistrosC500();
            foreach (RegistroC500 regC500 in registrosC500)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro C500");
                DadosArquivoFiscalService.PersistirRegistro(regC500);

                // Processa informações do cliente ou fornecedor vinculado a uma nota fiscal
                this.ProcessarParticipante(regC500.COD_PART);

                if (regC500.ST_DOC_CANCELADO != "S") // Não persiste registros filhos caso haja cancelamento
                {
                    registrosC510 = NotasFiscaisEnergiaAguaGasService.GetRegistrosC510(
                        regC500.PK_NOTAFIS);
                    foreach (RegistroC510 regC510 in registrosC510)
                    {
                        this.UpdateStatusAsynchronousExecution("Gerando Registro C510");
                        DadosArquivoFiscalService.PersistirRegistro(regC510);

                        this.ProcessarUnidade(regC510.UNID);
                        this.ProcessarProduto(regC510.COD_ITEM);
                        this.ProcessarParticipante(regC510.COD_PART);
                    }

                    registrosC590 = NotasFiscaisEnergiaAguaGasService.GetRegistrosC590(
                        regC500.PK_NOTAFIS);
                    foreach (RegistroC590 regC590 in registrosC590)
                    {
                        DadosArquivoFiscalService.PersistirRegistro(regC590);
                        this.UpdateStatusAsynchronousExecution("Gerando Registro C590");
                    }
                }
            }
        }

        private void ProcessarParticipante(string codigoParticipante)
        {
            if (String.IsNullOrWhiteSpace(codigoParticipante))
                return;

            if (!DadosArquivoFiscalService.RegistroJaExistente("0150", codigoParticipante))
            {
                // Caso o cliente ou fornecedor ainda não tenha sido processado,
                // persiste o mesmo para posterior geração do arquivo
                this.UpdateStatusAsynchronousExecution("Gerando Registro 0150");
                Registro0150 reg0150 = ParticipantesService.GetRegistro0150(codigoParticipante);
                if (reg0150 != null)
                    DadosArquivoFiscalService.PersistirRegistro(reg0150);
            }
        }

        private void ProcessarUnidade(string codigoUnidade)
        {
            if (String.IsNullOrWhiteSpace(codigoUnidade))
                return;

            if (!DadosArquivoFiscalService.RegistroJaExistente("0190", codigoUnidade))
            {
                // Apenas persiste uma unidade se a mesma ainda não tiver sido processada
                this.UpdateStatusAsynchronousExecution("Gerando Registro 0190");
                Registro0190 reg0190 = UnidadesService.GetRegistro0190(codigoUnidade);
                if (reg0190 != null)
                    DadosArquivoFiscalService.PersistirRegistro(reg0190);
            }
        }

        private void ProcessarProduto(string codigoProduto)
        {
            if (String.IsNullOrWhiteSpace(codigoProduto))
                return;

            IEnumerable<Registro0220> lreg220;
            if (!DadosArquivoFiscalService.RegistroJaExistente("0200", codigoProduto))
            {
                // Apenas persiste uma unidade se a mesma ainda não tiver sido processada
                this.UpdateStatusAsynchronousExecution("Gerando Registro 0200");
                Registro0200 reg0200 = ProdutosService.GetRegistro0200(codigoProduto);
                if (reg0200 != null)
                {
                    DadosArquivoFiscalService.PersistirRegistro(reg0200);
                    this.ProcessarUnidade(reg0200.UNID_INV);

                    lreg220 = ProdutosService.GetRegistros0220(reg0200.COD_ITEM);
                    foreach (Registro0220 item in lreg220)
                    {
                        this.UpdateStatusAsynchronousExecution("Gerando Registros 0220");
                        //item.FAT_CONV
                        if (!DadosArquivoFiscalService.RegistroJaExistente("0190",item.UNID_CONV))
                        {
                            // Apenas persiste uma unidade se a mesma ainda não tiver sido processada
                            this.UpdateStatusAsynchronousExecution("Gerando Registro 0190");
                            Registro0190 reg0190 = UnidadesService.GetRegistro0190(item.UNID_CONV);
                            if (reg0190 != null)
                                DadosArquivoFiscalService.PersistirRegistro(reg0190);
                        }
                        DadosArquivoFiscalService.PersistirRegistro(item);
                    }
                }
            }
        }

        private void ProcessarMovimentacoesTransporteComunicacao()
        {
            this.UpdateStatusAsynchronousExecution("Iniciando processamento de movimentações de transporte e comunicação");

            this.ProcessarConhecimentosTransporte();
            this.ProcessarNotasFiscaisServicosComunicacao();

            RegistroD001 regD001 = new RegistroD001();
            if (DadosArquivoFiscalService.BlocoPossuiRegistros("D"))
                regD001.IND_MOV = "0";
            else
                regD001.IND_MOV = "1";

            DadosArquivoFiscalService.PersistirRegistro(regD001);
            this.UpdateStatusAsynchronousExecution("Gerando Registro D001");

            RegistroD990 regD990 = DadosArquivoFiscalService.GetRegistroD990();
            DadosArquivoFiscalService.PersistirRegistro(regD990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro D990");
        }

        private void ProcessarConhecimentosTransporte()
        {
            IEnumerable<RegistroD110> registrosD110;
            IEnumerable<RegistroD120> registrosD120;
            IEnumerable<RegistroD130> registrosD130;
            IEnumerable<RegistroD190> registrosD190;

            IEnumerable<RegistroD100> registrosD100 =
                ConhecimentoTransporteService.GetRegistrosD100();
            foreach (RegistroD100 regD100 in registrosD100)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro D100");
                DadosArquivoFiscalService.PersistirRegistro(regD100);

                // Processa informações do cliente ou fornecedor vinculado a uma nota fiscal
                this.ProcessarParticipante(regD100.COD_PART);

                if (regD100.ST_DOC_CANCELADO != "S") // Não persiste registros filhos caso haja cancelamento
                {
                    registrosD110 = ConhecimentoTransporteService.GetRegistrosD110(
                        regD100.PK_NOTAFIS);
                    foreach (RegistroD110 regD110 in registrosD110)
                    {
                        DadosArquivoFiscalService.PersistirRegistro(regD110);
                        this.UpdateStatusAsynchronousExecution("Gerando Registro D110");
                    }

                    registrosD120 = ConhecimentoTransporteService.GetRegistrosD120(
                        regD100.PK_NOTAFIS);
                    foreach (RegistroD120 regD120 in registrosD120)
                    {
                        DadosArquivoFiscalService.PersistirRegistro(regD120);
                        this.UpdateStatusAsynchronousExecution("Gerando Registro D120");
                    }

                    registrosD130 = ConhecimentoTransporteService.GetRegistrosD130(
                        regD100.PK_NOTAFIS);
                    foreach (RegistroD130 regD130 in registrosD130)
                    {
                        DadosArquivoFiscalService.PersistirRegistro(regD130);
                        this.UpdateStatusAsynchronousExecution("Gerando Registro D130");

                        // Gravação de informações de Participantes
                        this.ProcessarParticipante(regD130.COD_PART_CONSG);
                        this.ProcessarParticipante(regD130.COD_PART_RED);
                    }

                    registrosD190 = ConhecimentoTransporteService.GetRegistrosD190(
                        regD100.PK_NOTAFIS);
                    foreach (RegistroD190 regD190 in registrosD190)
                    {
                        DadosArquivoFiscalService.PersistirRegistro(regD190);
                        this.UpdateStatusAsynchronousExecution("Gerando Registro D190");
                    }
                }
            }
        }

        private void ProcessarNotasFiscaisServicosComunicacao()
        {
            IEnumerable<RegistroD590> registrosD590;

            IEnumerable<RegistroD500> registrosD500 =
                NotasFiscaisServComunicacaoService.GetRegistrosD500();
            foreach (RegistroD500 regD500 in registrosD500)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro D500");
                DadosArquivoFiscalService.PersistirRegistro(regD500);

                // Processa informações do cliente ou fornecedor vinculado a uma nota fiscal
                this.ProcessarParticipante(regD500.COD_PART);

                if (regD500.ST_DOC_CANCELADO != "S") // Não persiste registros filhos caso haja cancelamento
                {
                    registrosD590 = NotasFiscaisServComunicacaoService.GetRegistrosD590(
                        regD500.PK_NOTAFIS);
                    foreach (RegistroD590 regD590 in registrosD590)
                    {
                        DadosArquivoFiscalService.PersistirRegistro(regD590);
                        this.UpdateStatusAsynchronousExecution("Gerando Registro D590");
                    }
                }
            }
        }

        private void ProcessarApuracaoIcmsIPI()
        {
            // Nesta primeira versão isto ainda não será implementado; levantar posteriormente
            // se isto realmente é necessário
            this.UpdateStatusAsynchronousExecution("Iniciando processamento de apuração do ICMS e IPI");

            IEnumerable<RegistroE100> registrosE100;
            registrosE100 = ApuracaoServices.GetRegistrosE100();
            RegistroE110 registroE110;
            IEnumerable<RegistroE111> registrosE111;
            IEnumerable<RegistroE116> registrosE116;
            foreach (RegistroE100 regE100 in registrosE100)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro E100");
                DadosArquivoFiscalService.PersistirRegistro(regE100);
                registroE110 = ApuracaoServices.GetRegistroE110(regE100.DT_INI.Value, regE100.DT_FIN.Value);
                DadosArquivoFiscalService.PersistirRegistro(registroE110);

                registrosE111 = ApuracaoServices.GetRegistrosE111(regE100.DT_INI.Value, regE100.DT_FIN.Value);

                foreach (RegistroE111 reg111 in registrosE111)
                {
                    DadosArquivoFiscalService.PersistirRegistro(reg111);
                    this.UpdateStatusAsynchronousExecution("Gerando Registro E110");
                }

                registrosE116 = ApuracaoServices.GetRegistrosE116(regE100.DT_INI.Value, regE100.DT_FIN.Value);
                foreach (RegistroE116 reg116 in registrosE116)
                {
                    DadosArquivoFiscalService.PersistirRegistro(reg116);
                    this.UpdateStatusAsynchronousExecution("Gerando Registro E116");
                }
            }

            IEnumerable<RegistroE500> registrosE500;
            registrosE500 = ApuracaoServices.GetRegistrosE500();

            IEnumerable<RegistroE510> registrosE510;
            RegistroE520 regE520;
            IEnumerable<RegistroE530> registrosE530;

            foreach (RegistroE500 regE500 in registrosE500)
            {
                DadosArquivoFiscalService.PersistirRegistro(regE500);
                this.UpdateStatusAsynchronousExecution("Gerando Registro E500");

                registrosE510 = ApuracaoServices.GetRegistrosE510(
                    regE500.DT_INI.Value, regE500.DT_FIN.Value);
                foreach (RegistroE510 regE510 in registrosE510)
                {
                    DadosArquivoFiscalService.PersistirRegistro(regE510);
                    this.UpdateStatusAsynchronousExecution("Gerando Registro E510");
                }

                regE520 = ApuracaoServices.GetRegistroE520(
                    regE500.DT_INI.Value, regE500.DT_FIN.Value);
                DadosArquivoFiscalService.PersistirRegistro(regE520);
                this.UpdateStatusAsynchronousExecution("Gerando Registro E520");

                //registrosE530 = ApuracaoServices.GetRegistrosE530(
                //    regE500.DT_INI.Value, regE500.DT_FIN.Value);
                //foreach (RegistroE530 regE530 in registrosE530)
                //{
                //    DadosArquivoFiscalService.PersistirRegistro(regE530);
                //    this.UpdateStatusAsynchronousExecution("Gerando Registro E530");
                //}
            }

            RegistroE001 regE001 = new RegistroE001();
            if (DadosArquivoFiscalService.BlocoPossuiRegistros("E"))
                regE001.IND_MOV = "0";
            else
                regE001.IND_MOV = "1";
            DadosArquivoFiscalService.PersistirRegistro(regE001);
            this.UpdateStatusAsynchronousExecution("Gerando Registro E001");

            RegistroE990 regE990 = DadosArquivoFiscalService.GetRegistroE990();
            DadosArquivoFiscalService.PersistirRegistro(regE990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro E990");
        }

        private void ProcessarControleCIAP()
        {
            // Nesta primeira versão isto ainda não será implementado; levantar posteriormente
            // se isto realmente é necessário
            this.UpdateStatusAsynchronousExecution("Iniciando processamento de movimentações de transporte e comunicação");

            RegistroG001 regG001 = new RegistroG001();
            regG001.IND_MOV = "1"; // Nesta primeira versão este bloco não será informado
            DadosArquivoFiscalService.PersistirRegistro(regG001);
            this.UpdateStatusAsynchronousExecution("Gerando Registro G001");

            RegistroG990 regG990 = DadosArquivoFiscalService.GetRegistroG990();
            DadosArquivoFiscalService.PersistirRegistro(regG990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro G990");
        }

        private void ProcessarInventarioFisico()
        {
            // Nesta primeira versão isto ainda não será implementado; levantar posteriormente
            // se isto realmente é necessário
            this.UpdateStatusAsynchronousExecution("Iniciando processamento de movimentações de transporte e comunicação");

            IEnumerable<RegistroH005> registrosH005 =
                InventarioService.GetRegistrosH005();
            foreach (RegistroH005 regH005 in registrosH005)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro H005");
                DadosArquivoFiscalService.PersistirRegistro(regH005);

                // Processsa informações dos itens da nota fiscal
                this.UpdateStatusAsynchronousExecution("Processando itens de documento fiscal");
                IEnumerable<RegistroH010> registrosH010 =
                    InventarioService.GetRegistrosH010(regH005.DT_INV.Value);
                foreach (RegistroH010 regH010 in registrosH010)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro H010");
                    DadosArquivoFiscalService.PersistirRegistro(regH010);

                    this.ProcessarUnidade(regH010.UNID);
                    this.ProcessarProduto(regH010.COD_ITEM);
                    this.ProcessarParticipante(regH010.COD_PART);
                }
            }

            // Monta o registro de abertura do bloco, verificando se realmente existem
            // movimentações para o período especificado
            this.UpdateStatusAsynchronousExecution("Gerando Registro H001");
            RegistroH001 regH001 = new RegistroH001();
            if (DadosArquivoFiscalService.BlocoPossuiRegistros("H"))
                regH001.IND_MOV = "0";
            else
                regH001.IND_MOV = "1";
            DadosArquivoFiscalService.PersistirRegistro(regH001);

            RegistroH990 regH990 = DadosArquivoFiscalService.GetRegistroH990();
            DadosArquivoFiscalService.PersistirRegistro(regH990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro H990");
        }

        private void ProcessarOutrasInformacoes()
        {
            // Nesta primeira versão isto ainda não será implementado; levantar posteriormente
            // se isto realmente é necessário
            this.UpdateStatusAsynchronousExecution("Iniciando processamento de outras informações");

            this.UpdateStatusAsynchronousExecution("Gerando Registro 1010");
            Registro1010 reg1010 = OutrasInformacoesService.GetRegistro1010();
            DadosArquivoFiscalService.PersistirRegistro(reg1010);

            IEnumerable<Registro1105> registros1105;
            IEnumerable<Registro1110> registros1110;
            IEnumerable<Registro1100> registros1100 =
                OutrasInformacoesService.GetRegistros1100();
            foreach (Registro1100 reg1100 in registros1100)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro 1100");
                DadosArquivoFiscalService.PersistirRegistro(reg1100);

                registros1105 = OutrasInformacoesService.GetRegistros1105(
                    reg1100.NRO_DE);
                foreach (Registro1105 reg1105 in registros1105)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro 1105");
                    DadosArquivoFiscalService.PersistirRegistro(reg1105);

                    this.ProcessarProduto(reg1105.COD_ITEM);

                    registros1110 = OutrasInformacoesService.GetRegistros1110(
                        reg1105.PK_NOTAFIS);
                    foreach (Registro1110 reg1110 in registros1110)
                    {
                        this.UpdateStatusAsynchronousExecution("Gerando Registro 1110");
                        DadosArquivoFiscalService.PersistirRegistro(reg1110);

                        this.ProcessarParticipante(reg1110.COD_PART);
                        this.ProcessarUnidade(reg1110.UNID);
                    }
                }
            }

            IEnumerable<Registro1210> registros1210;
            IEnumerable<Registro1200> registros1200 =
                OutrasInformacoesService.GetRegistros1200();
            foreach (Registro1200 reg1200 in registros1200)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro 1200");
                DadosArquivoFiscalService.PersistirRegistro(reg1200);

                registros1210 = OutrasInformacoesService.GetRegistros1210(
                    reg1200.COD_AJ_APUR);
                foreach (Registro1210 reg1210 in registros1210)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro 1210");
                    DadosArquivoFiscalService.PersistirRegistro(reg1210);
                }
            }

            IEnumerable<Registro1400> registros1400 =
                OutrasInformacoesService.GetRegistros1400();
            foreach (Registro1400 reg1400 in registros1400)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro 1400");
                DadosArquivoFiscalService.PersistirRegistro(reg1400);

                this.ProcessarProduto(reg1400.COD_ITEM);
            }

            IEnumerable<Registro1600> registros1600 =
                OutrasInformacoesService.GetRegistros1600();
            foreach (Registro1600 reg1600 in registros1600)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro 1600");
                DadosArquivoFiscalService.PersistirRegistro(reg1600);

                this.ProcessarParticipante(reg1600.COD_PART);
            }

            IEnumerable<Registro1710> registros1710;
            IEnumerable<Registro1700> registros1700 =
                OutrasInformacoesService.GetRegistros1700();
            foreach (Registro1700 reg1700 in registros1700)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro 1700");
                DadosArquivoFiscalService.PersistirRegistro(reg1700);

                registros1710 = OutrasInformacoesService.GetRegistros1710(
                    reg1700.COD_DISP, reg1700.COD_MOD, reg1700.SER, reg1700.SUB);
                foreach (Registro1710 reg1710 in registros1710)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro 1710");
                    DadosArquivoFiscalService.PersistirRegistro(reg1710);
                }
            }

            Registro1001 reg1001 = new Registro1001();
            if (DadosArquivoFiscalService.BlocoPossuiRegistros("E"))
                reg1001.IND_MOV = "0";
            else
                reg1001.IND_MOV = "1";
            DadosArquivoFiscalService.PersistirRegistro(reg1001);
            this.UpdateStatusAsynchronousExecution("Gerando Registro 1001");

            Registro1990 reg1990 = DadosArquivoFiscalService.GetRegistro1990();
            DadosArquivoFiscalService.PersistirRegistro(reg1990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro 1990");
        }

        private void ProcessarControlesEncerramento()
        {
            this.UpdateStatusAsynchronousExecution("Iniciando geração dos controles de encerramento");

            // Como pode ocorrer a inclusão de dados de Participantes, Produtos e Unidades
            // em outros blocos, a geração do registro 0990 deve ocorrer somente neste momento
            this.UpdateStatusAsynchronousExecution("Gerando Registro 0990");
            Registro0990 reg0990 = DadosArquivoFiscalService.GetRegistro0990();
            DadosArquivoFiscalService.PersistirRegistro(reg0990);

            Registro9001 reg9001 = DadosArquivoFiscalService.GetRegistro9001();
            DadosArquivoFiscalService.PersistirRegistro(reg9001);
            this.UpdateStatusAsynchronousExecution("Gerando Registro 9001");

            List<Registro9900> registros9900 = DadosArquivoFiscalService.GetRegistros9900().ToList();
            foreach (Registro9900 reg9900 in registros9900)
            {
                DadosArquivoFiscalService.PersistirRegistro(reg9900);
                this.UpdateStatusAsynchronousExecution("Gerando Registro 9900");
            }

            Registro9990 reg9990 = DadosArquivoFiscalService.GetRegistro9990();
            DadosArquivoFiscalService.PersistirRegistro(reg9990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro 9990");

            Registro9999 reg9999 = DadosArquivoFiscalService.GetRegistro9999();
            DadosArquivoFiscalService.PersistirRegistro(reg9999);
            this.UpdateStatusAsynchronousExecution("Gerando Registro 9999");
        }

        #endregion


        #region Outros métodos privados

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

        private void FiscalProcessController_AsynchronousExecution()
        {
            this.ProcessarDadosGerais();
            this.ProcessarDocumentosFiscaisMercadorias();
            this.ProcessarMovimentacoesTransporteComunicacao();
            this.ProcessarApuracaoIcmsIPI();
            this.ProcessarControleCIAP();
            this.ProcessarInventarioFisico();
            this.ProcessarOutrasInformacoes();
            this.ProcessarControlesEncerramento();
            this.ProcessarGravacaoArquivo();
        }

        private void FiscalProcessController_AsynchronousExecutionAborted(Exception ex)
        {
            DadosArquivoFiscalService.RegistrarExcecao(ex);
        }

        #endregion
    }
}