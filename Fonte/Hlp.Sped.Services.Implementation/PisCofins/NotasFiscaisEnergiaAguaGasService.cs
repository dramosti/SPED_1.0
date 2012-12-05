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
    public class NotasFiscaisEnergiaAguaGasService : INotasFiscaisEnergiaAguaGasService
    {
        [Inject]
        public INotasFiscaisEnergiaAguaGasRepository NotasFiscaisEnergiaAguaGasRepository { get; set; }

        public IEnumerable<RegistroC500> GetRegistrosC500(string codCNPJ)
        {
            return NotasFiscaisEnergiaAguaGasRepository.GetRegistrosC500(codCNPJ);
        }

        public IEnumerable<RegistroC501> GetRegistrosC501(string codChaveNotaFiscal)
        {
            return NotasFiscaisEnergiaAguaGasRepository.GetRegistrosC501(codChaveNotaFiscal);
        }

        public IEnumerable<RegistroC505> GetRegistrosC505(string codChaveNotaFiscal)
        {
            return NotasFiscaisEnergiaAguaGasRepository.GetRegistrosC505(codChaveNotaFiscal);
        }
    }
}