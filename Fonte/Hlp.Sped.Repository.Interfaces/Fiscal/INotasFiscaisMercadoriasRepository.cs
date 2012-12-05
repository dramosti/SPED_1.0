using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Repository.Interfaces.Fiscal
{
    public interface INotasFiscaisMercadoriasRepository
    {
        IEnumerable<RegistroC100> GetRegistrosC100();
        IEnumerable<RegistroC170> GetRegistrosC170(string codChaveNotaFiscal);
        IEnumerable<RegistroC190> GetRegistrosC190(string codChaveNotaFiscal);
    }
}
