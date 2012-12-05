using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I555 - Totais no Livro Razão Auxiliar com Leiaute
    /// Parametrizável
    /// </summary>
    public class RegistroI555 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I555"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string RZ_CONT_TOT { get; set; }
    }
}