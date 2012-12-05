using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I015: Identificação das Contas da Escrituração Resumida a
    /// que se Refere a Escrituração Auxiliar
    /// </summary>
    public class RegistroI015 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I015"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string COD_CTA_RES { get; set; }
    }
}