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
    public class ApuracaoServices : IApuracaoServices
    {
        [Inject]
        public IApuracaoRepository ApuracaoRepository { get; set; }

        public IEnumerable<RegistroE500> GetRegistrosE500()
        {
            return ApuracaoRepository.GetRegistrosE500();
        }

        public IEnumerable<RegistroE510> GetRegistrosE510(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal)
        {
            return ApuracaoRepository.GetRegistrosE510(dtPeriodoInicial, dtPeriodoFinal);
        }

        public RegistroE520 GetRegistroE520(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal)
        {
            return ApuracaoRepository.GetRegistroE520(dtPeriodoInicial, dtPeriodoFinal);
        }

        public IEnumerable<RegistroE530> GetRegistrosE530(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal)
        {
            return ApuracaoRepository.GetRegistrosE530(dtPeriodoInicial, dtPeriodoFinal);
        }
        public IEnumerable<RegistroE100> GetRegistrosE100()
        {
            return ApuracaoRepository.GetRegistrosE100();
        }

        public RegistroE110 GetRegistroE110(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal)
        {
            return ApuracaoRepository.GetRegistroE110(dtPeriodoInicial, dtPeriodoFinal);
        }

        public IEnumerable<RegistroE111> GetRegistrosE111(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal)
        {
            return ApuracaoRepository.GetRegistrosE111(dtPeriodoInicial, dtPeriodoFinal);
        }

        public IEnumerable<RegistroE116> GetRegistrosE116(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal)
        {
            return ApuracaoRepository.GetRegistrosE116(dtPeriodoInicial, dtPeriodoFinal);
        }


        public IEnumerable<RegistroE200> GetRegistrosE200()
        {
            return ApuracaoRepository.GetRegistrosE200();
        }

        public RegistroE210 GetRegistroE210(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal, string sUF)
        {
            return ApuracaoRepository.GetRegistroE210(dtPeriodoInicial, dtPeriodoFinal, sUF);
        }

        public IEnumerable<RegistroE250> GetRegistrosE250(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal, string sUF)
        {
            return ApuracaoRepository.GetRegistrosE250(dtPeriodoInicial, dtPeriodoFinal, sUF);
        }

    }
       
}