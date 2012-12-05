using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I350: Saldo das Contas de Resultado Antes do
    /// Encerramento - Identificação da Data
    /// </summary>
    public class RegistroI350 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I350"; }
        }

        [CampoData(Ordem = 2)]
        public string DT_RES { get; set; }
    }
}