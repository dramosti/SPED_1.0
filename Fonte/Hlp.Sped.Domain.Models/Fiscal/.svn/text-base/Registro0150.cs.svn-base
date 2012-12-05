using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO 0150: TABELA DE CADASTRO DO PARTICIPANTE
    /// Registro utilizado para informações cadastrais das pessoas físicas ou jurídicas envolvidas nas transações
    /// comerciais com o estabelecimento, no período. Participantes sem movimentação no período não devem ser informados
    /// neste registro.
    /// Obs.: Não devem ser informados como participantes os CNPJ e CPF apenas citados nos registros C350 e C460.
    /// O código a ser utilizado é de livre atribuição pelo contribuinte e possui validade apenas para o arquivo informado.
    /// Não podem ser informados dois ou mais registros com o mesmo Código de Participante.
    /// Para o caso de participante pessoa física com mais de um endereço, podem ser fornecidos mais de um registro,
    /// com o mesmo NOME e CPF. Neste caso, deve ser usado um COD_PART para cada registro, alterando os demais dados.
    /// As informações deste registro representam os dados atualizados no último dia da EFD.
    /// </summary>
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
    }
}