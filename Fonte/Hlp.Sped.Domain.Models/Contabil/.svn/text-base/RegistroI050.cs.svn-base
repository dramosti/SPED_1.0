using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I050: Plano de Contas
    /// </summary>
    public class RegistroI050 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I050"; }
        }

        [CampoData(Ordem = 2)]
        public DateTime? DT_ALT { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 2)]
        public string COD_NAT { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 80)]
        public string IND_CTA { get; set; }

        [CampoTextoNumerico(Ordem = 5)]
        public int NIVEL { get; set; }

        [CampoTextoVariavel(Ordem = 6)]
        public string COD_CTA { get; set; }

        [CampoTextoVariavel(Ordem = 7)]
        public string COD_CTA_SUP { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 14)]
        public string CTA { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "I050-" + this.GetNumeroControleRegistro(); }
        }
    }
}