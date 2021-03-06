﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Contmatic
{
    public class RegistroD590 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "D590"; }
        }

        [CampoTextoNumerico(Ordem = 2, ComprimentoFixo = true, Tamanho = 3)]
        public int CST_ICMS { get; set; }

        [CampoTextoNumerico(Ordem = 3, ComprimentoFixo = true, Tamanho = 4)]
        public int CFOP { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? ALIQ_ICMS { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal VL_OPR { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal VL_BC_ICMS { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 2)]
        public decimal VL_ICMS { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal VL_BC_ICMS_UF { get; set; }

        [CampoDecimal(Ordem = 9, CasasDecimais = 2)]
        public decimal VL_ICMS_UF { get; set; }

        [CampoDecimal(Ordem = 10, CasasDecimais = 2)]
        public decimal VL_RED_BC { get; set; }

        [CampoTextoVariavel(Ordem = 11, Tamanho = 6)]
        public string COD_OBS { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "D500-" + this.GetNumeroControleRegistro(); }
        }
    }
}
