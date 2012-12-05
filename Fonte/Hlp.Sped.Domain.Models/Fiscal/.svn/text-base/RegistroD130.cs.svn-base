using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroD130 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "D130"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 60)]
        public string COD_PART_CONSG { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 60)]
        public string COD_PART_RED { get; set; }

        [CampoTextoNumerico(Ordem = 4, ComprimentoFixo = true, Tamanho = 7)]
        public string COD_MUN_ORIG { get; set; }

        [CampoTextoNumerico(Ordem = 5, ComprimentoFixo = true, Tamanho = 7)]
        public string COD_MUN_DEST { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 100)]
        public string OTM { get; set; }

        [CampoTextoNumerico(Ordem = 7, ComprimentoFixo = true, Tamanho = 1)]
        public string IND_NAT_FRT { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal? VL_LIQ_FRT { get; set; }

        [CampoDecimal(Ordem = 9, CasasDecimais = 2)]
        public decimal? VL_GRIS { get; set; }

        [CampoDecimal(Ordem = 10, CasasDecimais = 2)]
        public decimal? VL_PDG { get; set; }

        [CampoDecimal(Ordem = 11, CasasDecimais = 2)]
        public decimal? VL_OUT { get; set; }

        [CampoDecimal(Ordem = 12, CasasDecimais = 2)]
        public decimal? VL_FRT { get; set; }

        [CampoTextoVariavel(Ordem = 13, Tamanho = 7)]
        public string VEIC_ID { get; set; }

        [CampoTextoVariavel(Ordem = 14, Tamanho = 2)]
        public string UF_ID { get; set; }

        [CampoTextoVariavel(Ordem = 15, Tamanho = 6)]
        public override string CODIGO_ORDENACAO
        {
            get { return "D100-" + this.GetNumeroControleRegistro(); }
        }
    }
}