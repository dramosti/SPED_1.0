using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO C140: FATURA (CÓDIGO 01)
    /// Este registro tem por objetivo informar dados da fatura comercial, sempre que a aquisição ou venda de
    /// mercadorias for a prazo, através de notas fiscais modelo 1 ou 1A. Devem ser consideradas as informações quando da
    /// emissão do documento fiscal, incluindo a parcela paga no ato da operação, se for o caso.
    /// Nos casos onde uma única fatura diz respeito a diversas notas fiscais, para cada nota apresentada no C100, a fatura
    /// deve aqui ser informada, sempre com o seu valor original, sem nenhum rateio.
    /// Havendo mais de um tipo de título, informar o campo IND_TIT com o código ‘99’ (Outros). No campo
    /// DESC_TIT identificar cada um dos títulos, com números e valores. No campo VL_TIT informar o valor total da fatura.
    /// </summary>
    public class RegistroC140 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C140"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 1)]
        public string IND_EMIT { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 2)]
        public string IND_TIT { get; set; }

        [CampoTextoVariavel(Ordem = 4)]
        public string DESC_TIT { get; set; }

        [CampoTextoVariavel(Ordem = 5)]
        public string NUM_TIT { get; set; }

        [CampoTextoNumerico(Ordem = 6, Tamanho = 2)]
        public int? QTD_PARC { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 2)]
        public decimal? VL_TIT { get; set; }
    }   
}
