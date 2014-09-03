using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I155: Detalhe dos Saldos Periódicos
    /// </summary>
    public class RegistroI155 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "I155"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string COD_CTA { get; set; }

        [CampoTextoVariavel(Ordem = 3)]
        public string COD_CCUS { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? VL_SLD_INI { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 1)]
        public string IND_DC_INI { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal? VL_DEB { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 2)]
        public decimal? VL_CRED { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal? VL_SLD_FIN { get; set; }

        [CampoTextoVariavel(Ordem = 9, Tamanho = 1)]
        public string IND_DC_FIN { get; set; }
    }
}