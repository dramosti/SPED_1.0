using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Services.Interfaces.PisCofins;
using Ninject;
using Hlp.Sped.Repository.Interfaces.PisCofins;

namespace Hlp.Sped.Services.Implementation.PisCofins
{
    public class NotasFiscaisServComunicacaoService : INotasFiscaisServComunicacaoService
    {
        [Inject]
        public INotasFiscaisServComunicacaoRepository notaFiscalServRepository { get; set; }

        public IEnumerable<Domain.Models.PisCofins.RegistroD500> GetRegistrosD500(string sCNPJ)
        {
            return notaFiscalServRepository.GetRegistrosD500(sCNPJ);
        }

        public IEnumerable<Domain.Models.PisCofins.RegistroD501> GetRegistrosD501(string codChaveNotaFiscal)
        {
            return notaFiscalServRepository.GetRegistrosD501(codChaveNotaFiscal);
        }

        public IEnumerable<Domain.Models.PisCofins.RegistroD505> GetRegistrosD505(string codNR_SEQNF)
        {
            return notaFiscalServRepository.GetRegistrosD505(codNR_SEQNF);
        }

        public IEnumerable<Domain.Models.PisCofins.RegistroD010> GetRegistrosD010()
        {
            return notaFiscalServRepository.GetRegistrosD010();
        }
    }
}
