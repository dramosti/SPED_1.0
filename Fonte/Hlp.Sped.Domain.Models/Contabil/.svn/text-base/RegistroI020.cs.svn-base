using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO I020: Campos Adicionais
    /// </summary>
    public class RegistroI020 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "I020"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 4)]
        public string REG_COD { get; set; }

        [CampoTextoNumerico(Ordem = 3)]
        public string NUM_AD { get; set; }

        [CampoTextoVariavel(Ordem = 4)]
        public string CAMPO { get; set; }

        [CampoTextoVariavel(Ordem = 5)]
        public string DESCRICAO { get; set; }

        [CampoTextoVariavel(Ordem = 6)]
        public string TIPO { get; set; }
    }
}