using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Services.Interfaces.Contmatic;
using Ninject;
using Hlp.Sped.Repository.Interfaces.Contmatic;

namespace Hlp.Sped.Services.Implementation.Contmatic
{
    /// <summary>
    /// Classe dos blocos que começam com 0
    /// </summary>
    public class DadosGeraisService : IDadosGeraisService
    {
        [Inject]
        public IDadosGeraisRepository DadosGeraisRepository { get; set; }


        public Domain.Models.Contmatic.Registro0000 GetRegistro0000()
        {
            return DadosGeraisRepository.GetRegistro0000();
        }
    }
}
