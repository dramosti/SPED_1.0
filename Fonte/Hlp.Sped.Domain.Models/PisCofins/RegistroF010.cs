using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Annotations;
using Hlp.Sped.Infrastructure.Registro;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroF010 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "F010"; }
        }

        [CampoTextoNumerico(Ordem = 2, Tamanho = 14)]
        public string CNPJ { get; set; }

    }
}
