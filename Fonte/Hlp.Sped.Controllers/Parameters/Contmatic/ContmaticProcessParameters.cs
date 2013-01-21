﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Files;

namespace Hlp.Sped.Controllers.Parameters.Contmatic
{
    public class ContmaticProcessParameters
    {
        public string CodigoEmpresa { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public TipoArquivo TipoArquivo { get; set; }
        public TipoRemessa TipoRemessa { get; set; }
        public string CaminhoArquivo { get; set; }
    }
}
