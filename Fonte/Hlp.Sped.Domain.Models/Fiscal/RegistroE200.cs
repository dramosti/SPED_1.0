using Hlp.Sped.Infrastructure.Annotations;
using Hlp.Sped.Infrastructure.Registro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class RegistroE200 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "E200"; }
        }
        [CampoTextoNumerico(Ordem = 2, ComprimentoFixo = true, Tamanho = 2)]
        public string UF { get; set; }
        [CampoData(Ordem = 3)]
        public DateTime DT_INI { get; set; }
        [CampoData(Ordem = 4)]
        public DateTime DT_FIN { get; set; }
        //public override string CODIGO_ORDENACAO
        //{
        //    get { return "E200-" + this.GetNumeroControleRegistro(); }
        //}

        //public override string GetKeyValue()
        //{
        //    return this.UF;
        //}

        public override string CODIGO_ORDENACAO
        {
            get
            {
                return "E200-" + this.GetNumeroControleRegistro(); 
            }
        }

        public override string GetKeyValue()
        {
            return this.UF;
        }

    }
}
