using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO 0150: Tabela de Cadastro do Participante
    /// </summary>
    public class Registro0150 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "0150"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string COD_PART { get; set; }

        [CampoTextoVariavel(Ordem = 3)]
        public string eNOME { get; set; }

        [CampoTextoNumerico(Ordem = 4, Tamanho = 5)]
        public string COD_PAIS { get; set; }

        [CampoTextoNumerico(Ordem = 5, Tamanho = 14)]
        public string CNPJ { get; set; }

        [CampoTextoNumerico(Ordem = 6, Tamanho = 11)]
        public string CPF { get; set; }

        [CampoTextoNumerico(Ordem = 7, Tamanho = 11)]
        public string NIT { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 2)]
        public string UF { get; set; }

        [CampoTextoVariavel(Ordem = 9)]
        public string IE { get; set; }

        [CampoTextoVariavel(Ordem = 10)]
        public string IE_ST { get; set; }

        [CampoTextoNumerico(Ordem = 11, Tamanho = 7)]
        public string COD_MUN { get; set; }

        [CampoTextoVariavel(Ordem = 12)]
        public string IM { get; set; }

        [CampoTextoVariavel(Ordem = 13, Tamanho = 9)]
        public string SUFRAMA { get; set; }
    }
}