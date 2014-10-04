using Hlp.Sped.Infrastructure.Annotations;
using Hlp.Sped.Infrastructure.Registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroK001 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "K001"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 1)]
        public string IND_MOV { get; set; }
    }
}
