using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contmatic;

namespace Hlp.Sped.Repository.Interfaces.Contmatic
{
    public interface IConhecimentoTransporteRepository
    {
        IEnumerable<RegistroD100> GetRegistroD100();
        IEnumerable<RegistroD101> GetRegistroD101(); //vários por D100
        IEnumerable<RegistroD110> GetRegistroD110(string codChaveNotaFiscal); //vários por D100
        IEnumerable<RegistroD120> GetRegistroD120(string codChaveNotaFiscal); //vários por D110
        IEnumerable<RegistroD130> GetRegistroD130(string codChaveNotaFiscal); //vários por D100
        IEnumerable<RegistroD190> GetRegistroD190(string codChaveNotaFiscal); //vários por D100
        IEnumerable<RegistroD500> GetRegistroD500();
        IEnumerable<RegistroD510> GetRegistroD510(string codChaveNotaFiscal); //Vários por D500
        IEnumerable<RegistroD590> GetRegistroD590(string codChaveNotaFiscal); //Vários por D500

    }
}
