using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.Fiscal.Lorenzon;
using Hlp.Sped.Repository.Interfaces.Fiscal.Lorenzon;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Services.Implementation.Fiscal.Lorenzon
{
    public class ParticipantesLorenzonService : IParticipantesLorenzonService
    {
        [Inject]
        public IParticipantesLorenzonRepository ParticipantesRepository { get; set; }

        public IEnumerable<Registro0150> GetRegistros0150()
        {
            return ParticipantesRepository.GetRegistros0150();
        }
    }
}
