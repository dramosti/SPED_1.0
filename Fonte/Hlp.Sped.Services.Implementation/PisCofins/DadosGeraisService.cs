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

        public Registro0100 GetRegistro0100()
        {
            return DadosGeraisRepository.GetRegistro0100();
        }

        public Registro0110 GetRegistro0110()
        {
            return DadosGeraisRepository.GetRegistro0110();
        }

        public IEnumerable<Registro0140> GetRegistro0140()
        {
            return DadosGeraisRepository.GetRegistro0140();
        }

        public IEnumerable<Registro0400> GetRegistro0400(string codEmp)
        {
            return DadosGeraisRepository.GetRegistro0400(codEmp);
        }

        public IEnumerable<Registro0500> GetRegistro0500(string codEmp)
        {
            return DadosGeraisRepository.GetRegistro0500(codEmp);
        }
    }
}