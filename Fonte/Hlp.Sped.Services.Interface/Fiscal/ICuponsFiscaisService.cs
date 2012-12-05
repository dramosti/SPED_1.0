using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Services.Interfaces.Fiscal
{
    public interface ICuponsFiscaisService
    {
        IEnumerable<RegistroC400> GetRegistrosC400();
        IEnumerable<RegistroC405> GetRegistrosC405(string codECF);
        RegistroC410 GetRegistroC410(string codECF, DateTime dtEmissao);
        IEnumerable<RegistroC420> GetRegistrosC420(string codECF, DateTime dtEmissao);
        IEnumerable<RegistroC425> GetRegistrosC425(string codECF, DateTime dtEmissao, string codTotalizador);
        IEnumerable<RegistroC460> GetRegistrosC460(string codECF, DateTime dtEmissao);
        IEnumerable<RegistroC470> GetRegistrosC470(string pkCupomFis);
        IEnumerable<RegistroC490> GetRegistrosC490(string codECF, DateTime dtEmissao);
    }
}
