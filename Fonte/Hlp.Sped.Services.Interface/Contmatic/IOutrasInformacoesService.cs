using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contmatic;

namespace Hlp.Sped.Services.Interfaces.Contmatic
{
    public interface IOutrasInformacoesService
    {
        IEnumerable<Registro1010> GetRegistros1010();
        IEnumerable<Registro1100> GetRegistros1100();
        IEnumerable<Registro1200> GetRegistros1200();
        IEnumerable<Registro1600> GetRegistros1600();
    }
}
