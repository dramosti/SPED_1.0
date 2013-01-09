using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class Registro1600 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "1600"; }
        }

        [CampoTextoNumerico(Ordem = 2, ComprimentoFixo = true, Tamanho = 6)]
        public int PER_APUR_ANT { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 2)]
        public string NAT_CONT_REC { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? VL_CONT_APUR { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal VL_CRED_COFINS_DESC { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal VL_CONT_DEV { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 2)]
        public decimal? VL_OUT_DED { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal VL_CONT_EXT { get; set; }

        [CampoDecimal(Ordem = 9, CasasDecimais = 2)]
        public decimal VL_MUL { get; set; }

        [CampoDecimal(Ordem = 10, CasasDecimais = 2)]
        public decimal? VL_JUR { get; set; }

        [CampoData(Ordem = 11)]
        public DateTime? DT_RECOL { get; set; }

        [CampoTextoNumerico(Ordem = 12, ComprimentoFixo = true, Tamanho = 4)]
        public int CFOP { get; set; }

        [CampoTextoNumerico(Ordem = 13, Tamanho = 9)]
        public int NUM_DOC { get; set; }

        [CampoTextoNumerico(Ordem = 14, ComprimentoFixo = true, Tamanho = 2)]
        public int COD_MOD { get; set; }

        [CampoTextoVariavel(Ordem = 15, Tamanho = 3)]
        public string SER { get; set; }

        [CampoTextoVariavel(Ordem = 16, Tamanho = 14)]
        public string CNPJ { get; set; }



    }
}
