using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.PisCofins;
using Hlp.Sped.Repository.Interfaces.PisCofins;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Services.Implementation.PisCofins
{
    public class ProdutosService : IProdutosService
    {
        [Inject]
        public IProdutosRepository ProdutosRepository { get; set; }

        public Registro0200 GetRegistro0200(string codigoProduto)
        {
            return ProdutosRepository.GetRegistro0200(codigoProduto);
        }
    }
}