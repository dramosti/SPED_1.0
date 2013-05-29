using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class Registro0500 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0500"; }
        }

        [CampoData(Ordem = 2)]
        public DateTime? DT_ALT { get; set; }

        [CampoTextoFixo(Ordem = 3)]
        public string COD_NAT_CC { get; set; }

        [CampoTextoFixo(Ordem = 4)]
        public string IND_CTA { get; set; }

        [CampoTextoNumerico(Ordem = 5, Tamanho = 5)]
        public decimal NIVEL { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 60)]
        public string COD_CTA { get; set; }

        [CampoTextoVariavel(Ordem = 7, Tamanho = 60)]
        public string NOME_CTA { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 60)]
        public string COD_CTA_REF { get; set; }

        [CampoTextoNumerico(Ordem = 9, Tamanho = 14)]
        public string CNPJ_EST { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "0140-" + this.GetNumeroControleRegistro(); }
        }
    }
}
