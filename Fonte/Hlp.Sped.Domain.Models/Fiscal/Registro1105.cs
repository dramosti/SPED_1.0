using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class Registro1105 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "1105"; }
        }

        [CampoTextoNumerico(Ordem = 2, ComprimentoFixo = true, Tamanho = 2)]
        public string COD_MOD { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 3)]
        public string SERIE { get; set; }

        [CampoTextoNumerico(Ordem = 4, Tamanho = 9)]
        public string NUM_DOC { get; set; }

        [CampoTextoNumerico(Ordem = 5, ComprimentoFixo = true, Tamanho = 44)]
        public string CHV_NFE { get; set; }

        [CampoData(Ordem = 6)]
        public DateTime? DT_DOC { get; set; }

        [CampoTextoVariavel(Ordem = 7, Tamanho = 60)]
        public string COD_ITEM { get; set; }

        // Campo que não consta no arquivo, mas que serve de base para o
        // detalhamento de uma nota fiscal
        public string PK_NOTAFIS { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "1100-" + this.GetNumeroControleRegistro(); }
        }
    } 
}