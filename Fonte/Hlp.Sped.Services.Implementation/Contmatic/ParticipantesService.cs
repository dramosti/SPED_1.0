using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Repository.Interfaces.Contmatic;
using Hlp.Sped.Services.Interfaces.Contmatic;

namespace Hlp.Sped.Services.Implementation.Contmatic
{
    public class ParticipantesService : IParticipantesService
    {
        [Inject]
        public IParticipantesRepository participante { get; set; }

        public Domain.Models.Contmatic.Registro0150 GetRegistro0150(string codigoParticipante)
        {
            return participante.GetRegistro0150(codigoParticipante);
        }
    }
}
