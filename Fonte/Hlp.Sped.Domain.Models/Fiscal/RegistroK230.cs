using Hlp.Sped.Infrastructure.Annotations;
using Hlp.Sped.Infrastructure.Registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroK230 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "K230"; }
        }
        [CampoData(Ordem = 2)]
        public DateTime DT_INI_OP { get; set; }

        [CampoData(Ordem = 3)]
        public DateTime DT_FIN_OP { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 30)]
        public string COD_DOC_OP { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 60)]
        public string COD_ITEM { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 3)]
        public decimal QTD_ENC { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get
            {
                return "K230-" + this.GetNumeroControleRegistro();
            }
        }
    }
}
