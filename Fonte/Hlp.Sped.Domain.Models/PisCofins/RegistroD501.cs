using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroD501 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "D501"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public int CST_PIS { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 2)]
        public decimal VL_ITEM { get; set; }

        [CampoTextoNumerico(Ordem = 4, ComprimentoFixo = true, Tamanho = 2)]
        public string NAT_BC_CRED { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal VL_BC_PIS { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal ALIQ_PIS { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 2)]
        public decimal VL_PIS { get; set; }

        [CampoTextoNumerico(Ordem = 8, Tamanho = 9)]
        public string COD_CTA { get; set; }
        
        public override string CODIGO_ORDENACAO
        {
            get { return "D500-" + this.GetNumeroControleRegistro(); }
        }

       

    }
}
