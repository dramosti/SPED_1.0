using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO E111: AJUSTE/BENEFÍCIO/INCENTIVO DA APURAÇÃO DO ICMS.
    /// Este registro tem por objetivo discriminar todos os ajustes lançados nos campos VL_TOT_AJ_DEBITOS,
    /// VL_ESTORNOS_CRED, VL_TOT_AJ_CREDITOS, VL_ESTORNOS_DEB, VL_TOT_DED e DEB_ESP, todos do
    /// registro E110.
    /// </summary>
    public class RegistroE111 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "E111"; }
        }

        [CampoTextoNumerico(Ordem = 2, ComprimentoFixo = true, Tamanho = 8)]
        public string COD_AJ_APUR { get; set; }

        //[CampoTextoVariavel(Ordem = 3)]
       // public int? QTD_LIN_CDESCR_COMPL_AJ { get; set; }
        [CampoTextoVariavel(Ordem = 3, Tamanho = 25)] //mudado erick - sem OS
        public string DESCR_COMPL_AJ { get; set; }   //mudado erick - sem OS
       

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? VL_AJ_APUR { get; set; }
    }   
}
