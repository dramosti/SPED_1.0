﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Domain.Models.Contabil;

namespace Hlp.Sped.Repository.Interfaces.Contabil
{
    public interface IDemonstracoesContabeisRepository
    {
        RegistroJ001 GetRegistroJ001();
        IEnumerable<RegistroJ930> GetRegistrosJ930();
    }
}
