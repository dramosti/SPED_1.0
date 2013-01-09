using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class RegistroD101 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "D101"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 1)]
        public string IND_NAT_FRT { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 2)]
        public decimal VL_ITEM { get; set; }

        [CampoTextoNumerico(Ordem = 4, ComprimentoFixo = true, Tamanho = 2)]
        public int CST_PIS { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 2)]
        public string NAT_BC_CRED { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal? VL_BC_PIS { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 4)]
        public decimal? ALIQ_PIS { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal? VL_PIS { get; set; }

        [CampoTextoVariavel(Ordem = 9, Tamanho = 60)]
        public string COD_CTA { get; set; }

        [CampoTextoNumerico(Ordem = 10, ComprimentoFixo = true, Tamanho = 2)]
        public string CST_COFINS { get; set; }

        [CampoDecimal(Ordem = 11, CasasDecimais = 2)]
        public decimal? VL_BC_COFINS { get; set; }

        [CampoDecimal(Ordem = 12, CasasDecimais = 4)]
        public decimal? ALIQ_COFINS { get; set; }

        [CampoDecimal(Ordem = 13, CasasDecimais = 2)]
        public decimal? VL_COFINS { get; set; }

        [CampoTextoVariavel(Ordem = 14, Tamanho = 60)]
        public string COD_CTA2 { get; set; }

        [CampoTextoNumerico(Ordem = 15, Tamanho = 3)]
        public int? NAT_REC_PIS { get; set; }

        [CampoTextoNumerico(Ordem = 16, Tamanho = 3)]
        public int? NAT_REC_COFINS { get; set; }
    }
}
