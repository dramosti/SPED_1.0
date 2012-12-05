using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.Fiscal;
using Hlp.Sped.Repository.Interfaces.Fiscal;
using Hlp.Sped.Domain.Models;

namespace Hlp.Sped.Services.Implementation.Fiscal
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
