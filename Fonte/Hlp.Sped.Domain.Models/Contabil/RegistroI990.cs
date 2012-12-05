using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I990: Encerramento do Bloco I
    /// </summary>
    public class RegistroI990 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I990"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public int? QTD_LIN_I { get; set; }
    }
}