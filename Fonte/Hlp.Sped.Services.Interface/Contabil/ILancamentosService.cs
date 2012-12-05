using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contabil;

namespace Hlp.Sped.Services.Interfaces.Contabil
{
    public interface ILancamentosService
    {
        bool EfetuarProcessamentoLancamentosContabeis();
        RegistroI001 GetRegistroI001();
        RegistroI010 GetRegistroI010();
        IEnumerable<RegistroI200> GetRegistrosI200();
        IEnumerable<RegistroI250> GetRegistrosI250(string numeroLancamento);
    }
}
