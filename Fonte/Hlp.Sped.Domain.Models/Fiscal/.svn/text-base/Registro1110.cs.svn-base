using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class Registro1110 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "1110"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 60)]
        public string COD_PART { get; set; }

        [CampoTextoNumerico(Ordem = 3, ComprimentoFixo = true, Tamanho = 2)]
        public string COD_MOD { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 4)]
        public string SER { get; set; }

        [CampoTextoNumerico(Ordem = 5, Tamanho = 9)]
        public string NUM_DOC { get; set; }

        [CampoData(Ordem = 6)]
        public DateTime? DT_DOC { get; set; }

        [CampoTextoNumerico(Ordem = 7, ComprimentoFixo = true, Tamanho = 44)]
        public string CHV_NFE { get; set; }

        [CampoTextoVariavel(Ordem = 8)]
        public string NR_MEMO { get; set; }

        [CampoDecimal(Ordem = 9, CasasDecimais = 3)]
        public decimal? QTD { get; set; }

        [CampoTextoVariavel(Ordem = 10, Tamanho = 6)]
        public string UNID { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "1100-" + this.GetNumeroControleRegistro(); }
        }
    }
}