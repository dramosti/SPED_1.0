using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I100: Centro de Custos
    /// </summary>
    public class RegistroI100 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I100"; }
        }

        [CampoData(Ordem = 2)]
        public DateTime? DT_ALT { get; set; }

        [CampoTextoVariavel(Ordem = 3)]
        public string COD_CCUS { get; set; }

        [CampoTextoVariavel(Ordem = 4)]
        public string CCUS { get; set; }
    }
}