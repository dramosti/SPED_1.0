using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// BLOCO 0: ABERTURA, IDENTIFICAÇÃO E REFERÊNCIAS
    /// REGISTRO 0000: Abertura do Arquivo Digital e Identificação do 
    /// empresário ou da sociedade empresária
    /// </summary>
    public class Registro0000 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "0000"; }
        }

        [CampoTextoFixo(Ordem = 2)]
        public string LECD
        {
            get { return "LECD"; }
        }

        [CampoData(Ordem = 3)]
        public DateTime? DT_INI { get; set; }

        [CampoData(Ordem = 4)]
        public DateTime? DT_FIN { get; set; }

        [CampoTextoVariavel(Ordem = 5)]
        public string NOME { get; set; }

        [CampoTextoNumerico(Ordem = 6, Tamanho = 14)]
        public string CNPJ { get; set; }

        [CampoTextoVariavel(Ordem = 7, Tamanho = 2)]
        public string UF { get; set; }

        [CampoCodigo(Ordem = 8)]
        public string IE { get; set; }

        [CampoTextoNumerico(Ordem = 9, Tamanho = 7)]
        public string COD_MUN { get; set; }

        [CampoTextoVariavel(Ordem = 10)]
        public string IM { get; set; }

        [CampoTextoNumerico(Ordem = 11, Tamanho = 1)]
        public string IND_SIT_ESP { get; set; }
    }
}