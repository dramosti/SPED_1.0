using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class RegistroA990 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "A990"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public int? QTD_LIN_A { get; set; }
    }
}
