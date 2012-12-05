using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO 0450: TABELA DE INFORMAÇÃO COMPLEMENTAR DO DOCUMENTO FISCAL
    /// Este registro tem por objetivo codificar todas as informações complementares dos documentos fiscais, exigidas
    /// pela legislação fiscal. Estas informações constam no campo “Dados Adicionais” dos documentos fiscais.
    /// Esta codificação e suas descrições são livremente criadas e mantidas pelo contribuinte e não podem ser informados
    /// dois ou mais registros com o mesmo conteúdo no campo COD_INF.
    /// Deverão constar todas as informações complementares de interesse do fisco existentes nos documentos fiscais.
    /// Exemplo: nos casos de documentos fiscais de entradas, informar as referências a um outro documento fiscal.
    /// </summary>
    public class Registro0450 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0450"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 6)]
        public string COD_INF { get; set; }

        [CampoTextoVariavel(Ordem = 3)]
        public string TXT { get; set; }
    }
}
