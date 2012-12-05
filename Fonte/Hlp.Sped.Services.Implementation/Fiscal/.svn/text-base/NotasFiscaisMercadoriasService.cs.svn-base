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
    public class NotasFiscaisMercadoriasService : INotasFiscaisMercadoriasService
    {
        [Inject]
        public INotasFiscaisMercadoriasRepository NotasFiscaisMercadoriasRepository { get; set; }

        public IEnumerable<RegistroC100> GetRegistrosC100()
        {
            return NotasFiscaisMercadoriasRepository.GetRegistrosC100();
        }

        public IEnumerable<RegistroC170> GetRegistrosC170(string codChaveNotaFiscal)
        {
            return NotasFiscaisMercadoriasRepository.GetRegistrosC170(codChaveNotaFiscal);
        }

        public IEnumerable<RegistroC190> GetRegistrosC190(string codChaveNotaFiscal)
        {
            return NotasFiscaisMercadoriasRepository.GetRegistrosC190(codChaveNotaFiscal);
        }
    }
}
