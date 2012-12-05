using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO 0001: Abertura do Bloco 0
    /// </summary>
    public class Registro0001 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "0001"; }
        }

        [CampoTextoNumerico(Ordem = 2, Tamanho = 1)]
        public int? IND_DAD { get; set; }
    }
}