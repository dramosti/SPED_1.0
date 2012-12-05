using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO J150: Demonstração do Resultado do Exercício
    /// </summary>
    public class RegistroJ150 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "J150"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string COD_AGL { get; set; }

        [CampoTextoNumerico(Ordem = 3)]
        public string NIVEL_AGL { get; set; }

        [CampoTextoVariavel(Ordem = 4)]
        public string DESCR_COD_AGL { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal? VL_CTA { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 1)]
        public string IND_VL { get; set; }
    }
}