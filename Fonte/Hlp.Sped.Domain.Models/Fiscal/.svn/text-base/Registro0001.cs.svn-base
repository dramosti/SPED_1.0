using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO 0001: ABERTURA DO BLOCO 0
    /// DA ENTIDADE
    /// Este registro deve ser gerado para abertura do Bloco 0 e indica se há informações previstas para este bloco.
    /// </summary>
    public class Registro0001 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0001"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public string IND_MOV { get; set; }
    }
}
