using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contmatic;

namespace Hlp.Sped.Services.Interfaces.Contmatic
{
    public interface IConhecimentoTransporteService
    {
        IEnumerable<RegistroD100> GetRegistrosD100();
        IEnumerable<RegistroD101> GetRegistrosD101(); //vários por D100
        IEnumerable<RegistroD110> GetRegistrosD110(string codChaveNotaFiscal); //vários por D100
        IEnumerable<RegistroD120> GetRegistrosD120(string codChaveNotaFiscal); //vários por D110
        IEnumerable<RegistroD130> GetRegistrosD130(string codChaveNotaFiscal); //vários por D100
        IEnumerable<RegistroD190> GetRegistrosD190(string codChaveNotaFiscal); //vários por D100
        IEnumerable<RegistroD500> GetRegistrosD500();
        IEnumerable<RegistroD510> GetRegistrosD510(string codChaveNotaFiscal); //Vários por D500
        IEnumerable<RegistroD590> GetRegistrosD590(string codChaveNotaFiscal); //Vários por D500
    }
}
