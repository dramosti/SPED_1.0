using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class RegistroD110 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "D110"; }
        }

        [CampoTextoNumerico(Ordem = 2, Tamanho = 3)]
        public int NUM_ITEM { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 60)]
        public string COD_ITEM { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal VL_SERV { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal? VL_OUT { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "D100-" + this.GetNumeroControleRegistro(); }
        }
    }
}
