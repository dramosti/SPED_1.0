using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroA100 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "A100"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 1)]
        public string IND_OPER { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 1)]
        public string IND_EMIT { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 60)]
        public string COD_PART { get; set; }

        [CampoTextoNumerico(Ordem = 5, ComprimentoFixo = true, Tamanho = 2)]
        public int? COD_SIT { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 20)]
        public string SER { get; set; }

        [CampoTextoVariavel(Ordem = 7, Tamanho = 20)]
        public string SUB { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 60)]
        public string NUM_DOC { get; set; }

        [CampoTextoVariavel(Ordem = 9, Tamanho = 60)]
        public string CHV_NFSE { get; set; }

        [CampoData(Ordem = 10)]
        public DateTime? DT_DOC { get; set; }

        [CampoData(Ordem = 11)]
        public DateTime? DT_EXE_SERV { get; set; }

        [CampoDecimal(Ordem = 12, CasasDecimais = 2)]
        public decimal? VL_DOC { get; set; }

        [CampoTextoVariavel(Ordem = 13, Tamanho = 1)]
        public string IND_PGTO { get; set; }

        [CampoDecimal(Ordem = 14, CasasDecimais = 2)]
        public decimal? VL_DESC { get; set; }

        [CampoDecimal(Ordem = 15, CasasDecimais = 2)]
        public decimal? VL_BC_PIS { get; set; }

        [CampoDecimal(Ordem = 16, CasasDecimais = 2)]
        public decimal? VL_PIS { get; set; }

        [CampoDecimal(Ordem = 17, CasasDecimais = 2)]
        public decimal? VL_BC_COFINS { get; set; }

        [CampoDecimal(Ordem = 18, CasasDecimais = 2)]
        public decimal? VL_COFINS { get; set; }

        [CampoDecimal(Ordem = 19, CasasDecimais = 2)]
        public decimal? VL_PIS_RET { get; set; }

        [CampoDecimal(Ordem = 20, CasasDecimais = 2)]
        public decimal? VL_COFINS_RET { get; set; }

        [CampoDecimal(Ordem = 21, CasasDecimais = 2)]
        public decimal? VL_ISS { get; set; }

        // Campo que não consta no arquivo, mas que serve de base para o
        // detalhamento de uma nota fiscal
        public string PK_NOTAFIS { get; set; }

        // Este campo também não consta no arquivo, porém serve de base para a checagem
        // se um documento que teve cancelamento, independentemente de seu tipo, possa ser identificado
        // durante a montagem do arquivo
        public string ST_DOC_CANCELADO { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "A010-" + this.GetNumeroControleRegistro(); }
        }
    }
}