﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contmatic;

namespace Hlp.Sped.Services.Interfaces.Contmatic
{
    public interface IUnidadesService
    {
        Registro0190 GetRegistro0190(string codigoUnidade);
    }
}
