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
    public class DocumentosFiscaisMercadoriasService : IDocumentosFiscaisMercadoriasService
    {
        [Inject]
        public IDocumentosFiscaisMercadoriasRepository DocumentosFiscaisMercadoriasRepository { get; set; }

        public IEnumerable<RegistroC010> GetRegistrosC010()
        {
            return DocumentosFiscaisMercadoriasRepository.GetRegistrosC010();
        }
    }
}