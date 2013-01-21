using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contmatic;

namespace Hlp.Sped.Services.Interfaces.Contmatic
{
    public interface INotasFiscaisServicoService
    {
        IEnumerable<RegistroA100> GetRegistrosA100();
        IEnumerable<RegistroA170> GetRegistrosA170(string codChaveNotaFiscal); // Vários por registro A100
    }
}
