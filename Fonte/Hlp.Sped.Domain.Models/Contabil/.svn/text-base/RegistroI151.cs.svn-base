using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I151: Assinatura digital dos arquivos que contêm as 
    /// fichas de lançamento utilizados no período (in rfb 926/09)
    /// </summary>
    public class RegistroI151 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I151"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string ASSIM_DIG { get; set; }
    }
}