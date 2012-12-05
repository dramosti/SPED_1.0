using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contabil;

namespace Hlp.Sped.Services.Interfaces.Contabil
{
    public interface ISaldosPeriodicosService
    {
        RegistroI150 GetRegistroI150();
        IEnumerable<RegistroI155> GetRegistrosI155();
    }
}
