using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.Fiscal;
using Hlp.Sped.Repository.Interfaces.Fiscal;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Services.Implementation.Fiscal
{
    public class ProdutosService : IProdutosService
    {
        [Inject]
        public IProdutosRepository ProdutosRepository { get; set; }

        public Registro0200 GetRegistro0200(string codigoProduto)
        {
            return ProdutosRepository.GetRegistro0200(codigoProduto);
        }


        public IEnumerable<Registro0220> GetRegistros0220(string codigoProduto)
        {
            return ProdutosRepository.GetRegistros0220(codigoProduto);
        }
    }
}