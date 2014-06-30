using Hlp.Sped.Infrastructure.Annotations;
using Hlp.Sped.Infrastructure.Registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroE210 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "E210"; }
        }
        [CampoTextoNumerico(Ordem = 2, ComprimentoFixo = true, Tamanho = 1)]
        public string IND_MOV_ST { get; set; }
        [CampoDecimal(Ordem = 3, CasasDecimais = 2)]
        public decimal VL_SLD_CRED_ANT_ST { get; set; }
        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal VL_DEVOL_ST { get; set; }
        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal VL_RESSARC_ST { get; set; }
        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal VL_OUT_CRED_ST { get; set; }
        [CampoDecimal(Ordem = 7, CasasDecimais = 2)]
        public decimal VL_AJ_CREDITOS_ST { get; set; }
        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal VL_RETENCAO_ST { get; set; }
        [CampoDecimal(Ordem = 9, CasasDecimais = 2)]
        public decimal VL_OUT_DEB_ST { get; set; }
        [CampoDecimal(Ordem = 10, CasasDecimais = 2)]
        public decimal VL_AJ_DEBITOS_ST { get; set; }
        [CampoDecimal(Ordem =11, CasasDecimais = 2)]
        public decimal VL_SLD_DEV_ANT_ST { get; set; }
        [CampoDecimal(Ordem = 12, CasasDecimais = 2)]
        public decimal VL_DEDUCOES_ST { get; set; }
        [CampoDecimal(Ordem = 13, CasasDecimais = 2)]
        public decimal VL_ICMS_RECOL_ST { get; set; }
        [CampoDecimal(Ordem = 14, CasasDecimais = 2)]
        public decimal VL_SLD_CRED_ST_TRANSPORTAR { get; set; }
        [CampoDecimal(Ordem = 15, CasasDecimais = 2)]
        public decimal DEB_ESP_ST { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "E200-" + this.GetNumeroControleRegistro(); }
        }
    }
}
