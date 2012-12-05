using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class Registro1700 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "1700"; }
        }

        [CampoTextoVariavel(Ordem = 2, Tamanho = 2)]
        public string COD_DISP { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 2)]
        public string COD_MOD { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 4)]
        public string SER { get; set; }

        [CampoTextoVariavel(Ordem = 5, Tamanho = 3)]
        public string SUB { get; set; }

        [CampoTextoNumerico(Ordem = 6, Tamanho = 12)]
        public string NUM_DOC_INI { get; set; }

        [CampoTextoNumerico(Ordem = 7, Tamanho = 12)]
        public string NUM_DOC_FIN { get; set; }

        [CampoTextoNumerico(Ordem = 8, Tamanho = 60)]
        public string NUM_AUT { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "1700-" + this.GetNumeroControleRegistro(); }
        }
    }
}