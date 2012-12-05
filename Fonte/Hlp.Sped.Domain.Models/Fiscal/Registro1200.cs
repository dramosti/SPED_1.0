using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class Registro1200 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "1200"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 8)]
        public string COD_AJ_APUR { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 2)]
        public decimal? SLD_CRED { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? CRED_APR { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal? CRED_RECEB { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal? CRED_UTIL { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 2)]
        public decimal? SLD_CRED_FIM { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "1200-" + this.GetNumeroControleRegistro(); }
        }
    }
}