using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Services.Interfaces.Contmatic;
using Ninject;
using Hlp.Sped.Repository.Interfaces.Contmatic;

namespace Hlp.Sped.Services.Implementation.Contmatic
{
    /// <summary>
    /// Classe dos blocos que começam com D
    /// </summary>
    class ConhecimentoTransporteService : IConhecimentoTransporteService
    {
        [Inject]
        public IConhecimentoTransporteRepository ConhecTranspRepository { get; set; }


        public IEnumerable<Domain.Models.Contmatic.RegistroD100> GetRegistroD100()
        {
            return ConhecTranspRepository.GetRegistroD100();
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroD101> GetRegistroD101()
        {
            return ConhecTranspRepository.GetRegistroD101();
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroD110> GetRegistroD110(string codChaveNotaFiscal)
        {
            return ConhecTranspRepository.GetRegistroD110(codChaveNotaFiscal);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroD120> GetRegistroD120(string codChaveNotaFiscal)
        {
            return ConhecTranspRepository.GetRegistroD120(codChaveNotaFiscal);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroD130> GetRegistroD130(string codChaveNotaFiscal)
        {
            return ConhecTranspRepository.GetRegistroD130(codChaveNotaFiscal);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroD190> GetRegistroD190(string codChaveNotaFiscal)
        {
            return ConhecTranspRepository.GetRegistroD190(codChaveNotaFiscal);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroD500> GetRegistroD500()
        {
            return ConhecTranspRepository.GetRegistroD500();
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroD510> GetRegistroD510(string codChaveNotaFiscal)
        {
            return ConhecTranspRepository.GetRegistroD510(codChaveNotaFiscal);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroD590> GetRegistroD590(string codChaveNotaFiscal)
        {
            return ConhecTranspRepository.GetRegistroD590(codChaveNotaFiscal);
        }
    }
}
