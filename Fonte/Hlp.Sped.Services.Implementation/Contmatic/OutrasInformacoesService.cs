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
    /// Classe dos blocos que começam com 1
    /// </summary>
  public  class OutrasInformacoesService : IOutrasInformacoesService
    {
        [Inject]
        public IOutrasInformacoesRepository OutrasInfoRepository { get; set; }


        public IEnumerable<Domain.Models.Contmatic.Registro1010> GetRegistros1010()
        {
            return OutrasInfoRepository.GetRegistro1010();
        }

        public IEnumerable<Domain.Models.Contmatic.Registro1100> GetRegistros1100()
        {
            return OutrasInfoRepository.GetRegistro1100();
        }

        public IEnumerable<Domain.Models.Contmatic.Registro1200> GetRegistros1200()
        {
            return OutrasInfoRepository.GetRegistro1200();
        }

        public IEnumerable<Domain.Models.Contmatic.Registro1600> GetRegistros1600()
        {
            return OutrasInfoRepository.GetRegistro1600();
        }
    }
}
