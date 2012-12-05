using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroE530 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "E530"; }
        }

        [CampoTextoNumerico(Ordem = 2, ComprimentoFixo = true, Tamanho = 1)]
        public string IND_AJ { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 2)]
        public decimal? VL_AJ { get; set; }

        [CampoTextoNumerico(Ordem = 4, ComprimentoFixo = true, Tamanho = 3)]
        public string COD_AJ { get; set; }

        [CampoTextoNumerico(Ordem = 5, ComprimentoFixo = true, Tamanho = 1)]
        public string IND_DOC { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 50)]
        public string NUM_DOC { get; set; }

        [CampoTextoVariavel(Ordem = 7, Tamanho = 500)]
        public string DESCR_AJ { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "E500-" + this.GetNumeroControleRegistro(); }
        }
    }
}