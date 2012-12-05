using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Domain.Models.Fiscal;
using Hlp.Sped.Domain.Models.Fiscal.Lorenzon;
using Hlp.Sped.Services.Interfaces.Fiscal.Lorenzon;
using Hlp.Sped.Repository.Interfaces.Fiscal.Lorenzon;

namespace Hlp.Sped.Services.Implementation.Fiscal.Lorenzon
{
    public class InventarioLorenzonService : IInventarioLorenzonService
    {
        [Inject]
        public IInventarioLorenzonRepository InventarioRepository { get; set; }

        public IEnumerable<RegistroH005Lorenzon> GetRegistrosH005()
        {
            return InventarioRepository.GetRegistrosH005();
        }

        public IEnumerable<RegistroH010> GetRegistrosH010(DateTime dataInventario)
        {
            return InventarioRepository.GetRegistrosH010(dataInventario);
        }

        public IEnumerable<Registro0200> GetRegistros0200()
        {
            return InventarioRepository.GetRegistros0200();
        }
    }
}
