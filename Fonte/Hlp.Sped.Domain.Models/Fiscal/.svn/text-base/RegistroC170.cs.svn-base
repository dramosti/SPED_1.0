using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroC170 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C170"; }
        }

        [CampoTextoNumerico(Ordem = 2, Tamanho = 3)]
        public int? NUM_ITEM { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 60)]
        public string COD_ITEM { get; set; }

        [CampoTextoVariavel(Ordem = 4)]
        public string DESCR_COMPL { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 5)]
        public decimal? QTD { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 6)]
        public string UNID { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 2)]
        public decimal? VL_ITEM { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal? VL_DESC { get; set; }

        [CampoTextoNumerico(Ordem = 9, Tamanho = 1)]
        public int? IND_MOV { get; set; }

        [CampoTextoNumerico(Ordem = 10, ComprimentoFixo = true, Tamanho = 3)]
        public string CST_ICMS { get; set; }

        [CampoTextoNumerico(Ordem = 11, ComprimentoFixo = true, Tamanho = 4)]
        public string CFOP { get; set; }

        [CampoTextoVariavel(Ordem = 12, Tamanho = 10)]
        public string COD_NAT { get; set; }

        [CampoDecimal(Ordem = 13, CasasDecimais = 2)]
        public decimal? VL_BC_ICMS { get; set; }

        [CampoDecimal(Ordem = 14, CasasDecimais = 2)]
        public decimal? ALIQ_ICMS { get; set; }

        [CampoDecimal(Ordem = 15, CasasDecimais = 2)]
        public decimal? VL_ICMS { get; set; }

        [CampoDecimal(Ordem = 16, CasasDecimais = 2)]
        public decimal? VL_BC_ICMS_ST { get; set; }

        [CampoDecimal(Ordem = 17, CasasDecimais = 2)]
        public decimal? ALIQ_ST { get; set; }

        [CampoDecimal(Ordem = 18, CasasDecimais = 2)]
        public decimal? VL_ICMS_ST { get; set; }

        [CampoTextoVariavel(Ordem = 19, Tamanho = 1)]
        public string IND_APUR { get; set; }

        [CampoTextoVariavel(Ordem = 20, Tamanho = 2)]
        public string CST_IPI { get; set; }

        [CampoTextoVariavel(Ordem = 21, Tamanho = 3)]
        public string COD_ENQ { get; set; }

        [CampoDecimal(Ordem = 22, CasasDecimais = 2)]
        public decimal? VL_BC_IPI { get; set; }

        [CampoDecimal(Ordem = 23, CasasDecimais = 2)]
        public decimal? ALIQ_IPI { get; set; }

        [CampoDecimal(Ordem = 24, CasasDecimais = 2)]
        public decimal? VL_IPI { get; set; }

        [CampoTextoNumerico(Ordem = 25, ComprimentoFixo = true, Tamanho = 2)]
        public string CST_PIS { get; set; }

        [CampoDecimal(Ordem = 26, CasasDecimais = 2)]
        public decimal? VL_BC_PIS { get; set; }

        [CampoDecimal(Ordem = 27, CasasDecimais = 2)]
        public decimal? ALIQ_PIS { get; set; }

        [CampoDecimal(Ordem = 28, CasasDecimais = 3)]
        public decimal? QUANT_BC_PIS { get; set; }

        [CampoDecimal(Ordem = 29, CasasDecimais = 4)]
        public decimal? ALIQ_PIS_B { get; set; }

        [CampoDecimal(Ordem = 30, CasasDecimais = 2)]
        public decimal? VL_PIS { get; set; }

        [CampoTextoNumerico(Ordem = 31, ComprimentoFixo = true, Tamanho = 2)]
        public string CST_COFINS { get; set; }

        [CampoDecimal(Ordem = 32, CasasDecimais = 2)]
        public decimal? VL_BC_COFINS { get; set; }

        [CampoDecimal(Ordem = 33, CasasDecimais = 2)]
        public decimal? ALIQ_COFINS { get; set; }

        [CampoDecimal(Ordem = 34, CasasDecimais = 2)]
        public decimal? QUANT_BC_COFINS { get; set; }

        [CampoDecimal(Ordem = 35, CasasDecimais = 4)]
        public decimal? ALIQ_COFINS_B { get; set; }

        [CampoDecimal(Ordem = 36, CasasDecimais = 2)]
        public decimal? VL_COFINS { get; set; }

        [CampoTextoVariavel(Ordem = 37)]
        public string COD_CTA { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C100-" + this.GetNumeroControleRegistro(); }
        }
    }   
}