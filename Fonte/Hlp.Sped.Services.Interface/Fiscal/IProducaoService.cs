using Hlp.Sped.Domain.Models.Fiscal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Services.Interfaces.Fiscal
{
    public interface IProducaoService
    {
        RegistroK100 GetRegistroK100();

        IEnumerable<RegistroK200> GetRegistrosK200();

        IEnumerable<RegistroK220> GetRegistrosK220();

        IEnumerable<RegistroK230> GetRegistrosK230();

        IEnumerable<RegistroK235> GetRegistrosK235(RegistroK230 regK230);

        IEnumerable<RegistroK250> GetRegistrosK250();

        IEnumerable<RegistroK255> GetRegistrosK255(RegistroK250 regK250);

        Registro0210 GetRegistro0210(string COD_PROD);

    }
}
