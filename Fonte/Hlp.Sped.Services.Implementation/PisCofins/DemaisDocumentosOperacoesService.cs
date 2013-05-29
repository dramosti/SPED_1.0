using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Services.Interfaces.PisCofins;
using Ninject;
using Hlp.Sped.Repository.Interfaces.PisCofins;

namespace Hlp.Sped.Services.Implementation.PisCofins
{
    public class DemaisDocumentosOperacoesService : IDemaisDocumentosOperacoesService
    {
        [Inject]
        public IDemaisDocumentosOperacoesRepository demaisDocumentosOperacoesRepository { get; set; }

        public List<Domain.Models.PisCofins.RegistroF010> GetRegistroF010()
        {
            return demaisDocumentosOperacoesRepository.GetRegistroF010();
        }

        public List<Domain.Models.PisCofins.RegistroF600> GetRegistroF600(string codEmp)
        {
            return demaisDocumentosOperacoesRepository.GetRegistroF600(codEmp);
        }


        public List<Domain.Models.PisCofins.RegistroF200> GetRegistroF200(string codEmp)
        {
            return demaisDocumentosOperacoesRepository.GetRegistroF200(codEmp);
        }
    }
}
