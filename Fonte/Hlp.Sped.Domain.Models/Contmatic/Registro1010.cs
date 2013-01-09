using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class Registro1010 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "1010"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 15)]
        public string NUM_PROC { get; set; }

        [CampoTextoVariavel(Ordem = 3)]
        public string ID_SEC_JUD { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 2)]
        public string ID_VARA { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 2)]
        public string IND_NAT_ACAO { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 100)]
        public string DESC_DEC_JUD { get; set; }

        [CampoData(Ordem = 7)]
        public DateTime DT_SENT_JUD { get; set; }


    }
}
