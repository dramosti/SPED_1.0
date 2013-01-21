using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroD010 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "D010"; }
        }

        [CampoCodigo(Ordem = 2, Tamanho = 14, ComprimentoFixo = false)]
        public string CNPJ { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "D010-" + this.GetNumeroControleRegistro(); }
        }
    }
}
