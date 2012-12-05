using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroC380 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C380"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 2)]
        public string COD_MOD { get; set; }

        [CampoData(Ordem = 3)]
        public DateTime? DT_DOC_INI { get; set; }

        [CampoData(Ordem = 4)]
        public DateTime? DT_DOC_FIN { get; set; }

        [CampoTextoNumerico(Ordem = 8, Tamanho = 6)]
        public string NUM_DOC_INI { get; set; }

        [CampoTextoNumerico(Ordem = 8, Tamanho = 6)]
        public string NUM_DOC_FIN { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 2)]
        public decimal? VL_DOC { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal? VL_DOC_CANC { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C010-" + this.GetNumeroControleRegistro(); }
        }
    }
}