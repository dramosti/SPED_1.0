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
    public class NotasFiscaisServicoService : INotasFiscaisServicoService
    {
        [Inject]
        public INotasFiscaisServicoRepository NotasFiscaisServicoRepository { get; set; }

        public IEnumerable<RegistroA010> GetRegistrosA010()
        {
            return NotasFiscaisServicoRepository.GetRegistrosA010();
        }

        public IEnumerable<RegistroA100> GetRegistrosA100(string codCNPJ, string codEmp)
        {
            return NotasFiscaisServicoRepository.GetRegistrosA100(codCNPJ, codEmp);
        }

        public IEnumerable<RegistroA170> GetRegistrosA170(string codChaveNotaFiscal, string codEmp)
        {
            return NotasFiscaisServicoRepository.GetRegistrosA170(codChaveNotaFiscal, codEmp);
        }
    }
}