using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO 9990: ENCERRAMENTO DO BLOCO 9
    /// Este registro destina-se a identificar o encerramento do Bloco 9 e a informar a quantidade de linhas (registros)
    /// existentes no bloco.
    /// </summary>
    public class Registro9990 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "9990"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public int? QTD_LIN_9 { get; set; }
    }   
}
