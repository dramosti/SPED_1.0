using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO 9990: Encerramento do Bloco 9
    /// </summary>
    public class Registro9990 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "9990"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public int? QTD_LIN_9 { get; set; }
    }
}