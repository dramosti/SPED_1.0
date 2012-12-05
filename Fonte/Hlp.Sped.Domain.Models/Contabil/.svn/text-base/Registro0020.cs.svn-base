using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO 0020: Escrituração Contábil Descentralizada
    /// </summary>
    public class Registro0020 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "0020"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public int? IND_DEC { get; set; }

        [CampoTextoNumerico(Ordem = 3, Tamanho = 14)]
        public string CNPJ { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 2)]
        public string UF { get; set; }

        [CampoTextoVariavel(Ordem = 5)]
        public string IE { get; set; }

        [CampoTextoNumerico(Ordem = 6, Tamanho = 7)]
        public string COD_MUN { get; set; }

        [CampoTextoVariavel(Ordem = 7)]
        public string IM { get; set; }

        [CampoTextoNumerico(Ordem = 8, Tamanho = 11)]
        public string NIRE { get; set; }
    }
}