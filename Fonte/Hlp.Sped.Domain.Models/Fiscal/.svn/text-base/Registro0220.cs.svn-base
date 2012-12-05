using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO 0220: FATORES DE CONVERSÃO DE UNIDADES
    /// Este registro tem por objetivo informar os fatores de conversão dos itens discriminados na Tabela de Identificação
    /// do Item (Produtos e Serviços) entre a unidade informada no registro 0200 e as unidades informadas nos registros dos
    /// documentos fiscais.
    /// Quando for utilizada unidade de inventário diferente da unidade comercial do produto é necessário informar o
    /// registro 0220, fatores de conversão de unidades, para informar os fatores de conversão entre as unidades.
    /// Não podem ser informados dois ou mais registros com o mesmo conteúdo no campo UNID_CONV.
    /// </summary>
    public class Registro0220 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0220"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 6)]
        public string UNID_CONV { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 6)]
        public decimal? FAT_CONV { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "0200-" + this.GetNumeroControleRegistro(); }
        }
    }
}
