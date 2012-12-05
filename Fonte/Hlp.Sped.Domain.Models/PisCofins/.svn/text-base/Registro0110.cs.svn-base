using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class Registro0110 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0110"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 1)]
        public string COD_INC_TRIB { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 1)]
        public string IND_APRO_CRED { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 1)]
        public string COD_TIPO_CONT { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 1)] //descomentado os 27801 - erick - 25/07/2012 //comentado erick - os 27580 - este registro vale apenas para 1/7/2012
        public string IND_REG_CUM { get; set; } //descomentado os 27801 - erick - 25/07/2012
    }
}