using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class RegistroC400 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C400"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 2)]
        public string COD_MOD { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 20)]
        public string ECF_MOD { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 20)]
        public string ECF_FAB { get; set; }

        [CampoTextoNumerico(Ordem = 5, Tamanho = 3)]
        public int ECF_CX { get; set; }

        // Campo que não consta no arquivo, mas que serve de base para o
        // detalhamento de informações sobre ECFs e Cupons Fiscais
        public string PK_ECF { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C400-" + this.GetNumeroControleRegistro(); }
        }
    }
}
