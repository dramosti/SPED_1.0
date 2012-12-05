using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I051: Plano de Contas Referencial
    /// </summary>
    public class RegistroI051 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I051"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 2)]
        public string COD_ENT_REF { get; set; }

        [CampoTextoVariavel(Ordem = 3)]
        public string COD_CCUS { get; set; }

        [CampoTextoVariavel(Ordem = 4)]
        public string COD_CTA_REF { get; set; }
    }
}