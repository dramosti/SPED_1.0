﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroC120 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C120"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 1)]
        public string COD_DOC_IMP { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 10)]
        public string NUM_DOC_IMP { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? PIS_IMP { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal? COFINS_IMP { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 20)]
        public string NUM_ACDRAW { get; set; }
    }   
}
