using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.Fiscal;
using Hlp.Sped.Repository.Interfaces.Fiscal;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Services.Implementation.Fiscal
{
    public class ConhecimentoTransporteService : IConhecimentoTransporteService
    {
        [Inject]
        public IConhecimentoTransporteRepository ConhecimentoTransporteRepository { get; set; }

        public IEnumerable<RegistroD100> GetRegistrosD100()
        {
            return ConhecimentoTransporteRepository.GetRegistrosD100();
        }

        public IEnumerable<RegistroD110> GetRegistrosD110(string codChaveNotaFiscal)
        {
            return ConhecimentoTransporteRepository.GetRegistrosD110(codChaveNotaFiscal);
        }

        public IEnumerable<RegistroD120> GetRegistrosD120(string codChaveNotaFiscal)
        {
            return ConhecimentoTransporteRepository.GetRegistrosD120(codChaveNotaFiscal);
        }

        public IEnumerable<RegistroD130> GetRegistrosD130(string codChaveNotaFiscal)
        {
            return ConhecimentoTransporteRepository.GetRegistrosD130(codChaveNotaFiscal);
        }
        public IEnumerable<RegistroD190> GetRegistrosD190(string codChaveNotaFiscal)
        {
            return ConhecimentoTransporteRepository.GetRegistrosD190(codChaveNotaFiscal);
        }
    }
}