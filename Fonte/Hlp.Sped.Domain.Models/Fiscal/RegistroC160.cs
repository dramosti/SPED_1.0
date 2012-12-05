using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO C160: VOLUMES TRANSPORTADOS (CÓDIGO 01 E 04) - EXCETO
    /// COMBUSTÍVEIS.
    /// Este registro tem por objetivo informar detalhes dos volumes, do transportador e do veículo empregado no
    /// transporte nas operações de saídas.
    /// </summary>
    public class RegistroC160 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C160"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 60)]
        public string COD_PART { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 7)]
        public string VEIC_ID { get; set; }

        [CampoTextoNumerico(Ordem = 4)]
        public int? QTD_VOL { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal? PESO_BRT { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal? PESO_LIQ { get; set; }

        [CampoTextoVariavel(Ordem = 7, Tamanho = 2)]
        public string UF_ID { get; set; }
    }   
}
