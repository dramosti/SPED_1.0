using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class Registro1010 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "1010"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 1)]
        public string IND_EXP { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 1)]
        public string IND_CCRF { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 1)]
        public string IND_COMB { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 1)]
        public string IND_USINA { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 1)]
        public string IND_VA { get; set; }

        [CampoTextoVariavel(Ordem = 7, Tamanho = 1)]
        public string IND_EE { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 1)]
        public string IND_CART { get; set; }

        [CampoTextoVariavel(Ordem = 9, Tamanho = 1)]
        public string IND_FORM { get; set; }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 1)]
        public string IND_AER { get; set; }
    }
}