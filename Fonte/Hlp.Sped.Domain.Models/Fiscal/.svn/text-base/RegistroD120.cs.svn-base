using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroD120 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "D120"; }
        }

        [CampoTextoNumerico(Ordem = 2, ComprimentoFixo = true, Tamanho = 7)]
        public string COD_MUN_ORIG { get; set; }

        [CampoTextoNumerico(Ordem = 3, ComprimentoFixo = true, Tamanho = 7)]
        public string COD_MUN_DEST { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 7)]
        public string VEIC_ID { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 2)]
        public string UF_ID { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "D100-" + this.GetNumeroControleRegistro(); }
        }
    }
}