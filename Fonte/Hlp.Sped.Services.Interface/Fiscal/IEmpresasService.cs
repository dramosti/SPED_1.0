using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models;

namespace Hlp.Sped.Services.Interfaces.Fiscal
{
    public interface IEmpresasService
    {
        IEnumerable<Empresa> ListAll();
    }
}
