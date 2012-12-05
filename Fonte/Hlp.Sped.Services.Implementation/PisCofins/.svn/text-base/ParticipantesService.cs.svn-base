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
    public class ParticipantesService : IParticipantesService
    {
        [Inject]
        public IParticipantesRepository ParticipantesRepository { get; set; }

        public Registro0150 GetRegistro0150(string codigoParticipante)
        {
            return ParticipantesRepository.GetRegistro0150(codigoParticipante);
        }
    }
}