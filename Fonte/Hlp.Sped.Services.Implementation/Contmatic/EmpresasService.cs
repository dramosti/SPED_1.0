using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.Contmatic;
using Hlp.Sped.Repository.Interfaces.Contmatic;
using Hlp.Sped.Domain.Models;

namespace Hlp.Sped.Services.Implementation.Contmatic
{
    public class EmpresasService : IEmpresasService
    {
        [Inject]
        public IEmpresasRepository EmpresasRepository { get; set; }

        public IEnumerable<Empresa> ListAll()
        {
            return EmpresasRepository.ListAll();
        }
    }
}
