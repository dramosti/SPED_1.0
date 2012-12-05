using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Services.Interfaces.PisCofins
{
    public interface INotasFiscaisEnergiaAguaGasService
    {
        IEnumerable<RegistroC500> GetRegistrosC500(string codCNPJ);
        IEnumerable<RegistroC501> GetRegistrosC501(string codChaveNotaFiscal);
        IEnumerable<RegistroC505> GetRegistrosC505(string codChaveNotaFiscal);
    }
}