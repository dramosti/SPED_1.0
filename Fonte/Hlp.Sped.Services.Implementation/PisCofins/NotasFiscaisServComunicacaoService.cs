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


        public IEnumerable<Domain.Models.PisCofins.RegistroD010> GetRegistrosD010()
        {
            return notaFiscalServRepository.GetRegistrosD010();
        }


        public IEnumerable<Domain.Models.PisCofins.RegistroD500> GetRegistrosD500(string sCNPJ, string codEmp)
        {
            return notaFiscalServRepository.GetRegistrosD500(sCNPJ, codEmp);
        }

        public IEnumerable<Domain.Models.PisCofins.RegistroD501> GetRegistrosD501(string codChaveNotaFiscal, string codEmp)
        {
            return notaFiscalServRepository.GetRegistrosD501(codChaveNotaFiscal, codEmp);
        }

        public IEnumerable<Domain.Models.PisCofins.RegistroD505> GetRegistrosD505(string codNR_SEQNF, string codEmp)
        {
            return notaFiscalServRepository.GetRegistrosD505(codNR_SEQNF, codEmp);
        }

        public IEnumerable<Domain.Models.PisCofins.RegistroD100> GetRegistrosD100(string codEmp)
        {
            return notaFiscalServRepository.GetRegistroD100(codEmp);
        }

        public IEnumerable<Domain.Models.PisCofins.RegistroD101> GetRegistrosD101(string PK_NOTAFIS, string codEmp)
        {
            return notaFiscalServRepository.GetRegistrosD101(PK_NOTAFIS, codEmp);
        }

        public IEnumerable<Domain.Models.PisCofins.RegistroD105> GetRegistrosD105(string PK_NOTAFIS, string codEmp)
        {
            return notaFiscalServRepository.GetRegistrosD105(PK_NOTAFIS, codEmp);
        }

        public IEnumerable<Domain.Models.PisCofins.RegistroD200> GetRegistrosD200(string codEmp)
        {
            return notaFiscalServRepository.GetRegistroD200(codEmp);
        }

        public IEnumerable<Domain.Models.PisCofins.RegistroD201> GetRegistrosD201(string PK_NOTAFIS, string codEmp)
        {
            return notaFiscalServRepository.GetRegistrosD201(PK_NOTAFIS, codEmp);
        }

        public IEnumerable<Domain.Models.PisCofins.RegistroD205> GetRegistrosD205(string PK_NOTAFIS, string codEmp)
        {
            return notaFiscalServRepository.GetRegistrosD205(PK_NOTAFIS, codEmp);
        }

    }
}
