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
    public class HistoricosContabeisService : IHistoricosContabeisService
    {
        [Inject]
        public IHistoricosContabeisRepository HistoricosContabeisRepository { get; set; }

        public RegistroI075 GetRegistroI075(string codigoHistorico)
        {
            return HistoricosContabeisRepository.GetRegistroI075(codigoHistorico);
        }
    }
}
