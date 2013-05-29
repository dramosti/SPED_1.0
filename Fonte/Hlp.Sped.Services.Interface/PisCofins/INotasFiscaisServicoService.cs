using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Services.Interfaces.PisCofins
{
    public interface INotasFiscaisServicoService
    {
        IEnumerable<RegistroA010> GetRegistrosA010();
        IEnumerable<RegistroA100> GetRegistrosA100(string codCNPJ, string codEmp);
        IEnumerable<RegistroA170> GetRegistrosA170(string codChaveNotaFiscal, string codEmp);
    }
}