using Hlp.Sped.Infrastructure.Annotations;
using Hlp.Sped.Infrastructure.Registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroK250 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "K250"; }
        }

        [CampoData(Ordem = 2)]
        public DateTime DT_PROD { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 60)]
        public string COD_ITEM { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 3)]
        public decimal QTD { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get
            {
                return "K250-" + this.GetNumeroControleRegistro(); ;
            }
        }
    }
}
