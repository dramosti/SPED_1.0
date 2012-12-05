using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.Fiscal;
using Hlp.Sped.Repository.Interfaces.Fiscal;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Services.Implementation.Fiscal
{
    public class InventarioService : IInventarioService
    {
        [Inject]
        public IInventarioRepository InventarioRepository { get; set; }

        public IEnumerable<RegistroH005> GetRegistrosH005()
        {
            return InventarioRepository.GetRegistrosH005();
        }

        public IEnumerable<RegistroH010> GetRegistrosH010(DateTime dataInventario)
        {
            return InventarioRepository.GetRegistrosH010(dataInventario);
        }
    }
}
