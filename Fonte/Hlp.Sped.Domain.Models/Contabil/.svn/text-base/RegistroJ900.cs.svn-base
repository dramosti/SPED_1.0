using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO J900: Termo de Encerramento
    /// </summary>
    public class RegistroJ900 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "J900"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 21)]
        public string DNRC_ENCER { get; set; }

        [CampoTextoNumerico(Ordem = 3)]
        public string NUM_ORD { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 80)]
        public string NAT_LIVRO { get; set; }

        [CampoTextoVariavel(Ordem = 5)]
        public string NOME { get; set; }

        [CampoTextoNumerico(Ordem = 6)]
        public string QTD_LIN { get; set; }

        [CampoData(Ordem = 7)]
        public DateTime? DT_INI_ESCR { get; set; }

        [CampoData(Ordem = 8)]
        public DateTime? DT_FIN_ESCR { get; set; }
       }
}