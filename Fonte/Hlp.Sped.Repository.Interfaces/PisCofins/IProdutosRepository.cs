using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Repository.Interfaces.PisCofins
{
    public interface IProdutosRepository
    {
        Registro0200 GetRegistro0200(string codigoProduto, string codEmp);
    }
}