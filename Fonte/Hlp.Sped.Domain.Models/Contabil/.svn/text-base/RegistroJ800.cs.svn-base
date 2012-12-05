using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO J800: Outras Informações
    /// </summary>
    public class RegistroJ800 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "J800"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string ARQ_RTF { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 7)]
        public string IND_FIM_RTF { get; set; }
    }
}