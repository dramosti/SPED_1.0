using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contmatic;

namespace Hlp.Sped.Services.Interfaces.Contmatic
{
    /// <summary>
    /// Classe de Registro de cadastro
    /// </summary>
    public interface IDadosGeraisService
    {
        Registro0000 GetRegistro0000();
    }
}
