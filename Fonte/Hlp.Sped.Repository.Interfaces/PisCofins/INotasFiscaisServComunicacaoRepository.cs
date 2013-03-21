using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Repository.Interfaces.PisCofins
{
    public interface INotasFiscaisServComunicacaoRepository
    {
        IEnumerable<RegistroD010> GetRegistrosD010();
        IEnumerable<RegistroD500> GetRegistrosD500(string sCNPJ);
        IEnumerable<RegistroD501> GetRegistrosD501(string codChaveNotaFiscal);
        IEnumerable<RegistroD505> GetRegistrosD505(string codChaveNotaFiscal);
        IEnumerable<RegistroD100> GetRegistroD100();
        IEnumerable<RegistroD101> GetRegistrosD101(string PK_NOTAFIS);
        IEnumerable<RegistroD105> GetRegistrosD105(string PK_NOTAFIS);


        IEnumerable<RegistroD200> GetRegistroD200();
        IEnumerable<RegistroD201> GetRegistrosD201(string PK_NOTAFIS);
        IEnumerable<RegistroD205> GetRegistrosD205(string PK_NOTAFIS);
    }
}
