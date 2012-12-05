using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contabil;

namespace Hlp.Sped.Services.Interfaces.Contabil
{
    public interface IAberturaService
    {
        Registro0000 GetRegistro0000();
        Registro0001 GetRegistro0001();
        IEnumerable<Registro0007> GetRegistros0007();
        IEnumerable<Registro0020> GetRegistros0020();
        IEnumerable<Registro0150> GetRegistros0150();
        Registro0180 GetRegistro0180(string COD_PART);
    }
}
