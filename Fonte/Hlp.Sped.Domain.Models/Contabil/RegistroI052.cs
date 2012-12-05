using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I052: Indicação dos Códigos de Aglutinação
    /// </summary>
    public class RegistroI052 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I052"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string COD_CCUS { get; set; }

        [CampoTextoVariavel(Ordem = 3)]
        public string COD_AGL { get; set; }
    }
}