using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO D990: ENCERRAMENTO DO BLOCO E.
    /// Este registro tem por objetivo identificar o encerramento do bloco E e informar a quantidade de linhas (registros)
    /// existentes no bloco.
    /// </summary>
    public class RegistroE990 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "E990"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public int? QTD_LIN_E { get; set; }
    }   
}
