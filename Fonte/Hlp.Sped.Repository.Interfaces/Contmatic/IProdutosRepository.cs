using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contmatic;

namespace Hlp.Sped.Repository.Interfaces.Contmatic
{
    public interface IProdutosRepository
    {
        Registro0200 GetRegistro0200(string codigoProduto);
        IEnumerable<Registro0220> GetRegistros0220(string codigoProduto);
    }
}
