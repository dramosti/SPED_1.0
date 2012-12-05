using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroC470 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C470"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 60)]
        public string COD_ITEM { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 3)]
        public decimal? QTD { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 3)]
        public decimal? QTD_CANC { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 6)]
        public string UNID { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal? VL_ITEM { get; set; }

        [CampoTextoNumerico(Ordem = 7, Tamanho = 3)]
        public string CST_ICMS { get; set; }

        [CampoTextoNumerico(Ordem = 8, Tamanho = 4)]
        public string CFOP { get; set; }

        [CampoDecimal(Ordem = 9, CasasDecimais = 2)]
        public decimal? ALIQ_ICMS { get; set; }

        [CampoDecimal(Ordem = 10, CasasDecimais = 2)]
        public decimal? VL_PIS { get; set; }

        [CampoDecimal(Ordem = 11, CasasDecimais = 2)]
        public decimal? VL_COFINS { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C400-" + this.GetNumeroControleRegistro(); }
        }
    }
}