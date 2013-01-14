using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Repository.Interfaces.Fiscal
{
    public interface INotasFiscaisServComunicacaoRepository
    {
        IEnumerable<RegistroD500> GetRegistrosD500();
        IEnumerable<RegistroD590> GetRegistrosD590(string codNR_SEQNF);
    }
}