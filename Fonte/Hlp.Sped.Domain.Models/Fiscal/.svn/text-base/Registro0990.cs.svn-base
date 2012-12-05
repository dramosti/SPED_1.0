using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO 0990: ENCERRAMENTO DO BLOCO 0
    /// Este registro tem por objetivo identificar o encerramento do bloco 0 e informar a quantidade de linhas (registros)
    /// existentes no bloco.
    /// </summary>
    public class Registro0990 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0990"; }
        }

        [CampoTextoNumerico(Ordem = 2, Tamanho = 6)]
        public int? QTD_LIN_0 { get; set; }
    }
}
