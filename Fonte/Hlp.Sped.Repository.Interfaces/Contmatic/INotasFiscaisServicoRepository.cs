using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contmatic;

namespace Hlp.Sped.Repository.Interfaces.Contmatic
{
    public interface INotasFiscaisServicoRepository
    {
        IEnumerable<RegistroA100> GetRegistroA100(string codCNPJ);
        IEnumerable<RegistroA170> GetRegistroA170(string codChaveNotaFiscal); // Vários por registro A100
    }
}
