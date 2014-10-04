using Hlp.Sped.Infrastructure.Annotations;
using Hlp.Sped.Infrastructure.Registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroK220 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "K220"; }
        }

        [CampoData(Ordem = 2)]
        public DateTime DT_MOV { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 60)]
        public string COD_ITEM_ORI { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 60)]
        public string COD_ITEM_DEST { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 3)]
        public decimal QTD { get; set; }

    }
}
