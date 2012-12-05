using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class Registro1710 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "1710"; }
        }

        [CampoTextoNumerico(Ordem = 2, Tamanho = 12)]
        public string NUM_DOC_INI { get; set; }

        [CampoTextoNumerico(Ordem = 3, Tamanho = 12)]
        public string NUM_DOC_FIN { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "1700-" + this.GetNumeroControleRegistro(); }
        }
    }
}