using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I310: Detalhes do Balancete Diário
    /// </summary>
    public class RegistroI310 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I310"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string COD_CTA { get; set; }

        [CampoTextoVariavel(Ordem = 3)]
        public string COD_CCUS { get; set; }

        [CampoTextoNumerico(Ordem = 4)]
        public string VAL_DEBD { get; set; }

        [CampoTextoNumerico(Ordem = 5)]
        public string VAL_CRED { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "I300-" + this.GetNumeroControleRegistro(); }
        }
    }
}