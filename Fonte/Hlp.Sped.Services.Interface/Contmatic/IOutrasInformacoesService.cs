using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contmatic;

namespace Hlp.Sped.Services.Interfaces.Contmatic
{
    public interface IOutrasInformacoesService
    {
        IEnumerable<Registro1010> GetRegistro1010();
        IEnumerable<Registro1100> GetRegistro1100();
        IEnumerable<Registro1200> GetRegistro1200();
        IEnumerable<Registro1600> GetRegistro1600();
    }
}
