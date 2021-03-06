﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Fiscal;

namespace Hlp.Sped.Services.Interfaces.Fiscal
{
    public interface IApuracaoServices
    {
        IEnumerable<RegistroE100> GetRegistrosE100();
        RegistroE110 GetRegistroE110(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal);
        IEnumerable<RegistroE111> GetRegistrosE111(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal);
        IEnumerable<RegistroE116> GetRegistrosE116(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal);
        IEnumerable<RegistroE500> GetRegistrosE500();
        IEnumerable<RegistroE510> GetRegistrosE510(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal);
        RegistroE520 GetRegistroE520(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal);
        IEnumerable<RegistroE530> GetRegistrosE530(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal);
        IEnumerable<RegistroE200> GetRegistrosE200();
        IEnumerable<RegistroE250> GetRegistrosE250(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal, string sUF);
        RegistroE210 GetRegistroE210(DateTime dtPeriodoInicial, DateTime dtPeriodoFinal, string sUF);

    }
}
