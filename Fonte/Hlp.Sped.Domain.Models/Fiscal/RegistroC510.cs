using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroC510 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C510"; }
        }//The column ALIQ_ST was not found on the IDataRecord being evaluated. This might indicate that the accessor was created with the wrong mappings.

        [CampoTextoNumerico(Ordem = 2, Tamanho = 3)]
        public int? NUM_ITEM { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 60)]
        public string COD_ITEM { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 4)]
        public string COD_CLASS { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 5)]
        public decimal? QTD { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 6)]
        public string UNID { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 2)]
        public decimal? VL_ITEM { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal? VL_DESC { get; set; }

        [CampoTextoNumerico(Ordem = 9, ComprimentoFixo = true, Tamanho = 3)]
        public string CST_ICMS { get; set; }

        [CampoTextoNumerico(Ordem = 10, ComprimentoFixo = true, Tamanho = 4)]
        public string CFOP { get; set; }

        [CampoDecimal(Ordem = 11, CasasDecimais = 2)]
        public decimal? VL_BC_ICMS { get; set; }

        [CampoDecimal(Ordem = 12, CasasDecimais = 2)]
        public decimal? ALIQ_ICMS { get; set; }

        [CampoDecimal(Ordem = 13, CasasDecimais = 2)]
        public decimal? VL_ICMS { get; set; }

        [CampoDecimal(Ordem = 14, CasasDecimais = 2)]
        public decimal? VL_BC_ICMS_ST { get; set; }

        [CampoDecimal(Ordem = 15, CasasDecimais = 2)]
        public decimal? ALIQ_ST { get; set; }

        [CampoDecimal(Ordem = 16, CasasDecimais = 2)]
        public decimal? VL_ICMS_ST { get; set; }

        [CampoTextoVariavel(Ordem = 17, Tamanho = 1)]
        public string IND_REC { get; set; }

        [CampoTextoVariavel(Ordem = 18, Tamanho = 60)]
        public string COD_PART { get; set; }

        [CampoDecimal(Ordem = 19, CasasDecimais = 2)]
        public decimal? VL_PIS { get; set; }

        [CampoDecimal(Ordem = 20, CasasDecimais = 2)]
        public decimal? VL_COFINS { get; set; }

        [CampoTextoVariavel(Ordem = 21)]
        public string COD_CTA { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C500-" + this.GetNumeroControleRegistro(); }
        }
    }
}