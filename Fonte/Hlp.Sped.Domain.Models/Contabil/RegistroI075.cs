using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I075: Tabela de Histórico Padronizado
    /// </summary>
    public class RegistroI075 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I075"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string COD_HIST { get; set; }

        [CampoTextoVariavel(Ordem = 3)]
        public string DESCR_HIST { get; set; }

        public override string GetKeyValue()
        {
            return this.COD_HIST;
        }
    }
}