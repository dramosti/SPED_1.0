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
    public class ConhecimentoTransporteService : IConhecimentoTransporteService
    {
        [Inject]
        public IConhecimentoTransporteRepository ConhecTranspRepository { get; set; }


        public IEnumerable<Domain.Models.Contmatic.RegistroD100> GetRegistrosD100()
        {
            return ConhecTranspRepository.GetRegistroD100();
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroD101> GetRegistrosD101()
        {
            return ConhecTranspRepository.GetRegistroD101();
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroD110> GetRegistrosD110(string codChaveNotaFiscal)
        {
            return ConhecTranspRepository.GetRegistroD110(codChaveNotaFiscal);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroD120> GetRegistrosD120(string codChaveNotaFiscal)
        {
            return ConhecTranspRepository.GetRegistroD120(codChaveNotaFiscal);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroD130> GetRegistrosD130(string codChaveNotaFiscal)
        {
            return ConhecTranspRepository.GetRegistroD130(codChaveNotaFiscal);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroD190> GetRegistrosD190(string codChaveNotaFiscal)
        {
            return ConhecTranspRepository.GetRegistroD190(codChaveNotaFiscal);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroD500> GetRegistrosD500()
        {
            return ConhecTranspRepository.GetRegistroD500();
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroD510> GetRegistrosD510(string codChaveNotaFiscal)
        {
            return ConhecTranspRepository.GetRegistroD510(codChaveNotaFiscal);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroD590> GetRegistrosD590(string codChaveNotaFiscal)
        {
            return ConhecTranspRepository.GetRegistroD590(codChaveNotaFiscal);
        }


      
    }
}
