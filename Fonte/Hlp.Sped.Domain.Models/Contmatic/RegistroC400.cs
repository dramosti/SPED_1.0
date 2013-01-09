using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class RegistroC400 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C400"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 2)]
        public string COD_MOD { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 20)]
        public string ECF_MOD { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 20)]
        public string ECF_FAB { get; set; }

        [CampoTextoNumerico(Ordem = 5, Tamanho = 3)]
        public int ECF_CX { get; set; }
    }
}
