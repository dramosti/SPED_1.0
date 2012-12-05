using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroH010 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "H010"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 60)]
        public string COD_ITEM { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 6)]
        public string UNID { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 3)]
        public decimal? QTD { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 6)]
        public decimal? VL_UNIT { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal? VL_ITEM { get; set; }

        [CampoTextoNumerico(Ordem = 7, Tamanho = 1)]
        public string IND_PROP { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 60)]
        public string COD_PART { get; set; }

        [CampoTextoVariavel(Ordem = 9)]
        public string TXT_COMPL { get; set; }

        [CampoTextoVariavel(Ordem = 10)]
        public string COD_CTA { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "H005-" + this.GetNumeroControleRegistro(); }
        }
    }
}