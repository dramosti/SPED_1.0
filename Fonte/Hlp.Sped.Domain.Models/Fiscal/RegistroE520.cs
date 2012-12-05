using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO E520: APURAÇÃO DO IPI.
    /// Este registro deve ser preenchido para demonstração da apuração do IPI no período.
    /// </summary>
    public class RegistroE520 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "E520"; }
        }

        [CampoDecimal(Ordem = 2, CasasDecimais = 2)]
        public decimal? VL_SD_ANT_IPI { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 2)]
        public decimal? VL_DEB_IPI { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? VL_CRED_IPI { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal? VL_OD_IPI { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal? VL_OC_IPI { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 2)]
        public decimal? VL_SC_IPI { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal? VL_SD_IPI { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "E500-" + this.GetNumeroControleRegistro(); }
        }
    }   
}