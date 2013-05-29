using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.PisCofins;
using Hlp.Sped.Repository.Interfaces.PisCofins;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Services.Implementation.PisCofins
{
    public class NotasFiscaisMercadoriasService : INotasFiscaisMercadoriasService
    {
        [Inject]
        public INotasFiscaisMercadoriasRepository NotasFiscaisMercadoriasRepository { get; set; }

        public IEnumerable<RegistroC100> GetRegistrosC100(string codCNPJ, string codEmp)
        {
            return NotasFiscaisMercadoriasRepository.GetRegistrosC100(codCNPJ, codEmp);
        }

        public IEnumerable<RegistroC120> GetRegistrosC120(string codChaveNotaFiscal, string codEmp)
        {
            return NotasFiscaisMercadoriasRepository.GetRegistrosC120(codChaveNotaFiscal, codEmp);
        }

        public IEnumerable<RegistroC170> GetRegistrosC170(string codChaveNotaFiscal, string codEmp)
        {
            return NotasFiscaisMercadoriasRepository.GetRegistrosC170(codChaveNotaFiscal, codEmp);
        }
    }
}