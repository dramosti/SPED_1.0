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
    public class UnidadesService : IUnidadesService
    {
        [Inject]
        public IUnidadesRepository UnidadesRepository { get; set; }

        public Registro0190 GetRegistro0190(string codigoUnidade)
        {
            return UnidadesRepository.GetRegistro0190(codigoUnidade);
        }
    }
}