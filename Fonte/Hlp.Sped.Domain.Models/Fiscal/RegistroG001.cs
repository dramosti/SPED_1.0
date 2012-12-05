using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO G001: ABERTURA DO BLOCO G
    /// DA ENTIDADE
    /// Este registro deve ser gerado para abertura do Bloco G e indica se há informações previstas para este bloco.
    /// </summary>
    public class RegistroG001 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "G001"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public string IND_MOV { get; set; }
    }
}
