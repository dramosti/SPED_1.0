using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Repository.Interfaces.PisCofins
{
    public interface IParticipantesRepository
    {
        Registro0150 GetRegistro0150(string codigoParticipante);
    }
}