using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I355: Detalhes dos Saldos das Contas de Resultado Antes
    /// do Encerramento
    /// </summary>
    public class RegistroI355 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I355"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string COD_CTA { get; set; }

        [CampoTextoVariavel(Ordem = 3)]
        public string COD_CCUS { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? VL_CTA { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 1)]
        public string IND_DC { get; set; }
    }
}