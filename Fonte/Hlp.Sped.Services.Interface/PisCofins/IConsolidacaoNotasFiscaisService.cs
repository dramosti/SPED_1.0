using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Services.Interfaces.PisCofins
{
    public interface IConsolidacaoNotasFiscaisService
    {
        IEnumerable<RegistroC180> GetRegistrosC180(string codCNPJ, string codEmp);
        IEnumerable<RegistroC181> GetRegistrosC181(string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal, string codEmp);
        IEnumerable<RegistroC185> GetRegistrosC185(string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal, string codEmp);
        IEnumerable<RegistroC190> GetRegistrosC190(string codCNPJ, string codEmp);
        IEnumerable<RegistroC191> GetRegistrosC191(string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal, string codEmp);
        IEnumerable<RegistroC195> GetRegistrosC195(string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal, string codEmp);
        IEnumerable<RegistroC199> GetRegistrosC199(string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal, string codEmp);
        IEnumerable<RegistroC380> GetRegistrosC380(string codCNPJ, string codEmp);
        IEnumerable<RegistroC381> GetRegistrosC381(string codCNPJ, string codModeloFiscal, DateTime dtInicial, DateTime dtFinal, string codEmp);
        IEnumerable<RegistroC385> GetRegistrosC385(string codCNPJ, string codModeloFiscal, DateTime dtInicial, DateTime dtFinal, string codEmp);
    }
}