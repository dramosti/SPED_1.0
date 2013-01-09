using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class Registro0190 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0190"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 6)]
        public string UNID { get; set; }

        [CampoTextoVariavel(Ordem = 3)]
        public string DESCR { get; set; }

        public override string GetKeyValue()
        {
            return this.UNID;
        }
    }
}
