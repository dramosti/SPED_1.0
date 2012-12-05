using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I250: Partidas do Lançamento
    /// </summary>
    public class RegistroI250 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I250"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string COD_CTA { get; set; }

        [CampoTextoVariavel(Ordem = 3)]
        public string COD_CCUS { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? VL_DC { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 1)]
        public string IND_DC { get; set; }

        [CampoTextoVariavel(Ordem = 6)]
        public string NUM_ARQ { get; set; }

        [CampoTextoVariavel(Ordem = 7)]
        public string COD_HIST_PAD { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 65535)]
        public string HIST { get; set; }

        [CampoTextoVariavel(Ordem = 9)]
        public string COD_PART { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "I200-" + this.GetNumeroControleRegistro(); }
        }
    }
}