using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO E100: PERÍODO DA APURAÇÃO DO ICMS.
    /// Este registro tem por objetivo informar o(s) período(s) de apuração do ICMS. Os períodos informados devem
    /// abranger todo o intervalo da escrituração fiscal, sem sobreposição ou omissão de datas ou períodos.
    /// Não podem ser informados dois ou mais registros com a mesma combinação de valores dos campos 02 (DT_INI),
    /// 03 (DT_FIN). Não devem existir lacunas ou sobreposições de datas nos períodos de apuração informados nestes registros,
    /// em comparação com as datas informadas no registro 0000.
    /// </summary>
    public class RegistroE100 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "E100"; }
        }

        [CampoData(Ordem = 2)]
        public DateTime? DT_INI { get; set; }

        [CampoData(Ordem = 3)]
        public DateTime? DT_FIN { get; set; }
    }   
}
