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
    /// Classe dos blocos que começam com A
    /// </summary>
    class NotasFiscaisServicoService : INotasFiscaisServicoService
    {
        [Inject]
        public INotasFiscaisServicoRepository NotasFiscaisRepository { get; set; }


        public IEnumerable<Domain.Models.Contmatic.RegistroA100> GetRegistroA100(string codCNPJ)
        {
            return NotasFiscaisRepository.GetRegistroA100(codCNPJ);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroA170> GetRegistroA170(string codChaveNotaFiscal)
        {
            return NotasFiscaisRepository.GetRegistroA170(codChaveNotaFiscal);
        }
    }
}
