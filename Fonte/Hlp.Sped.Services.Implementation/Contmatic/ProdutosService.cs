using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.Contmatic;
using Hlp.Sped.Repository.Interfaces.Contmatic;
using Hlp.Sped.Domain.Models.Contmatic;

namespace Hlp.Sped.Services.Implementation.Contmatic
{
    public class ProdutosService : IProdutosService
    {
        [Inject]
        public IProdutosRepository produtosRepository { get; set; }

        public Registro0200 GetRegistro0200(string codigoProduto)
        {
            return produtosRepository.GetRegistro0200(codigoProduto);
        }


        public IEnumerable<Registro0220> GetRegistros0220(string codigoProduto)
        {
            return produtosRepository.GetRegistros0220(codigoProduto);
        }
    }
}