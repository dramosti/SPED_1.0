using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Services.Interfaces.PisCofins
{
    public interface ICuponsFiscaisService
    {
        IEnumerable<RegistroC400> GetRegistrosC400(string codCNPJ);
        IEnumerable<RegistroC405> GetRegistrosC405(string codCNPJ, string codECF);
        IEnumerable<RegistroC481> GetRegistrosC481(string codCNPJ, string codECF, DateTime dtEmissao);
        IEnumerable<RegistroC485> GetRegistrosC485(string codCNPJ, string codECF, DateTime dtEmissao);
    }
}