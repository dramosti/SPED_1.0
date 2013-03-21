using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Annotations;
using Hlp.Sped.Infrastructure.Registro;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroD105 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "D105"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 1)]
        public string IND_NAT_FRT { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 2)]
        public decimal VL_ITEM { get; set; }

        [CampoTextoNumerico(Ordem = 4, ComprimentoFixo = true, Tamanho = 2)]
        public int CST_COFINS { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 2)]
        public string NAT_BC_CRED { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal? VL_BC_COFINS { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 4)]
        public decimal? ALIQ_COFINS { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal? VL_COFINS { get; set; }

        [CampoTextoVariavel(Ordem = 9, Tamanho = 60)]
        public string COD_CTA { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "D100-" + this.GetNumeroControleRegistro(); }
        }
    }
}
