using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.Contabil;
using Hlp.Sped.Repository.Interfaces.Contabil;
using Hlp.Sped.Domain.Models.Contabil;

namespace Hlp.Sped.Services.Implementation.Contabil
{
    public class PlanoContasService : IPlanoContasService
    {
        [Inject]
        public IPlanoContasRepository PlanoContasRepository { get; set; }

        public IEnumerable<RegistroI050> GetRegistrosI050()
        {
            return ProcessarContasNivel(null, 1);
        }

        private List<RegistroI050> ProcessarContasNivel(string contaSuperiorInicial, int nivelAtualContas)
        {
            List<RegistroI050> resultado = new List<RegistroI050>();
            List<RegistroI050> contasFilhas;
            IEnumerable<RegistroI050> contasNivelAtual = PlanoContasRepository.GetRegistrosI050(
                contaSuperiorInicial, nivelAtualContas);

            foreach (RegistroI050 conta in contasNivelAtual)
            {
                resultado.Add(conta);
                contasFilhas = ProcessarContasNivel(conta.COD_CTA, conta.NIVEL + 1);
                if (contasFilhas.Count > 0)
                    resultado.AddRange(contasFilhas);
            }

            return resultado;
        }
    }
}
