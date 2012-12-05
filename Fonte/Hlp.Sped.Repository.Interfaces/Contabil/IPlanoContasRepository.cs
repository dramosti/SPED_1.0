using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contabil;

namespace Hlp.Sped.Repository.Interfaces.Contabil
{
    public interface IPlanoContasRepository
    {
        IEnumerable<RegistroI050> GetRegistrosI050(string contaSuperior, int nivelContasFilhas);
    }
}
