using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO G990: ENCERRAMENTO DO BLOCO G
    /// Este registro destina-se a identificar o encerramento do Bloco G e a informar a quantidade de linhas (registros)
    /// existentes no bloco.
    /// </summary>
    public class RegistroG990 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "G990"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public int? QTD_LIN_G { get; set; }
    }   
}
