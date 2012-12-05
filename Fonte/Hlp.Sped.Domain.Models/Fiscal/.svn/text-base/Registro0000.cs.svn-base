using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO 0000: ABERTURA DO ARQUIVO DIGITAL E IDENTIFICAÇÃO
    /// DA ENTIDADE
    /// Registro obrigatório e corresponde ao primeiro registro do arquivo.
    /// </summary>
    public class Registro0000 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "0000"; }
        }

        [CampoTextoNumerico(Ordem = 2, ComprimentoFixo = true, Tamanho = 3)]
        public string COD_VER { get; set; }

        [CampoTextoNumerico(Ordem = 3)]
        public string COD_FIN { get; set; }

        [CampoData(Ordem = 4)]
        public DateTime? DT_INI { get; set; }

        [CampoData(Ordem = 5)]
        public DateTime? DT_FIN { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 100)]
        public string NOME { get; set; }

        [CampoTextoNumerico(Ordem = 7, ComprimentoFixo = true, Tamanho = 14)]
        public string CNPJ { get; set; }

        [CampoTextoNumerico(Ordem = 8, ComprimentoFixo = true, Tamanho = 11)]
        public string CPF { get; set; }

        [CampoTextoVariavel(Ordem = 9, Tamanho = 2)]
        public string UF { get; set; }

        [CampoCodigo(Ordem = 10, Tamanho = 14)]
        public string IE { get; set; }

        [CampoTextoNumerico(Ordem = 11, ComprimentoFixo = true, Tamanho = 7)]
        public string COD_MUN { get; set; }

        [CampoTextoVariavel(Ordem = 12)]
        public string IM { get; set; }

        [CampoTextoVariavel(Ordem = 13, Tamanho = 9)]
        public string SUFRAMA { get; set; }

        [CampoTextoVariavel(Ordem = 14, Tamanho = 1)]
        public string IND_PERFIL { get; set; }

        [CampoTextoNumerico(Ordem = 15)]
        public string IND_ATIV { get; set; }
    }
}