using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class RegistroD510 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "D510"; }
        }

        [CampoTextoNumerico(Ordem = 2, Tamanho = 3)]
        public int NUM_ITEM { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 60)]
        public string COD_ITEM { get; set; }

        [CampoTextoNumerico(Ordem = 4, Tamanho = 4)]
        public int? COD_CLASS { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 3)]
        public decimal? QTD { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 6)]
        public string UNID { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 2)]
        public decimal VL_ITEM { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal? VL_DESC { get; set; }

        [CampoTextoNumerico(Ordem = 9, Tamanho = 3)]
        public int CST_ICMS { get; set; }

        [CampoTextoNumerico(Ordem = 10, Tamanho = 4)]
        public int CFOP { get; set; }

        [CampoDecimal(Ordem = 11, CasasDecimais = 2)]
        public decimal? VL_BC_ICMS { get; set; }

        [CampoDecimal(Ordem = 12, CasasDecimais = 2)]
        public decimal? ALIQ_ICMS { get; set; }

        [CampoDecimal(Ordem = 13, CasasDecimais = 2)]
        public decimal? VL_ICMS { get; set; }

        [CampoDecimal(Ordem = 14, CasasDecimais = 2)]
        public decimal? VL_BC_ICMS_UF { get; set; }

        [CampoDecimal(Ordem = 15, CasasDecimais = 2)]
        public decimal? VL_ICMS_UF { get; set; }

        [CampoTextoNumerico(Ordem = 16, Tamanho = 1)]
        public int IND_REC { get; set; }

        [CampoTextoVariavel(Ordem = 17, Tamanho = 60)]
        public string COD_PART { get; set; }

        [CampoDecimal(Ordem = 18, CasasDecimais = 2)]
        public decimal? VL_PIS { get; set; }

        [CampoDecimal(Ordem = 19, CasasDecimais = 2)]
        public decimal? VL_COFINS { get; set; }

        [CampoTextoVariavel(Ordem = 20)]
        public string COD_CTA { get; set; }


        [CampoTextoNumerico(Ordem = 21, ComprimentoFixo = true, Tamanho = 2)]
        public int CST_PIS { get; set; }

        [CampoTextoVariavel(Ordem = 22, Tamanho=3)]
        public string NAT_REC_PIS { get; set; }

        [CampoDecimal(Ordem = 23, CasasDecimais = 2)]
        public decimal? VL_BC_PIS { get; set; }

        [CampoDecimal(Ordem = 24, CasasDecimais = 4)]
        public decimal? ALIQ_PIS { get; set; }

        [CampoTextoNumerico(Ordem = 25, ComprimentoFixo = true, Tamanho = 2)]
        public int CST_COFINS { get; set; }

        [CampoTextoVariavel(Ordem = 26, Tamanho = 3)]
        public string NAT_REC_COFINS { get; set; }

        [CampoDecimal(Ordem = 27, CasasDecimais = 2)]
        public decimal? VL_BC_COFINS { get; set; }

        [CampoDecimal(Ordem = 28, CasasDecimais = 4)]
        public decimal? ALIQ_COFINS { get; set; }

        [CampoTextoVariavel(Ordem = 29, Tamanho = 1)]
        public string IND_MOV { get; set; }

    }
}
