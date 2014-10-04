using Hlp.Sped.Infrastructure.Annotations;
using Hlp.Sped.Infrastructure.Registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroK200 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "K200"; }
        }

        [CampoData(Ordem = 2)]
        public DateTime? DT_EST { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 60)]
        public string COD_ITEM { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 3)]
        public decimal QTD { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 1)]
        public string IND_EST { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 60)]
        public string COD_PART { get; set; }

    }
}
