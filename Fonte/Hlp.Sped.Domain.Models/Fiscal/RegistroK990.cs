using Hlp.Sped.Infrastructure.Annotations;
using Hlp.Sped.Infrastructure.Registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroK990 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "K990"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public int? QTD_LIN_H { get; set; }
    }
}
