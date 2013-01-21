using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contmatic;

namespace Hlp.Sped.Services.Interfaces.Contmatic
{
    public interface IParticipantesService
    {
        Registro0150 GetRegistro0150(string codigoParticipante);
    }
}
