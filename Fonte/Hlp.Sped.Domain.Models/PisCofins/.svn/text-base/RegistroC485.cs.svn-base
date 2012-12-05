using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroC485 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C485"; }
        }

        [CampoTextoNumerico(Ordem = 2, ComprimentoFixo = true, Tamanho = 2)]
        public string CST_COFINS { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 2)]
        public decimal? VL_ITEM { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? VL_BC_COFINS { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 4)]
        public decimal? ALIQ_COFINS { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 3)]
        public decimal? QUANT_BC_COFINS { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 4)]
        public decimal? ALIQ_COFINS_QUANT { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal? VL_COFINS { get; set; }

        [CampoTextoVariavel(Ordem = 9, Tamanho = 60)]
        public string COD_ITEM { get; set; }
        
        [CampoTextoVariavel(Ordem = 10, Tamanho = 60)]
        public string COD_CTA { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C010-" + this.GetNumeroControleRegistro(); }
        }
    }
}