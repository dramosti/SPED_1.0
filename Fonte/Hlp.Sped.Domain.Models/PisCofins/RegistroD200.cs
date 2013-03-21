using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroD200 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "D200"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 2)]
        public string COD_MOD { get; set; }

        [CampoTextoNumerico(Ordem = 3, Tamanho = 2)]
        public string COD_SIT { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 4)]
        public string SER { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 3)]
        public string SUB { get; set; }

        [CampoTextoNumerico(Ordem = 6, Tamanho = 9)]
        public string NUM_DOC_INI { get; set; }

        [CampoTextoNumerico(Ordem = 7, Tamanho = 9)]
        public string NUM_DOC_FIN { get; set; }

        [CampoTextoNumerico(Ordem = 8, Tamanho = 4)]
        public string CFOP { get; set; }

        [CampoData(Ordem = 9)]
        public DateTime DT_REF { get; set; }

        [CampoDecimal(Ordem = 10, CasasDecimais = 2)]
        public decimal VL_DOC { get; set; }

        [CampoDecimal(Ordem = 11, CasasDecimais = 2)]
        public decimal VL_DESC { get; set; }

        // Campo que não consta no arquivo, mas que serve de base para o
        // detalhamento de uma nota fiscal
        public string PK_NOTAFIS { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "D200-" + this.GetNumeroControleRegistro(); }
        }

        public override string GetKeyValue()
        {
            return this.PK_NOTAFIS;
        }


    }

}
