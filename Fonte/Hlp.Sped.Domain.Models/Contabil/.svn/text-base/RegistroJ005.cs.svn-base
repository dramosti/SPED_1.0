using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO J005: Demonstrações Contábeis
    /// </summary>
    public class RegistroJ005 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "J005"; }
        }

        [CampoData(Ordem = 2)]
        public DateTime? DT_INI { get; set; }

        [CampoData(Ordem = 3)]
        public DateTime? DT_FIN { get; set; }

        [CampoTextoNumerico(Ordem = 4, Tamanho = 1)]
        public int? ID_DEM { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 65535)]
        public string CAB_DEM { get; set; }
    }
}