using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contabil
{
    /// <summary>
    /// REGISTRO J930: Identificação dos Signatários da Escrituração
    /// </summary>
    public class RegistroJ930 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG 
        {
            get { return "J930"; }
        }

        [CampoTextoVariavel(Ordem = 2)]
        public string IDENT_NOM { get; set; }

        [CampoTextoNumerico(Ordem = 3, Tamanho = 11)]
        public string IDENT_CPF { get; set; }

        [CampoTextoVariavel(Ordem = 4)]
        public string IDENT_QUALIF { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 3)]
        public string COD_ASSIM { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 11)]
        public string IND_CRC { get; set; }
    }
}