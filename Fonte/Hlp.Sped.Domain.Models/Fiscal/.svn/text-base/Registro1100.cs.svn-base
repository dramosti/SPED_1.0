using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    public class Registro1100 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "1100"; }
        }

        [CampoTextoNumerico(Ordem = 2, ComprimentoFixo = true, Tamanho = 1)]
        public string IND_DOC { get; set; }

        [CampoTextoVariavel(Ordem = 3, Tamanho = 11)]
        public string NRO_DE { get; set; }

        [CampoData(Ordem = 4)]
        public DateTime? DT_DE { get; set; }

        [CampoTextoNumerico(Ordem = 5, ComprimentoFixo = true, Tamanho = 1)]
        public string NAT_EXP { get; set; }

        [CampoTextoVariavel(Ordem = 6, Tamanho = 12)]
        public string NRO_RE { get; set; }

        [CampoData(Ordem = 7)]
        public DateTime? DT_RE { get; set; }

        [CampoTextoVariavel(Ordem = 8, Tamanho = 18)]
        public string CHC_EMB { get; set; }

        [CampoData(Ordem = 9)]
        public DateTime? DT_CHC { get; set; }

        [CampoData(Ordem = 10)]
        public DateTime? DT_AVB { get; set; }

        [CampoTextoNumerico(Ordem = 11, ComprimentoFixo = true, Tamanho = 2)]
        public string TP_CHC { get; set; }

        [CampoTextoVariavel(Ordem = 12, Tamanho = 3)]
        public string PAIS { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "1100-" + this.GetNumeroControleRegistro(); }
        }
    }   
}