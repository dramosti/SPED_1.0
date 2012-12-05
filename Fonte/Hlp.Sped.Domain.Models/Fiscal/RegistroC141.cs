using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO C141: VENCIMENTO DA FATURA (CÓDIGO 01).
    /// Este registro deve ser apresentado, obrigatoriamente, sempre que for informado o registro C140, devendo ser
    /// discriminados o valor e a data de vencimento de cada uma das parcelas.
    /// Não podem ser informados dois ou mais registros com o mesmo conteúdo para o campo NUM_PARC.
    /// </summary>
    public class RegistroC141 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C141"; }
        }

        [CampoTextoNumerico(Ordem = 2, Tamanho = 1)]
        public int? NUM_PARC { get; set; }

        [CampoData(Ordem = 3)]
        public DateTime? DT_VCTO { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? VL_PARC { get; set; }
    }   
}
