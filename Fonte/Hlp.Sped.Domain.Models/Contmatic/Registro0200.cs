using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class Registro0200 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "0200"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 60)]
        public string COD_ITEM { get; set; }

        [CampoTextoVariavel(Ordem = 3)]
        public string DESCR_ITEM { get; set; }

        [CampoTextoVariavel(Ordem = 4)]
        public string COD_BARRA { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 60)]
        public string COD_ANT_ITEM { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 6)]
        public string UNID_INV { get; set; }

        [CampoTextoNumerico(Ordem = 7, ComprimentoFixo = true, Tamanho = 2)]
        public string TIPO_ITEM { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 8)]
        public string COD_NCM { get; set; }

        [CampoTextoVariavel(Ordem = 9, Tamanho = 3)]
        public string EX_IPI { get; set; }

        [CampoTextoNumerico(Ordem = 10, ComprimentoFixo = true, Tamanho = 2)]
        public string COD_GEN { get; set; }

        [CampoTextoNumerico(Ordem = 11, Tamanho = 4)]
        public string COD_LST { get; set; }

        #region Campos opcionais
        [CampoDecimal(Ordem = 12, CasasDecimais = 2)]
        public decimal? ALIQ_ICMS { get; set; }

        [CampoTextoVariavel(Ordem = 13, Tamanho = 4)]
        public string COD_GRUPO { get; set; }

        [CampoTextoVariavel(Ordem = 14, Tamanho = 40)]
        public string DESC_GRUPO { get; set; }

        [CampoTextoNumerico(Ordem = 15, Tamanho = 4)]
        public string COD_SEFAZ { get; set; }

        [CampoTextoNumerico(Ordem = 16, Tamanho = 3)]
        public string CSOSN { get; set; }

        [CampoTextoNumerico(Ordem = 17, Tamanho = 3)]
        public string CST_ICMS { get; set; }

        [CampoDecimal(Ordem = 18, CasasDecimais = 2)]
        public decimal? PER_RED_BC_ICMS { get; set; }

        [CampoDecimal(Ordem = 19, CasasDecimais = 2)]
        public decimal? BC_ICMS_ST { get; set; }

        [CampoTextoNumerico(Ordem = 20, Tamanho = 2)]
        public string CST_IPI_ENTRADA { get; set; }

        [CampoTextoNumerico(Ordem = 21, Tamanho = 2)]
        public string CST_IPI_SAIDA { get; set; }

        [CampoDecimal(Ordem = 22, CasasDecimais = 2)]
        public decimal? ALIQ_IPI { get; set; }

        [CampoTextoNumerico(Ordem = 23, Tamanho = 2)]
        public string CST_PIS_ENTRADA { get; set; }

        [CampoTextoNumerico(Ordem = 24, Tamanho = 2)]
        public string CST_PIS_SAIDA { get; set; }

        [CampoTextoNumerico(Ordem = 25, Tamanho = 3)]
        public string NAT_REC_PIS { get; set; }

        [CampoDecimal(Ordem = 26, CasasDecimais = 2)]
        public decimal? ALIQ_PIS { get; set; }

        [CampoTextoNumerico(Ordem = 27, Tamanho = 2)]
        public string CST_COFINS_ENTRADA { get; set; }

        [CampoTextoNumerico(Ordem = 28, Tamanho = 2)]
        public string CST_COFINS_SAIDA { get; set; }

        [CampoTextoNumerico(Ordem = 29, Tamanho = 3)]
        public string NAT_REC_COFINS { get; set; }

        [CampoDecimal(Ordem = 30, CasasDecimais = 2)]
        public decimal? ALIQ_COFINS { get; set; }

        [CampoDecimal(Ordem = 31, CasasDecimais = 2)]
        public decimal? ALIQ_ISS { get; set; }

        [CampoTextoVariavel(Ordem = 32, Tamanho = 25)]
        public string CC { get; set; }

        [CampoTextoVariavel(Ordem = 33, Tamanho = 60)]
        public string OBSERVACAO { get; set; }

        #endregion


        public override string GetKeyValue()
        {
            return this.COD_ITEM;
        }

        public override string CODIGO_ORDENACAO
        {
            get { return "0200-" + this.GetNumeroControleRegistro(); }
        }
    }
}
