using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class Registro0600 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0600"; }
        }

        [CampoData(Ordem = 2)]
        public DateTime DT_ALT { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 60)]
        public string COD_CCUS { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 60)]
        public string CCUS { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 60)]
        public string COD_ITEM { get; set; }

    }
}
