using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO 0005: DADOS COMPLEMENTARES DA ENTIDADE
    /// Registro obrigatório utilizado para complementar as informações de identificação do informante do arquivo.
    /// </summary>
    public class Registro0005 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0005"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 60)]
        public string FANTASIA { get; set; }

        [CampoTextoNumerico(Ordem = 3, ComprimentoFixo = true, Tamanho = 8)]
        public string CEP { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 60)]
        public string END { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 10)]
        public string NUM { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 60)]
        public string COMPL { get; set; }

        [CampoTextoVariavel(Ordem = 7, Tamanho = 60)]
        public string BAIRRO { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 10)]
        public string FONE { get; set; }

        [CampoTextoVariavel(Ordem = 9, Tamanho = 10)]
        public string FAX { get; set; }

        [CampoTextoVariavel(Ordem = 10)]
        public string EMAIL { get; set; }
    }
}