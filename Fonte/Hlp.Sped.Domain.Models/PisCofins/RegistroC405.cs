using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroC405 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C405"; }
        }

        [CampoData(Ordem = 2)]
        public DateTime? DT_DOC { get; set; }

        [CampoTextoNumerico(Ordem = 3, Tamanho = 3)]
        public string CRO { get; set; }

        [CampoTextoNumerico(Ordem = 4, Tamanho = 6)]
        public string CRZ { get; set; }

        [CampoTextoNumerico(Ordem = 5, Tamanho = 6)]
        public string NUM_COO_FIN { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal? GT_FIN { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 2)]
        public decimal? VL_BRT { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C010-" + this.GetNumeroControleRegistro(); }
        }
    }
}