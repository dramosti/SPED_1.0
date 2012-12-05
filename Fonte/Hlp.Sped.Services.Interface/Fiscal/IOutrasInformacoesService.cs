using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Services.Interfaces.Fiscal
{
    public interface IOutrasInformacoesService
    {
        Registro1010 GetRegistro1010();
        IEnumerable<Registro1100> GetRegistros1100();
        IEnumerable<Registro1105> GetRegistros1105(string numDeclaracaoExportacao);
        IEnumerable<Registro1110> GetRegistros1110(string codChaveNotaFiscal);
        IEnumerable<Registro1200> GetRegistros1200();
        IEnumerable<Registro1210> GetRegistros1210(string codAjusteApuracao);
        IEnumerable<Registro1400> GetRegistros1400();
        IEnumerable<Registro1600> GetRegistros1600();
        IEnumerable<Registro1700> GetRegistros1700();
        IEnumerable<Registro1710> GetRegistros1710(
            string codDispositivo, string codModelo, string serie, string subSerie);
    }
}