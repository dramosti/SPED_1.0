using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroA170 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "A170"; }
        }

        [CampoTextoNumerico(Ordem = 2, Tamanho = 4)]
        public int? NUM_ITEM { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 60)]
        public string COD_ITEM { get; set; }

        [CampoTextoVariavel(Ordem = 4)]
        public string DESCR_COMPL { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal? VL_ITEM { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal? VL_DESC { get; set; }

        [CampoTextoVariavel(Ordem = 7, Tamanho = 2)]
        public string NAT_BC_CRED { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 1)]
        public string IND_ORIG_CRED { get; set; }

        [CampoTextoNumerico(Ordem = 9, ComprimentoFixo = true, Tamanho = 2)]
        public string CST_PIS { get; set; }

        [CampoDecimal(Ordem = 10, CasasDecimais = 2)]
        public decimal? VL_BC_PIS { get; set; }

        [CampoDecimal(Ordem = 11, CasasDecimais = 2)]
        public decimal? ALIQ_PIS { get; set; }

        [CampoDecimal(Ordem = 12, CasasDecimais = 2)]
        public decimal? VL_PIS { get; set; }

        [CampoTextoNumerico(Ordem = 13, ComprimentoFixo = true, Tamanho = 2)]
        public string CST_COFINS { get; set; }

        [CampoDecimal(Ordem = 14, CasasDecimais = 2)]
        public decimal? VL_BC_COFINS { get; set; }

        [CampoDecimal(Ordem = 15, CasasDecimais = 2)]
        public decimal? ALIQ_COFINS { get; set; }

        [CampoDecimal(Ordem = 16, CasasDecimais = 2)]
        public decimal? VL_COFINS { get; set; }

        [CampoTextoVariavel(Ordem = 17, Tamanho = 60)]
        public string COD_CTA { get; set; }

        [CampoTextoVariavel(Ordem = 18, Tamanho = 60)]
        public string COD_CCUS { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "A010-" + this.GetNumeroControleRegistro(); }
        }
    }
}