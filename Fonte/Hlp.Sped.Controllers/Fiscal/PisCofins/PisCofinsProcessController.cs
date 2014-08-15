﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Ninject.Modules;
using Hlp.Sped.Infrastructure.Controllers;
using Hlp.Sped.Infrastructure.Files;
using Hlp.Sped.Services.Interfaces.PisCofins;
using Hlp.Sped.Services.Interfaces.Files;
using Hlp.Sped.Domain.Models.PisCofins;
using Hlp.Sped.Controllers.IoC.PisCofins;
using Hlp.Sped.Controllers.Parameters.PisCofins;
using Hlp.Sped.Infrastructure;

namespace Hlp.Sped.Controllers.Fiscal.PisCofins
{
    public class PisCofinsProcessController : BaseController
    {
        private List<validacao> produtos;
        private List<validacao> unidades;
        private List<validacao> contribuintes;


        private struct validacao
        {
            public string codEmp { get; set; }
            public object registro { get; set; }
        }

        [Inject]
        public IDadosGeraisService DadosGeraisService { get; set; }

        //[Inject]
        //public Hlp.Sped.Services.Interfaces.Fiscal.IDadosGeraisService DadosGeraisServiceFiscal { get; set; }

        [Inject]
        public IDemaisDocumentosOperacoesService demaisDocOperacoes { get; set; }

        [Inject]
        public IParticipantesService ParticipantesService { get; set; }

        [Inject]
        public IUnidadesService UnidadesService { get; set; }

        [Inject]
        public IProdutosService ProdutosService { get; set; }

        [Inject]
        public IDocumentosFiscaisMercadoriasService DocumentosFiscaisMercadoriasService { get; set; }

        [Inject]
        public INotasFiscaisServicoService NotasFiscaisServicoService { get; set; }

        [Inject]
        public IConsolidacaoNotasFiscaisService ConsolidacaoNotasFiscaisService { get; set; }

        [Inject]
        public ICuponsFiscaisService CuponsFiscaisService { get; set; }

        [Inject]
        public INotasFiscaisEnergiaAguaGasService NotasFiscaisEnergiaAguaGasService { get; set; }

        [Inject]
        public INotasFiscaisMercadoriasService NotasFiscaisMercadoriasService { get; set; }

        [Inject]
        public IDadosArquivoPisCofinsService DadosArquivoPisCofinsService { get; set; }

        [Inject]
        public ISpedFileWriterService SpedFileWriterService { get; set; }

        [Inject]
        public INotasFiscaisServComunicacaoService NotaFiscaisServService { get; set; }

        private PisCofinsProcessParameters _parameters;

        [Inject]
        public UnitOfWorkBase UndTrabalho { get; set; }


        #region Métodos públicos

        public PisCofinsProcessController(PisCofinsProcessParameters parameters)
        {
            this._parameters = parameters;
            this.AsynchronousExecution +=
                new AsynchronousExecutionHandler(PisCofinsProcessController_AsynchronousExecution);
            this.AsynchronousExecutionAborted +=
                new AsynchronousExecutionAbortedHandler(PisCofinsProcessController_AsynchronousExecutionAborted);
        }

        #endregion


        #region Métodos protegidos

        protected override NinjectModule GetInstanceDIControllersModule()
        {
            DIContollersModulePisCofins module = new DIContollersModulePisCofins();

            module.UnitOfWork.CodigoEmpresa = this._parameters.CodigoEmpresa;
            module.UnitOfWork.DataInicial = this._parameters.DataInicial;
            module.UnitOfWork.DataFinal = this._parameters.DataFinal;
            module.UnitOfWork.TipoArquivo = this._parameters.TipoArquivo;
            module.UnitOfWork.TipoRemessa = this._parameters.TipoRemessa;
            module.UnitOfWork.CaminhoArquivo = this._parameters.CaminhoArquivo;
            module.UnitOfWork.NumeroReciboAnterior = this._parameters.NumeroReciboAnterior;

            return module;
        }

        #endregion


        #region Métodos privados - Processamento de Blocos

        private void ProcessarDadosGerais()
        {
            DadosArquivoPisCofinsService.Inicializar();

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0000");
            Registro0000 reg0000 = DadosGeraisService.GetRegistro0000();
            DadosArquivoPisCofinsService.PersistirRegistro(reg0000);

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0001");
            Registro0001 reg0001 = DadosGeraisService.GetRegistro0001();
            DadosArquivoPisCofinsService.PersistirRegistro(reg0001);

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0100");
            Registro0100 reg0100 = DadosGeraisService.GetRegistro0100();
            DadosArquivoPisCofinsService.PersistirRegistro(reg0100);

            this.UpdateStatusAsynchronousExecution("Gerando Registro 0110");
            Registro0110 reg0110 = DadosGeraisService.GetRegistro0110();
            DadosArquivoPisCofinsService.PersistirRegistro(reg0110);

        }




