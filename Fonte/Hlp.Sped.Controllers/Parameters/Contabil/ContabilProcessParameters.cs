using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Files;

namespace Hlp.Sped.Controllers.Parameters.Contabil
{
    public class ContabilProcessParameters
    {
        public string CodigoEmpresa { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public TipoArquivo TipoArquivo { get; set; }
        public string CaminhoArquivo { get; set; }
    }
}
