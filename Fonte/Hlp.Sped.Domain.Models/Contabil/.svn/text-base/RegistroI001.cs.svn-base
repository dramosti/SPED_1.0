using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// I001: Abertura do Bloco I
    /// </summary>
    public class RegistroI001 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I001"; }
        }

        [CampoTextoNumerico(Ordem = 2, Tamanho = 1)]
        public string IND_DAD { get; set; }
    }
}