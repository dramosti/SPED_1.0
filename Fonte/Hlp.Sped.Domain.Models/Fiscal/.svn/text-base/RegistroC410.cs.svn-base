using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroC410 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C410"; }
        }

        [CampoDecimal(Ordem = 2, CasasDecimais = 2)]
        public decimal? VL_PIS { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 2)]
        public decimal? VL_COFINS { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C400-" + this.GetNumeroControleRegistro(); }
        }
    }
}
