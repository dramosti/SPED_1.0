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
    public class BalancetesDiariosService : IBalancetesDiariosService
    {
        [Inject]
        public IBalancetesDiariosRepository BalancetesDiariosRepository { get; set; }

        public bool EfetuarProcessamentoBalancetesDiarios()
        {
            return BalancetesDiariosRepository.EfetuarProcessamentoBalancetesDiarios();
        }

        public IEnumerable<RegistroI300> GetRegistrosI300()
        {
            return BalancetesDiariosRepository.GetRegistrosI300();
        }

        public IEnumerable<RegistroI310> GetRegistrosI310(DateTime dataBalancete)
        {
            return BalancetesDiariosRepository.GetRegistrosI310(dataBalancete);
        }
    }
}
