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
    public class NotasFiscaisServComunicacaoService : INotasFiscaisServComunicacaoService
    {
        [Inject]
        public INotasFiscaisServComunicacaoRepository NotasFiscaisServComunicacaoRepository { get; set; }

        public IEnumerable<RegistroD500> GetRegistrosD500()
        {
            return NotasFiscaisServComunicacaoRepository.GetRegistrosD500();
        }

        public IEnumerable<RegistroD590> GetRegistrosD590(string codChaveNotaFiscal)
        {
            return NotasFiscaisServComunicacaoRepository.GetRegistrosD590(codChaveNotaFiscal);
        }
    }
}