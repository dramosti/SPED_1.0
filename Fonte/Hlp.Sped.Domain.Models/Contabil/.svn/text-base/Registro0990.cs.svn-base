using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO 0990: Encerramento do Bloco 0
    /// </summary>
    public class Registro0990 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "0990"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public int? QTD_LIN_0 { get; set; }
    }
}