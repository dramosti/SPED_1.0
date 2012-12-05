using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO 0007 - Outras inscrições Cadastrais do Empresário ou
    /// Sociedade Empresária
    /// </summary>
    public class Registro0007 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "0007"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string COD_ENT_REF { get; set; }

        [CampoCodigo(Ordem = 3)]
        public string COD_INSCR { get; set; }
    }
}