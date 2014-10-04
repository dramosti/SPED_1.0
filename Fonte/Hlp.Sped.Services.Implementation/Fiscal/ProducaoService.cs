using Hlp.Sped.Domain.Models.Fiscal;
using Hlp.Sped.Repository.Interfaces.Fiscal;
using Hlp.Sped.Services.Interfaces.Fiscal;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Services.Implementation.Fiscal
{
    public class ProducaoService : IProducaoService
    {

        [Inject]
        public IProducaoRepository ProducaoRepository { get; set; }

        public Domain.Models.Fiscal.RegistroK100 GetRegistroK100()
        {
            return ProducaoRepository.GetRegistroK100();
        }

        public IEnumerable<Domain.Models.Fiscal.RegistroK200> GetRegistrosK200()
        {
            return ProducaoRepository.GetRegistrosK200();
        }

        public IEnumerable<Domain.Models.Fiscal.RegistroK220> GetRegistrosK220()
        {
            return ProducaoRepository.GetRegistrosK220();
        }

        public IEnumerable<Domain.Models.Fiscal.RegistroK230> GetRegistrosK230()
        {
            return ProducaoRepository.GetRegistrosK230();
        }

        public IEnumerable<Domain.Models.Fiscal.RegistroK235> GetRegistrosK235(Domain.Models.Fiscal.RegistroK230 regK230)
        {
            return ProducaoRepository.GetRegistrosK235(regK230);
        }

        public IEnumerable<Domain.Models.Fiscal.RegistroK250> GetRegistrosK250()
        {
            return ProducaoRepository.GetRegistrosK250();
        }

        public IEnumerable<Domain.Models.Fiscal.RegistroK255> GetRegistrosK255(Domain.Models.Fiscal.RegistroK250 regK250)
        {
            return ProducaoRepository.GetRegistrosK255(regK250);
        }


        public Registro0210 GetRegistro0210(string COD_PROD)
        {
            return ProducaoRepository.GetRegistro0210(COD_PROD);
        }
    }
}
