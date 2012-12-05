using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Services.Interfaces.PisCofins
{
    public interface IDocumentosFiscaisMercadoriasService
    {
        IEnumerable<RegistroC010> GetRegistrosC010();
    }
}