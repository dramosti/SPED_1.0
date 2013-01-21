using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contmatic;

namespace Hlp.Sped.Repository.Interfaces.Contmatic
{
    public interface IDadosGeraisRepository
    {
        Registro0000 GetRegistro0000();
        Registro0001 GetRegistro0001();
        Registro0100 GetRegistro0100();
        IEnumerable<Registro0150> GetRegistro0150(string codigoParticipante);
        IEnumerable<Registro0190> GetRegistro0190(string codigoUnidade);
        IEnumerable<Registro0200> GetRegistro0200(string codigoProduto);
        IEnumerable<Registro0220> GetRegistro0220(string codigoProduto); //Vários por registro 0200
        IEnumerable<Registro0400> GetRegistro0400();
        IEnumerable<Registro0600> GetRegistro0600();
    }
}
