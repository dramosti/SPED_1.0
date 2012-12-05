using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.Fiscal;
using Hlp.Sped.Repository.Interfaces.Fiscal;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Services.Implementation.Fiscal
{
    public class CuponsFiscaisService : ICuponsFiscaisService
    {
        [Inject]
        public ICuponsFiscaisRepository CuponsFiscaisRepository { get; set; }

        public IEnumerable<RegistroC400> GetRegistrosC400()
        {
            return CuponsFiscaisRepository.GetRegistrosC400();
        }

        public IEnumerable<RegistroC405> GetRegistrosC405(string codECF)
        {
            return CuponsFiscaisRepository.GetRegistrosC405(codECF);
        }

        public RegistroC410 GetRegistroC410(string codECF, DateTime dtEmissao)
        {
            return CuponsFiscaisRepository.GetRegistroC410(codECF, dtEmissao);
        }

        public IEnumerable<RegistroC420> GetRegistrosC420(string codECF, DateTime dtEmissao)
        {
            return CuponsFiscaisRepository.GetRegistrosC420(codECF, dtEmissao);
        }

        public IEnumerable<RegistroC425> GetRegistrosC425(string codECF, DateTime dtEmissao, string codTotalizador)
        {
            return CuponsFiscaisRepository.GetRegistrosC425(codECF, dtEmissao, codTotalizador);
        }

        public IEnumerable<RegistroC460> GetRegistrosC460(string codECF, DateTime dtEmissao)
        {
            return CuponsFiscaisRepository.GetRegistrosC460(codECF, dtEmissao);
        }

        public IEnumerable<RegistroC470> GetRegistrosC470(string pkCupomFis)
        {
            return CuponsFiscaisRepository.GetRegistrosC470(pkCupomFis);
        }

        public IEnumerable<RegistroC490> GetRegistrosC490(string codECF, DateTime dtEmissao)
        {
            return CuponsFiscaisRepository.GetRegistrosC490(codECF, dtEmissao);
        }
    }
}