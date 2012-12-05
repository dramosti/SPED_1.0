using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Repository.Interfaces.Fiscal
{
    public interface IParticipantesRepository
    {
        Registro0150 GetRegistro0150(string codigoParticipante);
    }
}
