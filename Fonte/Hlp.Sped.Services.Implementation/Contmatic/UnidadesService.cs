using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.Contmatic;
using Hlp.Sped.Repository.Interfaces.Contmatic;
using Hlp.Sped.Domain.Models.Contmatic;

namespace Hlp.Sped.Services.Implementation.Contmatic
{
    public class UnidadesService : IUnidadesService
    {
        [Inject]
        public IUnidadesRepository unidadesRepository { get; set; }

        public Registro0190 GetRegistro0190(string codigoUnidade)
        {
            return unidadesRepository.GetRegistro0190(codigoUnidade);
        }
    }
}