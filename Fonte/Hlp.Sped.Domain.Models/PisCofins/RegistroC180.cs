using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroC180 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C180"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 2)]
        public string COD_MOD { get; set; }

        [CampoData(Ordem = 3)]
        public DateTime? DT_DOC_INI { get; set; }

        [CampoData(Ordem = 4)]
        public DateTime? DT_DOC_FIN { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 60)]
        public string COD_ITEM { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 8)]
        public string COD_NCM { get; set; }

        [CampoTextoVariavel(Ordem = 7, Tamanho = 3)]
        public string EX_IPI { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal? VL_TOT_ITEM { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C010-" + this.GetNumeroControleRegistro(); }
        }
    }
}