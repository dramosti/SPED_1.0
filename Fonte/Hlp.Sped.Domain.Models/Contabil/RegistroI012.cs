using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I012: Livros Auxiliares ao Diário
    /// </summary>
    public class RegistroI012 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I012"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public string NUM_ORD { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 80)]
        public string NAT_LIVR { get; set; }

        [CampoTextoNumerico(Ordem = 4, Tamanho = 1)]
        public int? TIPO { get; set; }

        [CampoTextoVariavel(Ordem = 5)]
        public string COD_HASH_AUX { get; set; }
    }
}