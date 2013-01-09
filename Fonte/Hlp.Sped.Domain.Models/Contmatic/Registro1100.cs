using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class Registro1100 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "1100"; }
        }

        [CampoTextoNumerico(Ordem = 2, Tamanho = 6)]
        public int PER_APU_CRED { get; set; }

        [CampoTextoNumerico(Ordem = 3, ComprimentoFixo = true, Tamanho = 2)]
        public int ORIG_CRED { get; set; }

        [CampoTextoNumerico(Ordem = 4, ComprimentoFixo = true, Tamanho = 14)]
        public int? CNPJ_SUC { get; set; }

        [CampoTextoNumerico(Ordem = 5, ComprimentoFixo = true, Tamanho = 3)]
        public int COD_CRED { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal VL_CRED_APU { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 2)]
        public decimal? VL_CRED_EXT_APU { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal VL_TOT_CRED_APU { get; set; }

        [CampoDecimal(Ordem = 9, CasasDecimais = 2)]
        public decimal VL_CRED_DESC_PA_ANT { get; set; }

        [CampoDecimal(Ordem = 10, CasasDecimais = 2)]
        public decimal? VL_CRED_PER_PA_ANT { get; set; }

        [CampoDecimal(Ordem = 11, CasasDecimais = 2)]
        public decimal? VL_CRED_DCOMP_PA_ANT { get; set; }

        [CampoDecimal(Ordem = 12, CasasDecimais = 2)]
        public decimal SD_CRED_DISP_EFD { get; set; }

        [CampoDecimal(Ordem = 13, CasasDecimais = 2)]
        public decimal? VL_CRED_DESC_EFD { get; set; }

        [CampoDecimal(Ordem = 14, CasasDecimais = 2)]
        public decimal? VL_CRED_PER_EFD { get; set; }

        [CampoDecimal(Ordem = 15, CasasDecimais = 2)]
        public decimal? VL_CRED_DCOMP_EFD { get; set; }

        [CampoDecimal(Ordem = 16, CasasDecimais = 2)]
        public decimal? VL_CRED_TRANS { get; set; }

        [CampoDecimal(Ordem = 17, CasasDecimais = 2)]
        public decimal? VL_CRED_OUT { get; set; }

        [CampoDecimal(Ordem = 18, CasasDecimais = 2)]
        public decimal SLD_CRED_FIM { get; set; }
        

    }
}
