using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class Registro0140 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0140"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 60)]
        public string COD_EST { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 100)]
        public string NOME { get; set; }

        [CampoTextoNumerico(Ordem = 4, ComprimentoFixo = true, Tamanho = 14)]
        public string CNPJ { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 2)] //ERICK OS.27580 - 30/05/2012
        public string UF { get; set; }
        
        [CampoTextoVariavel(Ordem = 6, Tamanho = 14)]
        public string IE { get; set; }

        [CampoTextoNumerico(Ordem = 7, ComprimentoFixo = true, Tamanho = 7)]
        public string COD_MUN { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 20)]
        public string IM { get; set; }

        [CampoTextoVariavel(Ordem = 9, Tamanho = 9)]  //os 27580 - comentando teste
        public string SUFRAMA { get; set; }
    }
}