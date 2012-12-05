using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO J990: Encerramento do Bloco J
    /// </summary>
    public class RegistroJ990 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "J990"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public int? QTD_LIN_J { get; set; }
    }
}