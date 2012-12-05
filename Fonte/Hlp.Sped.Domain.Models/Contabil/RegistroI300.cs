using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I300: Balancetes Diários - Identificação da Data
    /// </summary>
    public class RegistroI300 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I300"; }
        }

        [CampoData(Ordem = 2)]
        public DateTime DT_BCTE { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "I300-" + this.GetNumeroControleRegistro(); }
        }

        public override string GetKeyValue()
        {
            return this.DT_BCTE.ToString("yyyyMMdd");
        }
    }
}