        private void ProcessarDadosGeraisPorEmpresa()
        {
            this.UpdateStatusAsynchronousExecution("Gerando Registro 0140");
            // GetEmpresasFiliais(UndTrabalho.CodigoEmpresa);
            List<Registro0140> lreg0140 = DadosGeraisService.GetRegistro0140(UndTrabalho.CodigoEmpresa).ToList(); // Verificar
            foreach (Registro0140 reg0140 in lreg0140)
            {
                DadosArquivoPisCofinsService.PersistirRegistro(reg0140);

                foreach (validacao validaProd in contribuintes.Where(c => c.codEmp == reg0140.COD_EST))
                {
                    Registro0150 reg0150 = validaProd.registro as Registro0150;

                    this.UpdateStatusAsynchronousExecution("Gerando Registro 0150");
                    DadosArquivoPisCofinsService.PersistirRegistro(reg0150);
                }

                foreach (validacao validaUM in unidades.Where(c => c.codEmp == reg0140.COD_EST))
                {
                    Registro0190 reg0190 = validaUM.registro as Registro0190;

                    this.UpdateStatusAsynchronousExecution("Gerando Registro 0190");
                    DadosArquivoPisCofinsService.PersistirRegistro(reg0190);
                }

                foreach (validacao validaProd in produtos.Where(c => c.codEmp == reg0140.COD_EST))
                {
                    Registro0200 reg0200 = validaProd.registro as Registro0200;

                    this.UpdateStatusAsynchronousExecution("Gerando Registro 0200");
                    DadosArquivoPisCofinsService.PersistirRegistro(reg0200);
                }


                this.UpdateStatusAsynchronousExecution("Gerando Registro 0400");
                foreach (Registro0400 reg0400 in DadosGeraisService.GetRegistro0400(reg0140.COD_EST))
                {
                    DadosArquivoPisCofinsService.PersistirRegistro(reg0400);
                }
                this.UpdateStatusAsynchronousExecution("Gerando Registro 0500");
                foreach (Registro0500 reg0500 in DadosGeraisService.GetRegistro0500(reg0140.COD_EST))
                {
                    DadosArquivoPisCofinsService.PersistirRegistro(reg0500);
                }
            }
        }

        private void ProcessarDocumentosFiscaisServico()
        {
            IEnumerable<RegistroA010> registrosA010 =
                NotasFiscaisServicoService.GetRegistrosA010();
            IEnumerable<RegistroA100> registrosA100;

            foreach (RegistroA010 regA010 in registrosA010)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro A010");
                DadosArquivoPisCofinsService.PersistirRegistro(regA010);

                registrosA100 = NotasFiscaisServicoService.GetRegistrosA100(
                    regA010.CNPJ, regA010.CD_EMP);
                foreach (RegistroA100 regA100 in registrosA100)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro A100");
                    DadosArquivoPisCofinsService.PersistirRegistro(regA100);

                    // Processa informações do cliente ou fornecedor vinculado a uma nota fiscal
                    this.ProcessarParticipante(regA100.COD_PART, regA010.CD_EMP);

                    if (regA100.ST_DOC_CANCELADO != "S") // Não persiste registros filhos caso haja cancelamento
                        this.ProcessarDetalhesDocumentosFiscaisServico(regA100, regA010.CD_EMP);
                }
            }

            // Monta o registro de abertura do bloco, verificando se realmente existem
            // movimentações para o período especificado
            this.UpdateStatusAsynchronousExecution("Gerando Registro A001");
            RegistroA001 regA001 = new RegistroA001();
            if (DadosArquivoPisCofinsService.BlocoPossuiRegistros("A"))
                regA001.IND_MOV = "0";
            else
                regA001.IND_MOV = "1";
            DadosArquivoPisCofinsService.PersistirRegistro(regA001);

            RegistroA990 regA990 = DadosArquivoPisCofinsService.GetRegistroA990();
            DadosArquivoPisCofinsService.PersistirRegistro(regA990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro A990");
        }

