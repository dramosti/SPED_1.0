using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroC500 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C500"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 1)]
        public string IND_OPER { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 1)]
        public string IND_EMIT { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 60)]
        public string COD_PART { get; set; }

        [CampoTextoNumerico(Ordem = 5, ComprimentoFixo = true, Tamanho = 2)]
        public string COD_MOD { get; set; }

        [CampoTextoNumerico(Ordem = 6, ComprimentoFixo = true, Tamanho = 2)]
        public string COD_SIT { get; set; }

        [CampoTextoVariavel(Ordem = 7, Tamanho = 4)]
        public string SER { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 3)]
        public string SUB { get; set; }

        [CampoTextoVariavel(Ordem = 9, Tamanho = 2)]
        public string COD_CONS { get; set; }

        [CampoTextoNumerico(Ordem = 10, Tamanho = 9)]
        public int? NUM_DOC { get; set; }

        [CampoData(Ordem = 11)]
        public DateTime? DT_DOC { get; set; }

        [CampoData(Ordem = 12)]
        public DateTime? DT_E_S { get; set; }

        [CampoDecimal(Ordem = 13, CasasDecimais = 2)]
        public decimal? VL_DOC { get; set; }

        [CampoDecimal(Ordem = 14, CasasDecimais = 2)]
        public decimal? VL_DESC { get; set; }

        [CampoDecimal(Ordem = 15, CasasDecimais = 2)]
        public decimal? VL_FORN { get; set; }

        [CampoDecimal(Ordem = 16, CasasDecimais = 2)]
        public decimal? VL_SERV_NT { get; set; }

        [CampoDecimal(Ordem = 17, CasasDecimais = 2)]
        public decimal? VL_TERC { get; set; }

        [CampoDecimal(Ordem = 18, CasasDecimais = 2)]
        public decimal? VL_DA { get; set; }

        [CampoDecimal(Ordem = 19, CasasDecimais = 2)]
        public decimal? VL_BC_ICMS { get; set; }

        [CampoDecimal(Ordem = 20, CasasDecimais = 2)]
        public decimal? VL_ICMS { get; set; }

        [CampoDecimal(Ordem = 21, CasasDecimais = 2)]
        public decimal? VL_BC_ICMS_ST { get; set; }

        [CampoDecimal(Ordem = 22, CasasDecimais = 2)]
        public decimal? VL_ICMS_ST { get; set; }

        [CampoTextoVariavel(Ordem = 23, Tamanho = 6)]
        public string COD_INF { get; set; }

        [CampoDecimal(Ordem = 24, CasasDecimais = 2)]
        public decimal? VL_PIS { get; set; }

        [CampoDecimal(Ordem = 25, CasasDecimais = 2)]
        public decimal? VL_COFINS { get; set; }

        [CampoTextoNumerico(Ordem = 26, ComprimentoFixo = true, Tamanho = 1)]
        public string TP_LIGACAO { get; set; }

        [CampoTextoVariavel(Ordem = 27, Tamanho = 2)]
        public string COD_GRUPO_TENSAO { get; set; }

        // Campo que não consta no arquivo, mas que serve de base para o
        // detalhamento de uma nota fiscal
        public string PK_NOTAFIS { get; set; }

        // Este campo também não consta no arquivo, porém serve de base para a checagem
        // se um documento que teve cancelamento, independentemente de seu tipo, possa ser identificado
        // durante a montagem do arquivo
        public string ST_DOC_CANCELADO { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C500-" + this.GetNumeroControleRegistro(); }
        }

        public override string GetKeyValue()
        {
            return this.PK_NOTAFIS;
        }
    }   
}