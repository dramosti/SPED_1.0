using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I200: Lançamento Contábil
    /// </summary>
    public class RegistroI200 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I200"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string NUM_LCTO { get; set; }

        [CampoData(Ordem = 3)]
        public DateTime? DT_LCTO { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? VL_LCTO { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 1)]
        public string IND_LCTO { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "I200-" + this.GetNumeroControleRegistro(); }
        }
    }
}