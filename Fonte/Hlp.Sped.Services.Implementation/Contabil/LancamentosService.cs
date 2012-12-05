using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.Contabil;
using Hlp.Sped.Repository.Interfaces.Contabil;
using Hlp.Sped.Domain.Models.Contabil;
using Hlp.Sped.Infrastructure.Files;

namespace Hlp.Sped.Services.Implementation.Contabil
{
    public class LancamentosService : ILancamentosService
    {
        [Inject]
        public ILancamentosRepository LancamentoRepository { get; set; }

        public bool EfetuarProcessamentoLancamentosContabeis()
        {
            return LancamentoRepository.EfetuarProcessamentoLancamentosContabeis();
        }

        public RegistroI001 GetRegistroI001()
        {
            return LancamentoRepository.GetRegistroI001();
        }

        public RegistroI010 GetRegistroI010()
        {
            return LancamentoRepository.GetRegistroI010();
        }

        public IEnumerable<RegistroI200> GetRegistrosI200()
        {
            return LancamentoRepository.GetRegistrosI200();
        }

        public IEnumerable<RegistroI250> GetRegistrosI250(string numeroLancamento)
        {
            return LancamentoRepository.GetRegistrosI250(numeroLancamento);
        }
    }
}
