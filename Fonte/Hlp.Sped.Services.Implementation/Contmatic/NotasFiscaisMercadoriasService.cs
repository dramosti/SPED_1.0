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
    /// Classe dos blocos que começam com C
    /// </summary>
    class NotasFiscaisMercadoriasService : INotasFiscaisMercadoriasService
    {
        [Inject]
        public INotasFiscaisMercadoriasRepository NotasFiscaisMercRepository { get; set; }


        public IEnumerable<Domain.Models.Contmatic.RegistroC100> GetRegistroC100()
        {
            return NotasFiscaisMercRepository.GetRegistroC100();
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroC170> GetRegistroC170(string codChaveNotaFiscal)
        {
            return NotasFiscaisMercRepository.GetRegistroC170(codChaveNotaFiscal);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroC400> GetRegistroC400()
        {
            return NotasFiscaisMercRepository.GetRegistroC400();
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroC405> GetRegistroC405(string codECF)
        {
            return NotasFiscaisMercRepository.GetRegistroC405(codECF);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroC460> GetRegistroC460(string codECF, DateTime dtEmissao)
        {
            return NotasFiscaisMercRepository.GetRegistroC460(codECF, dtEmissao);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroC470> GetRegistroC470(string pkCupomFis)
        {
            return NotasFiscaisMercRepository.GetRegistroC470(pkCupomFis);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroC500> GetRegistroC500()
        {
            return NotasFiscaisMercRepository.GetRegistroC500();
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroC510> GetRegistroC510(string codChaveNotaFiscal)
        {
            return NotasFiscaisMercRepository.GetRegistroC510(codChaveNotaFiscal);
        }
    }
}
