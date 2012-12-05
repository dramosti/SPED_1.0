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
    public class NotasFiscaisEnergiaAguaGasService : INotasFiscaisEnergiaAguaGasService
    {
        [Inject]
        public INotasFiscaisEnergiaAguaGasRepository NotasFiscaisEnergiaAguaGasRepository { get; set; }

        public IEnumerable<RegistroC500> GetRegistrosC500()
        {
            return NotasFiscaisEnergiaAguaGasRepository.GetRegistrosC500();
        }

        public IEnumerable<RegistroC510> GetRegistrosC510(string codChaveNotaFiscal)
        {
            return NotasFiscaisEnergiaAguaGasRepository.GetRegistrosC510(codChaveNotaFiscal);
        }

        public IEnumerable<RegistroC590> GetRegistrosC590(string codChaveNotaFiscal)
        {
            return NotasFiscaisEnergiaAguaGasRepository.GetRegistrosC590(codChaveNotaFiscal);
        }
    }
}