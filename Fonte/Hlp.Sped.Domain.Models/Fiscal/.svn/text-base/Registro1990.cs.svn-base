using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO 1990: ENCERRAMENTO DO BLOCO 1.
    /// Este registro tem por objetivo identificar o encerramento do bloco 1 e informar a quantidade de linhas (registros)
    /// existentes no bloco.
    /// </summary>
    public class Registro1990 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "1990"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public int? QTD_LIN_1 { get; set; }
    }   
}
