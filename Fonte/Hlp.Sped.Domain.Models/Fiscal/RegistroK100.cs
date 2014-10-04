using Hlp.Sped.Infrastructure.Annotations;
using Hlp.Sped.Infrastructure.Registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroK100 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "K100"; }
        }

        [CampoData(Ordem = 2)]
        public DateTime? DT_INI { get; set; }

        [CampoData(Ordem = 3)]
        public DateTime? DT_FIN { get; set; }

    }
}
