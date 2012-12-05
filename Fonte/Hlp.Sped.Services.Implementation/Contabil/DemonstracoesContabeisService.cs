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
    public class DemonstracoesContabeisService : IDemonstracoesContabeisService
    {
        [Inject]
        public IDemonstracoesContabeisRepository DemonstracoesContabeisRepository { get; set; }

        public RegistroJ001 GetRegistroJ001()
        {
            return DemonstracoesContabeisRepository.GetRegistroJ001();
        }

        public IEnumerable<RegistroJ930> GetRegistrosJ930()
        {
            return DemonstracoesContabeisRepository.GetRegistrosJ930();
        }
    }
}
