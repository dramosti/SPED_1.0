using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Services.Interfaces.Fiscal
{
    public interface INotasFiscaisServComunicacaoService
    {
        IEnumerable<RegistroD500> GetRegistrosD500();
        IEnumerable<RegistroD590> GetRegistrosD590(string codChaveNotaFiscal);
    }
}