using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Repository.Interfaces.Fiscal
{
    public interface IUnidadesRepository
    {
        Registro0190 GetRegistro0190(string codigoUnidade);
    }
}
