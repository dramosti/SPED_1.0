using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.PisCofins
{
    public class RegistroC010 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C010"; }
        }

        [CampoCodigo(Ordem = 2, Tamanho = 14)]
        public string CNPJ { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 1)]
        public string IND_ESCRI { get; set; }

        public string CD_EMP { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "C010-" + this.GetNumeroControleRegistro(); }
        }
    }
}