        private void ProcessarDetalhesDocumentosFiscaisServico(RegistroA100 regA100, string codEmp)
        {
            this.UpdateStatusAsynchronousExecution("Processando detalhes de documento fiscal");

            // Processsa informações dos itens da nota fiscal
            this.UpdateStatusAsynchronousExecution("Processando itens de documento fiscal");
            IEnumerable<RegistroA170> registrosA170 =
                NotasFiscaisServicoService.GetRegistrosA170(regA100.PK_NOTAFIS, codEmp);
            foreach (RegistroA170 regA170 in registrosA170)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro A170");
                DadosArquivoPisCofinsService.PersistirRegistro(regA170);

                this.ProcessarProduto(regA170.COD_ITEM, codEmp);
            }
        }
        private void ProcessarConhecimentosTransporte(RegistroD010 regD010)
        {

        }

        private void ProcessarNotasFiscaisServicosComunicacao()
        {

            IEnumerable<RegistroD501> registrosD501;
            IEnumerable<RegistroD505> registrosD505;

            IEnumerable<RegistroD010> registrosD010 = NotaFiscaisServService.GetRegistrosD010();

            foreach (RegistroD010 regD010 in registrosD010)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro D010");
                DadosArquivoPisCofinsService.PersistirRegistro(regD010);

                //this.ProcessarConhecimentosTransporte(regD010);

                IEnumerable<RegistroD101> registrosD101;
                IEnumerable<RegistroD105> registrosD105;

                IEnumerable<RegistroD100> registrosD100 =
                    NotaFiscaisServService.GetRegistrosD100(regD010.CD_EMP);
                foreach (RegistroD100 regD100 in registrosD100)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro D100");
                    DadosArquivoPisCofinsService.PersistirRegistro(regD100);
                    // Processa informações do cliente ou fornecedor vinculado a uma nota fiscal
                    this.ProcessarParticipante(regD100.COD_PART, regD010.CD_EMP);

                    registrosD101 = NotaFiscaisServService.GetRegistrosD101(regD100.PK_NOTAFIS, regD010.CD_EMP);
                    foreach (RegistroD101 reg101 in registrosD101)
                    {
                        DadosArquivoPisCofinsService.PersistirRegistro(reg101);
                    }

                    registrosD105 = NotaFiscaisServService.GetRegistrosD105(regD100.PK_NOTAFIS, regD010.CD_EMP);
                    foreach (RegistroD105 regD105 in registrosD105)
                    {
                        DadosArquivoPisCofinsService.PersistirRegistro(regD105);
                    }
                }

                IEnumerable<RegistroD200> registrosD200 = NotaFiscaisServService.GetRegistrosD200(regD010.CD_EMP);
                IEnumerable<RegistroD201> registrosD201;
                IEnumerable<RegistroD205> registrosD205;

                foreach (RegistroD200 regD200 in registrosD200)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro D200");
                    DadosArquivoPisCofinsService.PersistirRegistro(regD200);

                    registrosD201 = NotaFiscaisServService.GetRegistrosD201(regD200.PK_NOTAFIS, regD010.CD_EMP);

                    foreach (RegistroD201 regD201 in registrosD201)
                    {
                        this.UpdateStatusAsynchronousExecution("Gerando Registro D201");
                        DadosArquivoPisCofinsService.PersistirRegistro(regD201);
                    }

                    registrosD205 = NotaFiscaisServService.GetRegistrosD205(regD200.PK_NOTAFIS, regD010.CD_EMP);

                    foreach (RegistroD205 regD205 in registrosD205)
                    {
                        this.UpdateStatusAsynchronousExecution("Gerando Registro D205");
                        DadosArquivoPisCofinsService.PersistirRegistro(regD205);
                    }
                }

                IEnumerable<RegistroD500> registrosD500 =
                    NotaFiscaisServService.GetRegistrosD500(regD010.CNPJ, regD010.CD_EMP);

                foreach (RegistroD500 regD500 in registrosD500)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro D500");
                    DadosArquivoPisCofinsService.PersistirRegistro(regD500);

                    // Processa informações do cliente ou fornecedor vinculado a uma nota fiscal
                    this.ProcessarParticipante(regD500.COD_PART, regD010.CD_EMP);

                    if (regD500.ST_DOC_CANCELADO != "S") // Não persiste registros filhos caso haja cancelamento
                    {
                        registrosD501 = NotaFiscaisServService.GetRegistrosD501(
                            regD500.PK_NOTAFIS, regD010.CD_EMP);
                        foreach (RegistroD501 regD501 in registrosD501)
                        {
                            DadosArquivoPisCofinsService.PersistirRegistro(regD501);
                            this.UpdateStatusAsynchronousExecution("Gerando Registro D501");
                        }
                        registrosD505 = NotaFiscaisServService.GetRegistrosD505(regD500.PK_NOTAFIS, regD010.CD_EMP);
                        foreach (RegistroD505 reg505 in registrosD505)
                        {
                            DadosArquivoPisCofinsService.PersistirRegistro(reg505);
                            this.UpdateStatusAsynchronousExecution("Gerando Registro D505");
                        }
                    }
                }

            }
        }

        private void GetEmpresasFiliais(string sEmp)
        {
            try
            {
                IEnumerable<RegistroC010> lreg = DocumentosFiscaisMercadoriasService.GetRegistrosC010(sEmp).ToList();
                if (lreg.Count() > 0)
                {
                    registrosC010.Add(lreg.FirstOrDefault());

                    string codEmpFilial = DadosGeraisService.GetCodEmpresaAfilial(registrosC010.FirstOrDefault().CD_EMP);
                    if (codEmpFilial != "")
                    {
                        GetEmpresasFiliais(codEmpFilial);
                    }

                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        List<RegistroC010> registrosC010 = new List<RegistroC010>();

        private void ProcessarDocumentosFiscaisMercadorias()
        {
            this.UpdateStatusAsynchronousExecution("Iniciando processamento de documentos fiscais");


            registrosC010 = DocumentosFiscaisMercadoriasService.GetRegistrosC010(UndTrabalho.CodigoEmpresa).ToList();

            // GetEmpresasFiliais(UndTrabalho.CodigoEmpresa);
            produtos = new List<validacao>();
            unidades = new List<validacao>();
            contribuintes = new List<validacao>();
            foreach (RegistroC010 regC010 in registrosC010)
            {              
                this.UpdateStatusAsynchronousExecution("Gerando Registro C010");
                DadosArquivoPisCofinsService.PersistirRegistro(regC010);

                this.ProcessarNotasFiscaisMercadorias(regC010);
                this.ProcessarConsolidacaoNotasFiscais(regC010);
                this.ProcessarCuponsFiscais(regC010);
                this.ProcessarNotasFiscaisEnergiaAguaGas(regC010);
            }

            // Monta o registro de abertura do bloco, verificando se realmente existem
            // movimentações para o período especificado
            this.UpdateStatusAsynchronousExecution("Gerando Registro C001");
            RegistroC001 regC001 = new RegistroC001();
            if (DadosArquivoPisCofinsService.BlocoPossuiRegistros("C"))
                regC001.IND_MOV = "0";
            else
                regC001.IND_MOV = "1";
            DadosArquivoPisCofinsService.PersistirRegistro(regC001);

            this.UpdateStatusAsynchronousExecution("Gerando Registro C990");
            RegistroC990 regC990 = DadosArquivoPisCofinsService.GetRegistroC990();
            DadosArquivoPisCofinsService.PersistirRegistro(regC990);
        }

        private void ProcessarNotasFiscaisMercadorias(RegistroC010 regC010)
        {
            IEnumerable<RegistroC100> registrosC100 =
                NotasFiscaisMercadoriasService.GetRegistrosC100(regC010.CNPJ, regC010.CD_EMP);
            foreach (RegistroC100 regC100 in registrosC100)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro C100");
                DadosArquivoPisCofinsService.PersistirRegistro(regC100);

                // Processa informações do cliente ou fornecedor vinculado a uma nota fiscal
                this.ProcessarParticipante(regC100.COD_PART, regC010.CD_EMP);

                if (regC100.ST_DOC_CANCELADO != "S") // Não persiste registros filhos caso haja cancelamento
                    this.ProcessarDetalhesNotasFiscaisMercadorias(regC100, regC010.CD_EMP);
            }
        }

        private void ProcessarDetalhesNotasFiscaisMercadorias(RegistroC100 regC100, string codEmp)
        {
            this.UpdateStatusAsynchronousExecution("Processando detalhes de documento fiscal");

            // Processa possíveis informações de importação
            this.UpdateStatusAsynchronousExecution("Processando informações de importação");
            IEnumerable<RegistroC120> registrosC120 =
                NotasFiscaisMercadoriasService.GetRegistrosC120(regC100.PK_NOTAFIS, codEmp);
            foreach (RegistroC120 regC120 in registrosC120)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro C120");
                DadosArquivoPisCofinsService.PersistirRegistro(regC120);
            }

            // Processsa informações dos itens da nota fiscal
            this.UpdateStatusAsynchronousExecution("Processando itens de documento fiscal");
            IEnumerable<RegistroC170> registrosC170 =
                NotasFiscaisMercadoriasService.GetRegistrosC170(regC100.PK_NOTAFIS, codEmp);
            foreach (RegistroC170 regC170 in registrosC170)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro C170");
                DadosArquivoPisCofinsService.PersistirRegistro(regC170);

                this.ProcessarUnidade(regC170.UNID, codEmp);
                this.ProcessarProduto(regC170.COD_ITEM, codEmp);
            }
        }

        private void ProcessarConsolidacaoNotasFiscais(RegistroC010 regC010)
        {
            this.UpdateStatusAsynchronousExecution("Processando a consolidação de notas fiscais");

            string codEmp = regC010.CD_EMP;
            // Consolidação de notas fiscais eletrônicas - vendas
            IEnumerable<RegistroC180> registrosC180 =
                ConsolidacaoNotasFiscaisService.GetRegistrosC180(regC010.CNPJ, codEmp);
            IEnumerable<RegistroC181> registrosC181;
            IEnumerable<RegistroC185> registrosC185;
            foreach (RegistroC180 regC180 in registrosC180)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro C180");
                DadosArquivoPisCofinsService.PersistirRegistro(regC180);

                this.ProcessarProduto(regC180.COD_ITEM, regC010.CD_EMP);

                registrosC181 = ConsolidacaoNotasFiscaisService.GetRegistrosC181(
                    regC010.CNPJ,
                    regC180.COD_ITEM,
                    regC180.DT_DOC_INI.Value,
                    regC180.DT_DOC_FIN.Value,
                    codEmp);
                foreach (RegistroC181 regC181 in registrosC181)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro C181");
                    DadosArquivoPisCofinsService.PersistirRegistro(regC181);
                }

                registrosC185 = ConsolidacaoNotasFiscaisService.GetRegistrosC185(
                    regC010.CNPJ,
                    regC180.COD_ITEM,
                    regC180.DT_DOC_INI.Value,
                    regC180.DT_DOC_FIN.Value,
                    codEmp);
                foreach (RegistroC185 regC185 in registrosC185)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro C185");
                    DadosArquivoPisCofinsService.PersistirRegistro(regC185);
                }
            }

            // Consolidação de notas fiscais eletrônicas - direito a crédito e devoluções
            IEnumerable<RegistroC190> registrosC190 =
                ConsolidacaoNotasFiscaisService.GetRegistrosC190(regC010.CNPJ, codEmp);
            IEnumerable<RegistroC191> registrosC191;
            IEnumerable<RegistroC195> registrosC195;
            IEnumerable<RegistroC199> registrosC199;
            foreach (RegistroC190 regC190 in registrosC190)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro C190");
                DadosArquivoPisCofinsService.PersistirRegistro(regC190);

                this.ProcessarProduto(regC190.COD_ITEM, codEmp);

                registrosC191 = ConsolidacaoNotasFiscaisService.GetRegistrosC191(
                    regC010.CNPJ,
                    regC190.COD_ITEM,
                    regC190.DT_REF_INI.Value,
                    regC190.DT_REF_FIN.Value,
                    codEmp);
                foreach (RegistroC191 regC191 in registrosC191)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro C191");
                    DadosArquivoPisCofinsService.PersistirRegistro(regC191);
                }

                registrosC195 = ConsolidacaoNotasFiscaisService.GetRegistrosC195(
                    regC010.CNPJ,
                    regC190.COD_ITEM,
                    regC190.DT_REF_INI.Value,
                    regC190.DT_REF_FIN.Value,
                    codEmp);
                foreach (RegistroC195 regC195 in registrosC195)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro C195");
                    DadosArquivoPisCofinsService.PersistirRegistro(regC195);
                }

                registrosC199 = ConsolidacaoNotasFiscaisService.GetRegistrosC199(
                    regC010.CNPJ,
                    regC190.COD_ITEM,
                    regC190.DT_REF_INI.Value,
                    regC190.DT_REF_FIN.Value,
                    codEmp);
                foreach (RegistroC199 regC199 in registrosC199)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro C199");
                    DadosArquivoPisCofinsService.PersistirRegistro(regC199);
                }
            }

            // Consolidação de notas fiscais de vendas
            IEnumerable<RegistroC380> registrosC380 =
                ConsolidacaoNotasFiscaisService.GetRegistrosC380(regC010.CNPJ, codEmp);
            IEnumerable<RegistroC381> registrosC381;
            IEnumerable<RegistroC385> registrosC385;

            foreach (RegistroC380 regC380 in registrosC380)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro C380");
                DadosArquivoPisCofinsService.PersistirRegistro(regC380);

                registrosC381 = ConsolidacaoNotasFiscaisService.GetRegistrosC381(
                    regC010.CNPJ,
                    regC380.COD_MOD,
                    regC380.DT_DOC_INI.Value,
                    regC380.DT_DOC_FIN.Value,
                    codEmp);
                foreach (RegistroC381 regC381 in registrosC381)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro C381");
                    DadosArquivoPisCofinsService.PersistirRegistro(regC381);

                    this.ProcessarProduto(regC381.COD_ITEM, codEmp);
                }

                registrosC385 = ConsolidacaoNotasFiscaisService.GetRegistrosC385(
                    regC010.CNPJ,
                    regC380.COD_MOD,
                    regC380.DT_DOC_INI.Value,
                    regC380.DT_DOC_FIN.Value,
                    codEmp);
                foreach (RegistroC385 regC385 in registrosC385)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro C385");
                    DadosArquivoPisCofinsService.PersistirRegistro(regC385);

                    this.ProcessarProduto(regC385.COD_ITEM, codEmp);
                }
            }
        }

        private void ProcessarCuponsFiscais(RegistroC010 regC010)
        {
            IEnumerable<RegistroC400> registrosC400 =
                CuponsFiscaisService.GetRegistrosC400(regC010.CNPJ);
            IEnumerable<RegistroC405> registrosC405;
            IEnumerable<RegistroC481> registrosC481;
            IEnumerable<RegistroC485> registrosC485;

            foreach (RegistroC400 regC400 in registrosC400)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro C400");
                DadosArquivoPisCofinsService.PersistirRegistro(regC400);

                registrosC405 = CuponsFiscaisService
                    .GetRegistrosC405(regC010.CNPJ, regC400.PK_ECF);
                foreach (RegistroC405 regC405 in registrosC405)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro C405");
                    DadosArquivoPisCofinsService.PersistirRegistro(regC405);

                    registrosC481 = CuponsFiscaisService.GetRegistrosC481(
                        regC010.CNPJ, regC400.PK_ECF, regC405.DT_DOC.Value);
                    foreach (RegistroC481 regC481 in registrosC481)
                    {
                        this.UpdateStatusAsynchronousExecution("Gerando Registro C481");
                        DadosArquivoPisCofinsService.PersistirRegistro(regC481);

                        this.ProcessarProduto(regC481.COD_ITEM, regC010.CD_EMP);
                    }

                    registrosC485 = CuponsFiscaisService.GetRegistrosC485(
                        regC010.CNPJ, regC400.PK_ECF, regC405.DT_DOC.Value);
                    foreach (RegistroC485 regC485 in registrosC485)
                    {
                        this.UpdateStatusAsynchronousExecution("Gerando Registro C485");
                        DadosArquivoPisCofinsService.PersistirRegistro(regC485);

                        this.ProcessarProduto(regC485.COD_ITEM, regC010.CD_EMP);
                    }
                }
            }
        }

        private void ProcessarNotasFiscaisEnergiaAguaGas(RegistroC010 regC010)
        {
            IEnumerable<RegistroC500> registrosC500 =
                NotasFiscaisEnergiaAguaGasService.GetRegistrosC500(regC010.CNPJ);
            IEnumerable<RegistroC501> registrosC501;
            IEnumerable<RegistroC505> registrosC505;

            foreach (RegistroC500 regC500 in registrosC500)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro C500");
                DadosArquivoPisCofinsService.PersistirRegistro(regC500);

                // Processa informações do fornecedor vinculado a uma nota fiscal
                this.ProcessarParticipante(regC500.COD_PART, regC010.CD_EMP);

                registrosC501 = NotasFiscaisEnergiaAguaGasService.GetRegistrosC501(
                    regC500.PK_NOTAFIS);
                foreach (RegistroC501 regC501 in registrosC501)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro C501");
                    DadosArquivoPisCofinsService.PersistirRegistro(regC501);
                }

                registrosC505 = NotasFiscaisEnergiaAguaGasService.GetRegistrosC505(
                    regC500.PK_NOTAFIS);
                foreach (RegistroC505 regC505 in registrosC505)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro C505");
                    DadosArquivoPisCofinsService.PersistirRegistro(regC505);
                }
            }
        }


        /// <summary>
        /// Registro D
        /// </summary>
        private void ProcessarDocumentosFiscaisServicoICMS()
        {
            this.ProcessarNotasFiscaisServicosComunicacao();
            this.UpdateStatusAsynchronousExecution("Gerando Registro D001");
            RegistroD001 regD001 = new RegistroD001();
            if (DadosArquivoPisCofinsService.BlocoPossuiRegistros("D"))
            {
                regD001.IND_MOV = "0";
            }
            else
            {
                regD001.IND_MOV = "1";
            }
            DadosArquivoPisCofinsService.PersistirRegistro(regD001);

            RegistroD990 regD990 = DadosArquivoPisCofinsService.GetRegistroD990();
            DadosArquivoPisCofinsService.PersistirRegistro(regD990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro D990");
        }

        private void ProcessarDemaisDocumentosOperacoes()
        {

            List<RegistroF010> registrosF010;
            List<RegistroF600> registrosF600;
            List<RegistroF200> registrosF200;
            registrosF010 = demaisDocOperacoes.GetRegistroF010();

            foreach (RegistroF010 regf010 in registrosF010)
            {
                this.UpdateStatusAsynchronousExecution("Gerando Registro F010");
                DadosArquivoPisCofinsService.PersistirRegistro(regf010);
                registrosF200 = demaisDocOperacoes.GetRegistroF200(regf010.CD_EMP);

                foreach (RegistroF200 regF200 in registrosF200)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro F200");
                    DadosArquivoPisCofinsService.PersistirRegistro(regF200);
                }


                registrosF600 = demaisDocOperacoes.GetRegistroF600(regf010.CD_EMP);

                foreach (RegistroF600 regf600 in registrosF600)
                {
                    this.UpdateStatusAsynchronousExecution("Gerando Registro F600");
                    DadosArquivoPisCofinsService.PersistirRegistro(regf600);
                }
            }

            RegistroF001 regF001 = new RegistroF001();
            if (DadosArquivoPisCofinsService.BlocoPossuiRegistros("F"))
                regF001.IND_MOV = "0";
            else
                regF001.IND_MOV = "1";
            //regF001.IND_MOV = "1"; // Nesta primeira versão este bloco não será informado
            DadosArquivoPisCofinsService.PersistirRegistro(regF001);
            this.UpdateStatusAsynchronousExecution("Gerando Registro F001");

            RegistroF990 regF990 = DadosArquivoPisCofinsService.GetRegistroF990();
            DadosArquivoPisCofinsService.PersistirRegistro(regF990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro F990");
        }

        private void ProcessarApuracaoContribuicaoCreditoPIS_PASEP()
        {
            RegistroM001 regM001 = new RegistroM001();
            regM001.IND_MOV = "1"; // Nesta primeira versão este bloco não será informado
            DadosArquivoPisCofinsService.PersistirRegistro(regM001);
            this.UpdateStatusAsynchronousExecution("Gerando Registro M001");

            RegistroM990 regM990 = DadosArquivoPisCofinsService.GetRegistroM990();
            DadosArquivoPisCofinsService.PersistirRegistro(regM990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro M990");
        }

        private void ProcessarApuracaoContribPrevidRecBruta()
        {
            // Nesta primeira versão isto ainda não será implementado; levantar posteriormente
            // se isto realmente é necessário
            this.UpdateStatusAsynchronousExecution(
                "Iniciando processamento da apuração da contrib. previdenciária sobre a receita bruta");

            /*  RegistroP001 regP001 = new RegistroP001();
            regP001.IND_MOV = "1"; // Nesta primeira versão este bloco não será informado
            DadosArquivoPisCofinsService.PersistirRegistro(regP001);
            this.UpdateStatusAsynchronousExecution("Gerando Registro P001");

            RegistroP990 regP990 = DadosArquivoPisCofinsService.GetRegistroP990();
            DadosArquivoPisCofinsService.PersistirRegistro(regP990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro P990");*/
            //os 27580 -erick - 31/05/2012 - registro ainda nao é necessario ate julho
        }

        private void ProcessarComplementoEscrituracao()
        {
            // Nesta primeira versão isto ainda não será implementado; levantar posteriormente
            // se isto realmente é necessário
            this.UpdateStatusAsynchronousExecution(
                "Iniciando processamento de informações complementares da escrituração");

            Registro1001 reg1001 = new Registro1001();
            reg1001.IND_MOV = "1"; // Nesta primeira versão este bloco não será informado
            DadosArquivoPisCofinsService.PersistirRegistro(reg1001);
            this.UpdateStatusAsynchronousExecution("Gerando Registro 1001");

            Registro1990 reg1990 = DadosArquivoPisCofinsService.GetRegistro1990();
            DadosArquivoPisCofinsService.PersistirRegistro(reg1990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro 1990");
        }

        private void ProcessarControlesEncerramento()
        {
            this.UpdateStatusAsynchronousExecution("Iniciando geração dos controles de encerramento");



            Registro9001 reg9001 = DadosArquivoPisCofinsService.GetRegistro9001();
            DadosArquivoPisCofinsService.PersistirRegistro(reg9001);
            this.UpdateStatusAsynchronousExecution("Gerando Registro 9001");

            List<Registro9900> registros9900 = DadosArquivoPisCofinsService.GetRegistros9900().ToList();
            foreach (Registro9900 reg9900 in registros9900)
            {
                DadosArquivoPisCofinsService.PersistirRegistro(reg9900);
                this.UpdateStatusAsynchronousExecution("Gerando Registro 9900");
            }

            Registro9990 reg9990 = DadosArquivoPisCofinsService.GetRegistro9990();
            DadosArquivoPisCofinsService.PersistirRegistro(reg9990);
            this.UpdateStatusAsynchronousExecution("Gerando Registro 9990");

            Registro9999 reg9999 = DadosArquivoPisCofinsService.GetRegistro9999();
            DadosArquivoPisCofinsService.PersistirRegistro(reg9999);
            this.UpdateStatusAsynchronousExecution("Gerando Registro 9999");
        }

        private void ProcessarFinalBloco0990()
        {
            // Como pode ocorrer a inclusão de dados de Participantes, Produtos e Unidades
            // em outros blocos, a geração do registro 0990 deve ocorrer somente neste momento
            this.UpdateStatusAsynchronousExecution("Gerando Registro 0990");
            Registro0990 reg0990 = DadosArquivoPisCofinsService.GetRegistro0990();
            DadosArquivoPisCofinsService.PersistirRegistro(reg0990);
        }

        private void ProcessarParticipante(string codigoParticipante, string codEmp)
        {
            if (String.IsNullOrWhiteSpace(codigoParticipante))
                return;

            Registro0150 reg0150 = ParticipantesService.GetRegistro0150(codigoParticipante);

            if (reg0150 != null)
            {
                if (contribuintes.Where(c => c.codEmp == codEmp && c.registro.ToString() == reg0150.ToString()).Count() == 0)
                {
                    // Caso o cliente ou fornecedor ainda não tenha sido processado,
                    // persiste o mesmo para posterior geração do arquivo
                    contribuintes.Add(new validacao { codEmp = codEmp, registro = reg0150 });
                }
            }
        }

        private void ProcessarUnidade(string codigoUnidade, string codEmp)
        {
            if (String.IsNullOrWhiteSpace(codigoUnidade))
                return;

            Registro0190 reg0190 = UnidadesService.GetRegistro0190(codigoUnidade);
            if (reg0190 != null)
            {
                if (unidades.Where(c => c.codEmp == codEmp && c.registro.ToString() == reg0190.ToString()).Count() == 0)
                {
                    // Apenas persiste uma unidade se a mesma ainda não tiver sido processada
                    //this.UpdateStatusAsynchronousExecution("Gerando Registro 0190");
                    //DadosArquivoPisCofinsService.PersistirRegistro(reg0190);
                    unidades.Add(new validacao { codEmp = codEmp, registro = reg0190 });
                }
            }
        }

        private void ProcessarProduto(string codigoProduto, string codEmp)
        {
            if (String.IsNullOrWhiteSpace(codigoProduto))
                return;

            Registro0200 reg0200 = ProdutosService.GetRegistro0200(codigoProduto, codEmp);
            if (reg0200 != null)
            {
                //if (!DadosArquivoPisCofinsService.RegistroJaExistente("0200", codigoProduto))
                if (produtos.Where(c => c.codEmp == codEmp && c.registro.ToString() == reg0200.ToString()).Count() == 0)
                {
                    // Apenas persiste uma unidade se a mesma ainda não tiver sido processada
                    //this.UpdateStatusAsynchronousExecution("Gerando Registro 0200");
                    //DadosArquivoPisCofinsService.PersistirRegistro(reg0200);
                    produtos.Add(new validacao { codEmp = codEmp, registro = reg0200 });
                    this.ProcessarUnidade(reg0200.UNID_INV, codEmp);
                }
            }
        }

        #endregion


        #region Outros métodos privados

        private void ProcessarGravacaoArquivo()
        {
            try
            {
                this.UpdateStatusAsynchronousExecution("Iniciando gravação do arquivo");

                SpedFileWriterService.Initialize(this._parameters.CaminhoArquivo);
                DadosArquivoPisCofinsService.OpenRegistros();
                while (DadosArquivoPisCofinsService.ReadRegistro())
                {
                    // ATENÇÃO: Não atualizar o status de execução do form que invocou este
                    // Controller, uma vez que a manipulação de arquivos tende a levar a estouros
                    // de memória neste caso. Logo, evitar chamadas ao método "UpdateStatusAsynchronousExecution"
                    // dentro deste loop.
                    SpedFileWriterService.WriteLine(
                        DadosArquivoPisCofinsService.GetConteudoRegistro());
                }
                DadosArquivoPisCofinsService.Finalizar();
                this.UpdateStatusAsynchronousExecution("Gravação em arquivo finalizada");
            }
            finally
            {
                DadosArquivoPisCofinsService.CloseRegistros();
                SpedFileWriterService.Close();
            }
        }

        private void PisCofinsProcessController_AsynchronousExecution()
        {
            try
            {

                this.ProcessarDadosGerais();
                this.ProcessarDocumentosFiscaisServico();
                this.ProcessarDocumentosFiscaisMercadorias();
                this.ProcessarDocumentosFiscaisServicoICMS();
                this.ProcessarDemaisDocumentosOperacoes();
                this.ProcessarApuracaoContribuicaoCreditoPIS_PASEP();
                this.ProcessarApuracaoContribPrevidRecBruta();
                this.ProcessarComplementoEscrituracao();
                this.ProcessarDadosGeraisPorEmpresa(); //INICIA EMPRESAS
                this.ProcessarFinalBloco0990(); // FINALIZA EMPRESAS

                this.ProcessarControlesEncerramento();

                this.ProcessarGravacaoArquivo();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void PisCofinsProcessController_AsynchronousExecutionAborted(Exception ex)
        {
            DadosArquivoPisCofinsService.RegistrarExcecao(ex);
        }

        #endregion
    }
}