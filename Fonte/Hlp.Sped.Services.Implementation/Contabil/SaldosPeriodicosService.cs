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
    public class SaldosPeriodicosService : ISaldosPeriodicosService
    {
        [Inject]
        public ISaldosPeriodicosRepository SaldosPeriodicosRepository { get; set; }

        public RegistroI150 GetRegistroI150()
        {
            return SaldosPeriodicosRepository.GetRegistroI150();
        }

        public IEnumerable<RegistroI155> GetRegistrosI155()
        {
            return SaldosPeriodicosRepository.GetRegistrosI155();
        }
    }
}
