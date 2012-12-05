using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroE116 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "E116"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 3)]
        public string COD_OR { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 2)]
        public decimal VL_OR { get; set; }

        [CampoData(Ordem = 4)]
        public DateTime DT_VCTO { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 15)]
        public string COD_REC { get; set; }

        [CampoTextoNumerico(Ordem = 6, Tamanho = 15)]
        public string NUM_PROC { get; set; }

        [CampoTextoNumerico(Ordem = 7, ComprimentoFixo = true, Tamanho = 1)]
        public string IND_PROC { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 15)]
        public string PROC { get; set; }

        [CampoTextoVariavel(Ordem = 9, Tamanho = 15)]
        public string TXT_COMPL { get; set; }

        [CampoTextoVariavel(Ordem = 10, Tamanho = 6)]
        public string MES_REF { get; set; }



    }
}
