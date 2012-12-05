using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ninject;
using Hlp.Sped.Services.Interfaces.Contabil;
using Hlp.Sped.Repository.Interfaces.Contabil;
using Hlp.Sped.Domain.Models.Contabil;

namespace Hlp.Sped.Services.Implementation.Contabil
{
    public class AberturaService : IAberturaService
    {
        [Inject]
        public IAberturaRepository AberturaRepository { get; set; }

        public Registro0000 GetRegistro0000()
        {
            return AberturaRepository.GetRegistro0000();
        }

        public Registro0001 GetRegistro0001()
        {
            return AberturaRepository.GetRegistro0001();
        }

        public IEnumerable<Registro0007> GetRegistros0007()
        {
            return AberturaRepository.GetRegistros0007();
        }

        public IEnumerable<Registro0020> GetRegistros0020()
        {
            return AberturaRepository.GetRegistros0020();
        }

        public IEnumerable<Registro0150> GetRegistros0150()
        {
            return AberturaRepository.GetRegistros0150();
        }

        public Registro0180 GetRegistro0180(string COD_PART)
        {
            return AberturaRepository.GetRegistro0180(COD_PART);
        }
    }
}
