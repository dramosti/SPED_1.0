using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class RegistroC460 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C460"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 2)]
        public string COD_MOD { get; set; }

        [CampoTextoNumerico(Ordem = 3, Tamanho = 2)]
        public string COD_SIT { get; set; }

        [CampoTextoNumerico(Ordem = 4, Tamanho = 6)]
        public string NUM_DOC { get; set; }

        [CampoData(Ordem = 5)]
        public DateTime DT_DOC { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal VL_DOC { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 2)]
        public decimal? VL_PIS { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal? VL_COFINS { get; set; }

        [CampoTextoNumerico(Ordem = 9, Tamanho = 14)]
        public string CPF_CNPJ { get; set; }

        [CampoTextoVariavel(Ordem = 10, Tamanho = 60)]
        public string NOM_ADQ { get; set; }

        // Campo que não consta no arquivo, mas que serve para o
        // detalhamento de itens de um Cupom Fiscal
        public string PK_CUPOMFIS { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C405-" + this.GetNumeroControleRegistro(); }
        }
    }
}
