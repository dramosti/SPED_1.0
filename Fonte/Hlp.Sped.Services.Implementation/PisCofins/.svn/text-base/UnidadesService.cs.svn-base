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