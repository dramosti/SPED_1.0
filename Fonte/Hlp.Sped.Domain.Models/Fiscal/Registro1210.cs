using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class Registro1210 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "1210"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 4)]
        public string TIPO_UTIL { get; set; }

        [CampoTextoVariavel(Ordem = 3)]
        public string NR_DOC { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? VL_CRED_UTIL { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "1200-" + this.GetNumeroControleRegistro(); }
        }
    }
}
