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

        public Domain.Models.Contmatic.Registro0100 GetRegistro0100()
        {
            return DadosGeraisRepository.GetRegistro0100();
        }

        public IEnumerable<Domain.Models.Contmatic.Registro0150> GetRegistro0150(string codigoParticipante)
        {
            return DadosGeraisRepository.GetRegistro0150(codigoParticipante);
        }

        public IEnumerable<Domain.Models.Contmatic.Registro0190> GetRegistro0190(string codigoUnidade)
        {
            return DadosGeraisRepository.GetRegistro0190(codigoUnidade);
        }

        public IEnumerable<Domain.Models.Contmatic.Registro0200> GetRegistro0200(string codigoProduto)
        {
            return DadosGeraisRepository.GetRegistro0200(codigoProduto);
        }

        public IEnumerable<Domain.Models.Contmatic.Registro0220> GetRegistro0220(string codigoProduto)
        {
            return DadosGeraisRepository.GetRegistro0220(codigoProduto);
        }

        public IEnumerable<Domain.Models.Contmatic.Registro0400> GetRegistro0400()
        {
            return DadosGeraisRepository.GetRegistro0400();
        }

        public IEnumerable<Domain.Models.Contmatic.Registro0600> GetRegistro0600()
        {
            return DadosGeraisRepository.GetRegistro0600();
        }


        public Domain.Models.Contmatic.Registro0001 GetRegistro0001()
        {
            return DadosGeraisRepository.GetRegistro0001();
        }
    }
}
