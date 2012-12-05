using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO 0180: Identificação do Relacionamento com o Participante
    /// </summary>
    public class Registro0180 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "0180"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public int? COD_REL { get; set; }

        [CampoData(Ordem = 3)]
        public DateTime? DT_INI_REL { get; set; }

        [CampoData(Ordem = 4)]
        public DateTime? DT_FIN_REL { get; set; }
    }
}