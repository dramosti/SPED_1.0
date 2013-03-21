using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroF200 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "F200"; }
        }
        [CampoTextoNumerico(Ordem = 2, Tamanho = 2)]
        public string IND_OPER { get; set; }

        [CampoTextoNumerico(Ordem = 3, Tamanho = 2)]
        public string UNID_IMOB { get; set; }

        [CampoTextoVariavel(Ordem = 4)]
        public string IDENT_EMP { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 90)]
        public string DESC_UNID_IMOB { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 90)]
        public string NUM_CONT { get; set; }

        [CampoTextoNumerico(Ordem = 7, Tamanho = 14)]
        public string CPF_CNPJ_ADQU { get; set; }

        [CampoData(Ordem = 8)]
        public DateTime DT_OPER { get; set; }

        [CampoDecimal(Ordem = 9, CasasDecimais = 2)]
        public decimal VL_TOT_VEND { get; set; }

        [CampoDecimal(Ordem = 10, CasasDecimais = 2)]
        public decimal VL_REC_ACUM { get; set; }

        [CampoDecimal(Ordem = 11, CasasDecimais = 2)]
        public decimal VL_TOT_REC { get; set; }

        [CampoTextoNumerico(Ordem = 12, Tamanho = 2)]
        public string CST_PIS { get; set; }

        [CampoDecimal(Ordem = 13, CasasDecimais = 2)]
        public decimal VL_BC_PIS { get; set; }

        [CampoDecimal(Ordem = 14, CasasDecimais = 4)]
        public decimal ALIQ_PIS { get; set; }

        [CampoDecimal(Ordem = 15, CasasDecimais = 2)]
        public decimal VL_PIS { get; set; }

        [CampoTextoNumerico(Ordem = 16, Tamanho = 2)]
        public string CST_COFINS { get; set; }

        [CampoDecimal(Ordem = 17, CasasDecimais = 2)]
        public decimal VL_BC_COFINS { get; set; }

        [CampoDecimal(Ordem = 18, CasasDecimais = 4)]
        public decimal ALIQ_COFINS { get; set; }

        [CampoDecimal(Ordem = 19, CasasDecimais = 2)]
        public decimal VL_COFINS { get; set; }

        [CampoDecimal(Ordem = 20, CasasDecimais = 2)]
        public decimal PERC_REC_RECEB { get; set; }

        [CampoTextoNumerico(Ordem = 21, Tamanho = 1)]
        public string IND_NAT_EMP { get; set; }

        [CampoTextoVariavel(Ordem = 22)]
        public string INF_COMP { get; set; }

        

    }
}
