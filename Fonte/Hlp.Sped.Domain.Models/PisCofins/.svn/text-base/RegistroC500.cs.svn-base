using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroC500 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C500"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 60)]
        public string COD_PART { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 2)]
        public string COD_MOD { get; set; }

        [CampoTextoNumerico(Ordem = 4, ComprimentoFixo = true, Tamanho = 2)]
        public int? COD_SIT { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 4)]
        public string SER { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 3)]
        public string SUB { get; set; }

        [CampoTextoNumerico(Ordem = 7, Tamanho = 9)]
        public string NUM_DOC { get; set; }

        [CampoData(Ordem = 8)]
        public DateTime? DT_DOC { get; set; }

        [CampoData(Ordem = 9)]
        public DateTime? DT_ENT { get; set; }

        [CampoDecimal(Ordem = 10, CasasDecimais = 2)]
        public decimal? VL_DOC { get; set; }

        [CampoDecimal(Ordem = 11, CasasDecimais = 2)]
        public decimal? VL_ICMS { get; set; }

        [CampoTextoVariavel(Ordem = 12, Tamanho = 6)]
        public string COD_INF { get; set; }

        [CampoDecimal(Ordem = 13, CasasDecimais = 2)]
        public decimal? VL_PIS { get; set; }

        [CampoDecimal(Ordem = 14, CasasDecimais = 2)]
        public decimal? VL_COFINS { get; set; }

        // Campo que não consta no arquivo, mas que serve de base para o
        // detalhamento de uma nota fiscal
        public string PK_NOTAFIS { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C010-" + this.GetNumeroControleRegistro(); }
        }

        public override string GetKeyValue()
        {
            return this.PK_NOTAFIS;
        }
    }
}