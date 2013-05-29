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
        IEnumerable<RegistroD500> GetRegistrosD500(string sCNPJ, string codEmp);
        IEnumerable<RegistroD501> GetRegistrosD501(string codChaveNotaFiscal, string codEmp);
        IEnumerable<RegistroD505> GetRegistrosD505(string codChaveNotaFiscal, string codEmp);
        IEnumerable<RegistroD100> GetRegistroD100(string codEmp);
        IEnumerable<RegistroD101> GetRegistrosD101(string PK_NOTAFIS, string codEmp);
        IEnumerable<RegistroD105> GetRegistrosD105(string PK_NOTAFIS, string codEmp);
        IEnumerable<RegistroD200> GetRegistroD200(string codEmp);
        IEnumerable<RegistroD201> GetRegistrosD201(string PK_NOTAFIS, string codEmp);
        IEnumerable<RegistroD205> GetRegistrosD205(string PK_NOTAFIS, string codEmp);
    }
}
