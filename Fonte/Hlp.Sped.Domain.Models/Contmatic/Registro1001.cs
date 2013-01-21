using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    /// <summary>
    /// REGISTRO 1001: ABERTURA DO BLOCO 1
    /// Este registro deverá ser gerado para abertura do Bloco 1 e indicará se há informações no bloco.
    /// </summary>
    public class Registro1001 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "1001"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 1)]
        public string IND_MOV { get; set; }
    }   
}
    