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
   public class NotasFiscaisMercadoriasService : INotasFiscaisMercadoriasService
    {
        [Inject]
        public INotasFiscaisMercadoriasRepository NotasFiscaisMercRepository { get; set; }


        public IEnumerable<Domain.Models.Contmatic.RegistroC100> GetRegistrosC100()
        {
            return NotasFiscaisMercRepository.GetRegistroC100();
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroC170> GetRegistrosC170(string codChaveNotaFiscal)
        {
            return NotasFiscaisMercRepository.GetRegistroC170(codChaveNotaFiscal);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroC400> GetRegistrosC400()
        {
            return NotasFiscaisMercRepository.GetRegistroC400();
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroC405> GetRegistrosC405(string codECF)
        {
            return NotasFiscaisMercRepository.GetRegistroC405(codECF);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroC460> GetRegistrosC460(string codECF, DateTime dtEmissao)
        {
            return NotasFiscaisMercRepository.GetRegistroC460(codECF, dtEmissao);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroC470> GetRegistrosC470(string pkCupomFis)
        {
            return NotasFiscaisMercRepository.GetRegistroC470(pkCupomFis);
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroC500> GetRegistrosC500()
        {
            return NotasFiscaisMercRepository.GetRegistroC500();
        }

        public IEnumerable<Domain.Models.Contmatic.RegistroC510> GetRegistrosC510(string codChaveNotaFiscal)
        {
            return NotasFiscaisMercRepository.GetRegistroC510(codChaveNotaFiscal);
        }
    }
}
