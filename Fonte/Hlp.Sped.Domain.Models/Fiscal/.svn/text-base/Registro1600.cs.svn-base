using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class Registro1600 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "1600"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 60)]
        public string COD_PART { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 2)]
        public decimal? TOT_CREDITO { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? TOT_DEBITO { get; set; }
    }
}
