using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroC199 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C199"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 1)]
        public string COD_DOC_IMP { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 10)]
        public string NUM_DOC_IMP { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? VL_PIS_IMP { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal? VL_COFINS_IMP { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 20)]
        public string NUM_ACDRAW { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C010-" + this.GetNumeroControleRegistro(); }
        }
    }
}