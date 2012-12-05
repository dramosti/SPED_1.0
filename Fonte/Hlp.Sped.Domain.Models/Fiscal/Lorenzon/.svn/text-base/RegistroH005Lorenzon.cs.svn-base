using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal.Lorenzon
{
    public class RegistroH005Lorenzon : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "H005"; }
        }

        [CampoData(Ordem = 2)]
        public DateTime? DT_INV { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 2)]
        public decimal? VL_INV { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "H005-" + this.GetNumeroControleRegistro(); }
        }

    }
}
