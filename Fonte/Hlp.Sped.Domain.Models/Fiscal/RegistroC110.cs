using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO C110: INFORMAÇÃO COMPLEMENTAR DA NOTA FISCAL (CÓDIGO 01, 1B, 04 e 55).
    /// Este registro tem por objetivo identificar os dados contidos no campo Informações Complementares da Nota
    /// Fiscal, que sejam de interesse do fisco, conforme dispõe a legislação. Devem ser discriminados em registros “filhos
    /// próprios” as informações relacionadas com documentos fiscais, processos, cupons fiscais, documentos de arrecadação e
    /// locais de entrega ou coleta que foram explicitamente citadas no campo “Informações Complementares” da Nota Fiscal.
    /// Não podem ser informados para um mesmo documento fiscal, dois ou mais registros com o mesmo conteúdo no
    /// campo COD_INF.
    /// </summary>
    public class RegistroC110 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C110"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 6)]
        public string COD_INF { get; set; }

        [CampoTextoVariavel(Ordem = 3)]
        public string TXT_COMPL { get; set; }
    }   
}
