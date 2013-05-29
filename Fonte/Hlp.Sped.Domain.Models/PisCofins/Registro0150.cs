using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class Registro0150 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0150"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 60)]
        public string COD_PART { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 100)]
        public string NOME { get; set; }

        [CampoTextoNumerico(Ordem = 4, ComprimentoFixo = false, Tamanho = 5)]
        public string COD_PAIS { get; set; }

        [CampoTextoNumerico(Ordem = 5, ComprimentoFixo = true, Tamanho = 14)]
        public string CNPJ { get; set; }

        [CampoTextoNumerico(Ordem = 6, ComprimentoFixo = true, Tamanho = 11)]
        public string CPF { get; set; }

        [CampoTextoVariavel(Ordem = 7, Tamanho = 14)]
        public string IE { get; set; }

        [CampoTextoNumerico(Ordem = 8, ComprimentoFixo = true, Tamanho = 7)]
        public string COD_MUN { get; set; }

        [CampoTextoVariavel(Ordem = 9, Tamanho = 9)]
        public string SUFRAMA { get; set; }

        [CampoTextoVariavel(Ordem = 10, Tamanho = 60)]
        public string END { get; set; }

        [CampoTextoVariavel(Ordem = 11, Tamanho = 10)]
        public string NUM { get; set; }

        [CampoTextoVariavel(Ordem = 12, Tamanho = 60)]
        public string COMPL { get; set; }

        [CampoTextoVariavel(Ordem = 13, Tamanho = 60)]
        public string BAIRRO { get; set; }

        public override string GetKeyValue()
        {
            return this.COD_PART;
        }
        public override string CODIGO_ORDENACAO
        {
            get { return "0140-" + this.GetNumeroControleRegistro(); }
        }
    }
}