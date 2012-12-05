using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO J100: Balanço Patrimonial
    /// </summary>
    public class RegistroJ100 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "J100"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string COD_AGL { get; set; }

        [CampoTextoNumerico(Ordem = 3)]
        public string NIVEL_AGL { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 1)]
        public string IND_GRP_BAL { get; set; }

        [CampoTextoVariavel(Ordem = 5)]
        public string DESCR_COD_AGL { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal? VL_CTA { get; set; }

        [CampoTextoVariavel(Ordem = 7, Tamanho = 1)]
        public string IND_DC_BAL { get; set; }
    }
}