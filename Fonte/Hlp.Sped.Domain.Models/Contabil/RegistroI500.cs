using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// I500 - Parâmetros de Impressão e Visualização do Livro Razão Auxiliar
    /// com Leiaute Parametrizável
    /// </summary>
    public class RegistroI500 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I500"; }
        }

        [CampoTextoNumerico(Ordem = 2, Tamanho = 2)]
        public string TAM_FONTE { get; set; }
    }
}