using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
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
        public string TIPO_ESCRIT { get; set; }

        [CampoTextoNumerico(Ordem = 4)]
        public string IND_SIT_ESP { get; set; }  //erick OS. 27580 - 30/05/2012

        [CampoTextoVariavel(Ordem = 5, Tamanho = 41)]
        public string NUM_REC_ANTERIOR { get; set; }
        
        [CampoData(Ordem = 6)]
        public DateTime? DT_INI { get; set; }

        [CampoData(Ordem = 7)]
        public DateTime? DT_FIN { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 100)]
        public string NOME { get; set; }

        [CampoTextoNumerico(Ordem = 9, ComprimentoFixo = true, Tamanho = 14)]
        public string CNPJ { get; set; }

        [CampoTextoVariavel(Ordem = 10, Tamanho = 2)]
        public string UF { get; set; }

        [CampoTextoNumerico(Ordem = 11, ComprimentoFixo = true, Tamanho = 7)]
        public string COD_MUN { get; set; }

        [CampoTextoVariavel(Ordem = 12, Tamanho = 9)]
        public string SUFRAMA { get; set; }

        [CampoTextoNumerico(Ordem = 13)]
        public string IND_NAT_PJ { get; set; }

        [CampoTextoNumerico(Ordem = 14)]
        public string IND_ATIV { get; set; }
    }
}
