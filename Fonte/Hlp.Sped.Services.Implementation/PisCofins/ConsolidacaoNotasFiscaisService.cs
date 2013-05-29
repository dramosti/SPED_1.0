using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.PisCofins;
using Hlp.Sped.Repository.Interfaces.PisCofins;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Services.Implementation.PisCofins
{
    public class ConsolidacaoNotasFiscaisService : IConsolidacaoNotasFiscaisService
    {
        [Inject]
        public IConsolidacaoNotasFiscaisRepository ConsolidacaoNotasFiscaisRepository { get; set; }

        public IEnumerable<RegistroC180> GetRegistrosC180(string codCNPJ, string codEmp)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC180(codCNPJ, codEmp);
        }

        public IEnumerable<RegistroC181> GetRegistrosC181(string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal, string codEmp)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC181(
                codCNPJ, codItem, dtInicial, dtFinal, codEmp);
        }

        public IEnumerable<RegistroC185> GetRegistrosC185(string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal, string codEmp)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC185(
                codCNPJ, codItem, dtInicial, dtFinal, codEmp);
        }

        public IEnumerable<RegistroC190> GetRegistrosC190(string codCNPJ, string codEmp)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC190(codCNPJ, codEmp);
        }

        public IEnumerable<RegistroC191> GetRegistrosC191(string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal, string codEmp)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC191(
                codCNPJ, codItem, dtInicial, dtFinal, codEmp);
        }

        public IEnumerable<RegistroC195> GetRegistrosC195(string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal, string codEmp)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC195(
                codCNPJ, codItem, dtInicial, dtFinal, codEmp);
        }

        public IEnumerable<RegistroC199> GetRegistrosC199(string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal, string codEmp)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC199(
                codCNPJ, codItem, dtInicial, dtFinal, codEmp);
        }

        public IEnumerable<RegistroC380> GetRegistrosC380(string codCNPJ, string codEmp)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC380(codCNPJ, codEmp);
        }

        public IEnumerable<RegistroC381> GetRegistrosC381(string codCNPJ, string codModeloFiscal, DateTime dtInicial, DateTime dtFinal, string codEmp)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC381(
                codCNPJ, codModeloFiscal, dtInicial, dtFinal, codEmp);
        }

        public IEnumerable<RegistroC385> GetRegistrosC385(string codCNPJ, string codModeloFiscal, DateTime dtInicial, DateTime dtFinal, string codEmp)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC385(
                codCNPJ, codModeloFiscal, dtInicial, dtFinal, codEmp);
        }
    }
}