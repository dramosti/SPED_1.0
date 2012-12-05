using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Annotations.Base;

namespace Hlp.Sped.Infrastructure.Registro
{
    internal class CampoRegistro
    {
        public string Nome { get; set; }

        public TipoCampoAttribute TipoCampo { get; set; }
    }
}