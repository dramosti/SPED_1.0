using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.PisCofins;
using Hlp.Sped.Repository.Interfaces.PisCofins;
using Hlp.Sped.Domain.Models.PisCofins;

namespace Hlp.Sped.Services.Implementation.PisCofins
{
    public class CuponsFiscaisService: ICuponsFiscaisService
    {
        [Inject]
        public ICuponsFiscaisRepository CuponsFiscaisRepository { get; set; }

        public IEnumerable<RegistroC400> GetRegistrosC400(string codCNPJ)
        {
            return CuponsFiscaisRepository.GetRegistrosC400(codCNPJ);
        }

        public IEnumerable<RegistroC405> GetRegistrosC405(string codCNPJ, string codECF)
        {
            return CuponsFiscaisRepository.GetRegistrosC405(codCNPJ, codECF);
        }

        public IEnumerable<RegistroC481> GetRegistrosC481(
            string codCNPJ, string codECF, DateTime dtEmissao)
        {
            return CuponsFiscaisRepository.GetRegistrosC481(
                codCNPJ, codECF, dtEmissao);
        }

        public IEnumerable<RegistroC485> GetRegistrosC485(
            string codCNPJ, string codECF, DateTime dtEmissao)
        {
            return CuponsFiscaisRepository.GetRegistrosC485(
                codCNPJ, codECF, dtEmissao);
        }
    }
}