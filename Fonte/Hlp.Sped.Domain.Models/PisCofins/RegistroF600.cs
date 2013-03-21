using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroF600 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "F600"; }
        }

        [CampoTextoNumerico(Ordem = 2, Tamanho = 2)]
        public string IND_NAT_RET { get; set; }

        [CampoData(Ordem = 3)]
        public DateTime DT_RET { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 4)]
        public decimal VL_BC_RET { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal VL_RET { get; set; }

        [CampoTextoNumerico(Ordem = 6, Tamanho = 4)]
        public string COD_REC { get; set; }

        [CampoTextoVariavel(Ordem = 7, Tamanho = 1)]
        public string IND_NAT_REC { get; set; }

        [CampoTextoNumerico(Ordem = 8, Tamanho = 14)]
        public string CNPJ { get; set; }

        [CampoDecimal(Ordem = 9, CasasDecimais = 4)]
        public decimal VL_RET_PIS { get; set; }

        [CampoDecimal(Ordem = 10, CasasDecimais = 4)]
        public decimal VL_RET_COFINS { get; set; }

        [CampoTextoNumerico(Ordem = 11)]
        public string IND_DEC { get; set; }

    }
}
