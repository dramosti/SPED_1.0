using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO C990: ENCERRAMENTO DO BLOCO C
    /// Este registro destina-se a identificar o encerramento do bloco C e informar a quantidade de linhas (registros)
    /// existentes no bloco.
    /// </summary>
    public class RegistroC990 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "C990"; }
        }

        [CampoTextoNumerico(Ordem = 2)]
        public int? QTD_LIN_C { get; set; }
    }   
}
