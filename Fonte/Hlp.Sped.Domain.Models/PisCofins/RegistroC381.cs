using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroC381 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C381"; }
        }

        [CampoTextoNumerico(Ordem = 2, ComprimentoFixo = true, Tamanho = 2)]
        public string CST_PIS { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 60)]
        public string COD_ITEM { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? VL_ITEM { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal? VL_BC_PIS { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 4)]
        public decimal? ALIQ_PIS { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 3)]
        public decimal? QUANT_BC_PIS { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 4)]
        public decimal? ALIQ_PIS_QUANT { get; set; }

        [CampoDecimal(Ordem = 9, CasasDecimais = 2)]
        public decimal? VL_PIS { get; set; }

        [CampoTextoVariavel(Ordem = 10, Tamanho = 60)]
        public string COD_CTA { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C010-" + this.GetNumeroControleRegistro(); }
        }
    }
}