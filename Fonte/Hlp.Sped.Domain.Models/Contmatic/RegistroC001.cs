using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{

    /// <summary>
    /// REGISTRO C001: ABERTURA DO BLOCO C
    /// Este registro tem por objetivo identificar a abertura do bloco C, indicando se há informações sobre documentos
    /// fiscais.
    /// </summary>
    public class RegistroC001: RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C001"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 1)]
        public string IND_MOV { get; set; }
    }
}