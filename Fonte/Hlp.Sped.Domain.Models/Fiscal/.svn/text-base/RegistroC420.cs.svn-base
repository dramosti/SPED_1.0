using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroC420 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C420"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 7)]
        public string COD_TOT_PAR { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 2)]
        public decimal? VLR_ACUM_TOT { get; set; }

        [CampoTextoNumerico(Ordem = 4, Tamanho = 2)]
        public string NR_TOT { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 200)]
        public string DESCR_NR_TOT { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C400-" + this.GetNumeroControleRegistro(); }
        }
    }
}