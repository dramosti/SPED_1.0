using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class Registro0000 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0000"; }
        }

        [CampoTextoNumerico(Ordem = 2, ComprimentoFixo = true, Tamanho = 3)]
        public string COD_VER { get; set; }

        [CampoTextoNumerico(Ordem = 3)]
        public string COD_FIN { get; set; }

        [CampoData(Ordem = 4)]
        public DateTime? DT_INI { get; set; }

        [CampoData(Ordem = 5)]
        public DateTime? DT_FIN { get; set; }


    }
}
