using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Services.Interfaces.PisCofins
{
    public interface IDemaisDocumentosOperacoesService
    {
        List<RegistroF010> GetRegistroF010();

        List<RegistroF600> GetRegistroF600();

        List<RegistroF200> GetRegistroF200();
    }
}
