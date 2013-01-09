using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contmatic;

namespace Hlp.Sped.Services.Interfaces.Contmatic
{
    public interface INotasFiscaisMercadoriasService
    {
        IEnumerable<RegistroC100> GetRegistroC100();
        IEnumerable<RegistroC170> GetRegistroC170(string codChaveNotaFiscal); //Vários por registro C100
        IEnumerable<RegistroC400> GetRegistroC400();
        IEnumerable<RegistroC405> GetRegistroC405(string codECF); //Vários por registro C400
        IEnumerable<RegistroC460> GetRegistroC460(string codECF, DateTime dtEmissao); //Vários por registro C405
        IEnumerable<RegistroC470> GetRegistroC470(string pkCupomFis); //Vários por registro C460
        IEnumerable<RegistroC500> GetRegistroC500();
        IEnumerable<RegistroC510> GetRegistroC510(string codChaveNotaFiscal);// Vários por registro C500
    }
}
