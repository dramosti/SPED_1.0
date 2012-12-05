using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO J001: Abertura do Bloco J
    /// </summary>
    public class RegistroJ001 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "J001"; }
        }

        [CampoTextoNumerico(Ordem = 2, Tamanho = 1)]
        public int? IND_DAD { get; set; }
    }
}