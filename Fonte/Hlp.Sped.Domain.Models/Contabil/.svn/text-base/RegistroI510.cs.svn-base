using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// I510 - Definição de campos do Livro Razão Auxiliar com Leiaute
    /// Parametrizável
    /// </summary>
    public class RegistroI510 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I510"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 16)]
        public string NM_CAMPO { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 50)]
        public string DESC_CAMPO { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 1)]
        public string TIPO_CAMPO { get; set; }

        [CampoTextoNumerico(Ordem = 5, Tamanho = 3)]
        public string TAM_CAMPO { get; set; }

        [CampoTextoNumerico(Ordem = 6, Tamanho = 2)]
        public string DEC_CAMPO { get; set; }

        [CampoTextoNumerico(Ordem = 7, Tamanho = 3)]
        public string COL_CAMPO { get; set; }
    }
}