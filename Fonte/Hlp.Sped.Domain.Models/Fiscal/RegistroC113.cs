using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO C113: DOCUMENTO FISCAL REFERENCIADO.
    /// Este registro tem por objetivo informar, detalhadamente, outros documentos fiscais que tenham sido mencionados
    /// nas informações complementares do documento que está sendo escriturado no registro C100, exceto cupons fiscais, que
    /// devem ser informados no registro C114. Exemplos: nota fiscal de remessa de mercadoria originária de venda para entrega
    /// futura e nota fiscal de devolução de compras
    /// Não podem ser informados, para um mesmo documento fiscal, dois ou mais registros com a mesma combinação
    /// de valores dos campos formadores da chave do registro. A chave deste registro é:
    /// ·  para documentos emitidos por terceiros: campos IND_EMIT, COD_PART, COD_MOD, SER e
    /// NUM_DOC.
    /// ·  para documentos de emissão própria: campos IND_EMIT, COD_MOD, SER e NUM_DOC.
    /// </summary>
    public class RegistroC113 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C113"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 1)]
        public string IND_OPER { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 1)]
        public string IND_EMIT { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 60)]
        public string COD_PART { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 2)]
        public string COD_MOD { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 4)]
        public string SER { get; set; }

        [CampoTextoNumerico(Ordem = 7, Tamanho = 3)]
        public int? SUB { get; set; }

        [CampoTextoNumerico(Ordem = 8, Tamanho = 9)]
        public int? NUM_DOC { get; set; }

        [CampoData(Ordem = 9)]
        public DateTime? DT_DOC { get; set; }
    }   
}
