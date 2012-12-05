using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Services.Interfaces.Fiscal
{
    public interface IProdutosService
    {
        Registro0200 GetRegistro0200(string codigoProduto);

        IEnumerable<Registro0220> GetRegistros0220(string codigoProduto);
    }
}
