using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
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

        [CampoTextoNumerico(Ordem = 7, Tamanho = 2)]
        public string TIPO_ITEM { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 8)]
        public string COD_NCM { get; set; }

        [CampoTextoVariavel(Ordem = 9, Tamanho = 3)]
        public string EX_IPI { get; set; }

        [CampoTextoNumerico(Ordem = 10, ComprimentoFixo = true, Tamanho = 2)]
        public string COD_GEN { get; set; }

        [CampoTextoNumerico(Ordem = 11, Tamanho = 4)]
        public int? COD_LST { get; set; }

        [CampoDecimal(Ordem = 12, CasasDecimais = 2)]
        public decimal? ALIQ_ICMS { get; set; }

        public override string GetKeyValue()
        {
            return this.COD_ITEM;
        }

        public override string CODIGO_ORDENACAO
        {
            get { return "0140-" + this.GetNumeroControleRegistro(); }
        }
    }
}