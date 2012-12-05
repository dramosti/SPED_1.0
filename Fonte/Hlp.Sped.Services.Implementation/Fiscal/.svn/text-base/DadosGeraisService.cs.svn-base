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
    public class DadosGeraisService : IDadosGeraisService
    {
        [Inject]
        public IDadosGeraisRepository DadosGeraisRepository { get; set; }

        public Registro0000 GetRegistro0000()
        {
            return DadosGeraisRepository.GetRegistro0000();
        }

        public Registro0001 GetRegistro0001()
        {
            return DadosGeraisRepository.GetRegistro0001();
        }

        public Registro0005 GetRegistro0005()
        {
            return DadosGeraisRepository.GetRegistro0005();
        }

        public Registro0100 GetRegistro0100()
        {
            return DadosGeraisRepository.GetRegistro0100();
        }


        public IEnumerable<Registro0400> GetRegistro0400()
        {
            return DadosGeraisRepository.GetRegistro0400();
        }


        public IEnumerable<Registro0500> GetRegistro0500()
        {
            return DadosGeraisRepository.GetRegistro0500();
        }
    }
}
