using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Services.Interfaces.Fiscal
{
    public interface IParticipantesService
    {
        Registro0150 GetRegistro0150(string codigoParticipante);
    }
}
