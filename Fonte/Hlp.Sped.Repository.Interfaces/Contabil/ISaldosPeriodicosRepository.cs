using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contabil;

namespace Hlp.Sped.Repository.Interfaces.Contabil
{
    public interface ISaldosPeriodicosRepository
    {
        RegistroI150 GetRegistroI150();
        IEnumerable<RegistroI155> GetRegistrosI155();
    }
}
