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

        public IEnumerable<RegistroC180> GetRegistrosC180(string codCNPJ)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC180(codCNPJ);
        }

        public IEnumerable<RegistroC181> GetRegistrosC181(
            string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC181(
                codCNPJ, codItem, dtInicial, dtFinal);
        }

        public IEnumerable<RegistroC185> GetRegistrosC185(
            string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC185(
                codCNPJ, codItem, dtInicial, dtFinal);
        }

        public IEnumerable<RegistroC190> GetRegistrosC190(string codCNPJ)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC190(codCNPJ);
        }

        public IEnumerable<RegistroC191> GetRegistrosC191(
            string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC191(
                codCNPJ, codItem, dtInicial, dtFinal);
        }

        public IEnumerable<RegistroC195> GetRegistrosC195(
            string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC195(
                codCNPJ, codItem, dtInicial, dtFinal);
        }

        public IEnumerable<RegistroC199> GetRegistrosC199(
            string codCNPJ, string codItem, DateTime dtInicial, DateTime dtFinal)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC199(
                codCNPJ, codItem, dtInicial, dtFinal);
        }

        public IEnumerable<RegistroC380> GetRegistrosC380(string codCNPJ)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC380(codCNPJ);
        }

        public IEnumerable<RegistroC381> GetRegistrosC381(
            string codCNPJ, string codModeloFiscal, DateTime dtInicial, DateTime dtFinal)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC381(
                codCNPJ, codModeloFiscal, dtInicial, dtFinal);
        }

        public IEnumerable<RegistroC385> GetRegistrosC385(string codCNPJ, string codModeloFiscal, DateTime dtInicial, DateTime dtFinal)
        {
            return ConsolidacaoNotasFiscaisRepository.GetRegistrosC385(
                codCNPJ, codModeloFiscal, dtInicial, dtFinal);
        }
    }
}