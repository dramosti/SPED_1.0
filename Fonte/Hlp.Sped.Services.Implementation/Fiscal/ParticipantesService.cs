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
