using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroC100 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C100"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 1)]
        public string IND_OPER { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 1)]
        public string IND_EMIT { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 60)]
        public string COD_PART { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 2)]
        public string COD_MOD { get; set; }

        [CampoTextoNumerico(Ordem = 6, ComprimentoFixo = true, Tamanho = 2)]
        public int? COD_SIT { get; set; }

        [CampoTextoVariavel(Ordem = 7, Tamanho = 3)]
        public string SER { get; set; }

        [CampoTextoNumerico(Ordem = 8, Tamanho = 9)]
        public string NUM_DOC { get; set; }

        [CampoTextoNumerico(Ordem = 9, ComprimentoFixo = true, Tamanho = 44)]
        public string CHV_NFE { get; set; }

        [CampoData(Ordem = 10)]
        public DateTime? DT_DOC { get; set; }

        [CampoData(Ordem = 11)]
        public DateTime? DT_E_S { get; set; }

        [CampoDecimal(Ordem = 12, CasasDecimais = 2)]
        public decimal? VL_DOC { get; set; }

        [CampoTextoVariavel(Ordem = 13, Tamanho = 1)]
        public string IND_PGTO { get; set; }

        [CampoDecimal(Ordem = 14, CasasDecimais = 2)]
        public decimal? VL_DESC { get; set; }

        [CampoDecimal(Ordem = 15, CasasDecimais = 2)]
        public decimal? VL_ABAT_NT { get; set; }

        [CampoDecimal(Ordem = 16, CasasDecimais = 2)]
        public decimal? VL_MERC { get; set; }

        [CampoTextoNumerico(Ordem = 17, Tamanho = 1)]
        public int? IND_FRT { get; set; }

        [CampoDecimal(Ordem = 18, CasasDecimais = 2)]
        public decimal? VL_FRT { get; set; }

        [CampoDecimal(Ordem = 19, CasasDecimais = 2)]
        public decimal? VL_SEG { get; set; }

        [CampoDecimal(Ordem = 20, CasasDecimais = 2)]
        public decimal? VL_OUT_DA { get; set; }

        [CampoDecimal(Ordem = 21, CasasDecimais = 2)]
        public decimal? VL_BC_ICMS { get; set; }

        [CampoDecimal(Ordem = 22, CasasDecimais = 2)]
        public decimal? VL_ICMS { get; set; }

        [CampoDecimal(Ordem = 23, CasasDecimais = 2)]
        public decimal? VL_BC_ICMS_ST { get; set; }

        [CampoDecimal(Ordem = 24, CasasDecimais = 2)]
        public decimal? VL_ICMS_ST { get; set; }

        [CampoDecimal(Ordem = 25, CasasDecimais = 2)]
        public decimal? VL_IPI { get; set; }

        [CampoDecimal(Ordem = 26, CasasDecimais = 2)]
        public decimal? VL_PIS { get; set; }

        [CampoDecimal(Ordem = 27, CasasDecimais = 2)]
        public decimal? VL_COFINS { get; set; }

        [CampoDecimal(Ordem = 28, CasasDecimais = 2)]
        public decimal? VL_PIS_ST { get; set; }

        [CampoDecimal(Ordem = 29, CasasDecimais = 2)]
        public decimal? VL_COFINS_ST { get; set; }

        // Campo que não consta no arquivo, mas que serve de base para o
        // detalhamento de uma nota fiscal
        public string PK_NOTAFIS { get; set; }

        // Este campo também não consta no arquivo, porém serve de base para a checagem
        // se um documento que teve cancelamento, independentemente de seu tipo, possa ser identificado
        // durante a montagem do arquivo
        public string ST_DOC_CANCELADO { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C100-" + this.GetNumeroControleRegistro(); }
        }

        public override string GetKeyValue()
        {
            return this.PK_NOTAFIS;
        }
    }   
}