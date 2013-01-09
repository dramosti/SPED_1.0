using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class Registro0220 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0220"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 6)]
        public string UNID_CONV { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 6)]
        public decimal FAT_CONV { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "0200-" + this.GetNumeroControleRegistro(); }
        }
    }
}
