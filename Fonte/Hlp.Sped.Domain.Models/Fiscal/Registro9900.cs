using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO 9900: REGISTROS DO ARQUIVO.
    /// Todos os registros referenciados neste arquivo, inclusive os posteriores a este registro, devem ter uma linha
    /// totalizadora do seu número de ocorrências.
    /// </summary>
    public class Registro9900 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "9900"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 4)]
        public string REG_BLC { get; set; }

        [CampoTextoNumerico(Ordem = 3)]
        public int? QTD_REG_BLC { get; set; }

        public int? VL_ORDENACAO_BLOCO { get; set; }

        public override string GetKeyValue()
        {
            return
                this.VL_ORDENACAO_BLOCO + "|" +
                RegistroBase.GetValorOrdenacaoBloco(this.REG_BLC) + "|" +
                this.REG_BLC;
        }
    }
}
