using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO D001: ABERTURA DO BLOCO D
    /// Este registro deve ser gerado para abertura do Bloco D e indica se há informações sobre prestações ou
    /// contratações de serviços de comunicação, transporte interestadual e intermunicipal, com o devido suporte do
    /// correspondente documento fiscal.
    /// </summary>
    public class RegistroD001 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "D001"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 1)]
        public string IND_MOV { get; set; }
    }   
}
    