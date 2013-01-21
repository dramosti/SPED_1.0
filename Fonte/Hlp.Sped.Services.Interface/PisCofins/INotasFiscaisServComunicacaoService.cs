using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Services.Interfaces.PisCofins
{
    public interface INotasFiscaisServComunicacaoService
    {
        IEnumerable<RegistroD010> GetRegistrosD010();
        IEnumerable<RegistroD500> GetRegistrosD500(string sCNPJ );
        IEnumerable<RegistroD501> GetRegistrosD501(string codChaveNotaFiscal);
        IEnumerable<RegistroD505> GetRegistrosD505(string codNR_SEQNF);
    }
}
