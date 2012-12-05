using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I550 - Detalhes do Livro Razão Auxiliar com Leiaute
    /// Parametrizável 
    /// </summary>
    public class RegistroI550: RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I550"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string RZ_CONT { get; set; }
    }
}