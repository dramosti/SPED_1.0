using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I030: Termo de Abertura do Livro
    /// </summary>
    public class RegistroI030 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I030"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 7)]
        public string DNRC_ABERT { get; set; }

        [CampoTextoNumerico(Ordem = 3)]
        public string NUM_ORD { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 80)]
        public string NAT_LIVR { get; set; }

        [CampoTextoNumerico(Ordem = 5)]
        public int? QTD_LIN { get; set; }

        [CampoTextoNumerico(Ordem = 6)]
        public string NOME { get; set; }

        [CampoTextoNumerico(Ordem = 7, Tamanho = 11)]
        public string NIRE { get; set; }

        [CampoTextoNumerico(Ordem = 8, Tamanho = 14)]
        public string CNPJ { get; set; }

        [CampoData(Ordem = 9)]
        public DateTime? DT_ARQ { get; set; }

        [CampoData(Ordem = 10)]
        public DateTime? DT_ARQ_CONV { get; set; }

        [CampoTextoVariavel(Ordem = 11)]
        public string DESC_MUN { get; set; }
    }
}