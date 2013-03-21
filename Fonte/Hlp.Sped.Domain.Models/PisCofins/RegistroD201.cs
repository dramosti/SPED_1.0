using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Annotations;
using Hlp.Sped.Infrastructure.Registro;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroD201 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "D201"; }
        }
        [CampoTextoVariavel(Ordem = 2, Tamanho = 2)]
        public string CST_PIS { get; set; }
        [CampoDecimal(Ordem = 3, CasasDecimais = 2)]
        public decimal VL_ITEM { get; set; }
        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal VL_BC_PIS { get; set; }
        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal ALIQ_PIS { get; set; }
        [CampoDecimal(Ordem = 6, CasasDecimais = 4)]
        public decimal VL_PIS { get; set; }
        [CampoTextoVariavel(Ordem = 7)]
        public string COD_CTA { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "D200-" + this.GetNumeroControleRegistro(); }
        }
    }
}
