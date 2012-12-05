using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I150: Saldos Periódicos - Identificação do Período
    /// </summary>
    public class RegistroI150 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I150"; }
        }

        [CampoData(Ordem = 2)]
        public DateTime? DT_INI { get; set; }

        [CampoData(Ordem = 3)]
        public DateTime? DT_FIN { get; set; }

    }
}