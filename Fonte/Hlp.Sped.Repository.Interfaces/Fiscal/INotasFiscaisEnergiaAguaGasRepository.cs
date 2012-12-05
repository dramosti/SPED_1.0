using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Repository.Interfaces.Fiscal
{
    public interface INotasFiscaisEnergiaAguaGasRepository
    {
        IEnumerable<RegistroC500> GetRegistrosC500();
        IEnumerable<RegistroC510> GetRegistrosC510(string codChaveNotaFiscal);
        IEnumerable<RegistroC590> GetRegistrosC590(string codChaveNotaFiscal);
    }
}