using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class RegistroC470 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C470"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 60)]
        public string COD_ITEM { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 3)]
        public decimal QTD { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 3)]
        public decimal? QTD_CANC { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 6)]
        public string UNID { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal VL_ITEM { get; set; }

        [CampoTextoNumerico(Ordem = 7, Tamanho = 3)]
        public string CST_ICMS { get; set; }

        [CampoTextoNumerico(Ordem = 8, Tamanho = 4)]
        public string CFOP { get; set; }

        [CampoDecimal(Ordem = 9, CasasDecimais = 2)]
        public decimal? ALIQ_ICMS { get; set; }

        [CampoDecimal(Ordem = 10, CasasDecimais = 2)]
        public decimal VL_PIS { get; set; }

        [CampoDecimal(Ordem = 11, CasasDecimais = 2)]
        public decimal VL_COFINS { get; set; }

        #region Campos Especificos

        [CampoTextoNumerico(Ordem = 12, ComprimentoFixo = true, Tamanho = 2)]
        public int CST_PIS { get; set; }

        [CampoTextoVariavel(Ordem = 13, Tamanho = 3)]
        public string NAT_REC_PIS { get; set; }

        [CampoDecimal(Ordem = 14, CasasDecimais = 2)]
        public decimal? VL_BC_PIS { get; set; }

        [CampoDecimal(Ordem = 15, CasasDecimais = 4)]
        public decimal? ALIQ_PIS { get; set; }

        [CampoDecimal(Ordem = 16, CasasDecimais = 3)]
        public decimal? QUANT_BC_PIS { get; set; }

        [CampoDecimal(Ordem = 17, CasasDecimais = 4)]
        public decimal? ALIQ_PIS_QUANT { get; set; }

        [CampoTextoNumerico(Ordem = 18, ComprimentoFixo = true, Tamanho = 2)]
        public int CST_COFINS { get; set; }

        [CampoTextoVariavel(Ordem = 19, Tamanho = 3)]
        public string NAT_REC_COFINS { get; set; }

        [CampoDecimal(Ordem = 20, CasasDecimais = 2)]
        public decimal? VL_BC_COFINS { get; set; }

        [CampoDecimal(Ordem = 21, CasasDecimais = 4)]
        public decimal? ALIQ_COFINS { get; set; }

        [CampoDecimal(Ordem = 22, CasasDecimais = 3)]
        public decimal? QUANT_BC_COFINS { get; set; }

        [CampoDecimal(Ordem = 23, CasasDecimais = 4)]
        public decimal ALIQ_COFINS_QUANT { get; set; }

        [CampoTextoVariavel(Ordem = 24, Tamanho = 60)]
        public string COD_CTA { get; set; }

        [CampoTextoVariavel(Ordem = 25, Tamanho = 1)]
        public string IND_MOV { get; set; }

        #endregion


        public override string CODIGO_ORDENACAO
        {
            get { return "C460-" + this.GetNumeroControleRegistro(); }
        }
    }
}
