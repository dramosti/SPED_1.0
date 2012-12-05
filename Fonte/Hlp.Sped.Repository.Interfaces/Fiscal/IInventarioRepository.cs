using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Repository.Interfaces.Fiscal
{
    public interface IInventarioRepository
    {
        IEnumerable<RegistroH005> GetRegistrosH005();
        IEnumerable<RegistroH010> GetRegistrosH010(DateTime dataInventario);
    }
}
