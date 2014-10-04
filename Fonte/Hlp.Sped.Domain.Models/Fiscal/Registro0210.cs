using Hlp.Sped.Infrastructure.Annotations;
using Hlp.Sped.Infrastructure.Registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class Registro0210 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0210"; }
        }
        
        [CampoTextoVariavel(Ordem = 2, Tamanho = 60)]
        public string COD_ITEM_COMP { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 6)]
        public decimal QTD_COMP { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal PERDA { get; set; }
        
    }
}
