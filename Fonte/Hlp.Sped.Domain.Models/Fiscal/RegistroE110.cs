using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO C110: INFORMAÇÃO COMPLEMENTAR DA NOTA FISCAL (CÓDIGO 01, 1B, 04 e 55).
    /// Este registro tem por objetivo identificar os dados contidos no campo Informações Complementares da Nota
    /// Fiscal, que sejam de interesse do fisco, conforme dispõe a legislação. Devem ser discriminados em registros “filhos
    /// próprios” as informações relacionadas com documentos fiscais, processos, cupons fiscais, documentos de arrecadação e
    /// locais de entrega ou coleta que foram explicitamente citadas no campo “Informações Complementares” da Nota Fiscal.
    /// Não podem ser informados para um mesmo documento fiscal, dois ou mais registros com o mesmo conteúdo no
    /// campo COD_INF.
    /// </summary>
    public class RegistroE110 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "E110"; }
        }

        [CampoDecimal(Ordem = 2, CasasDecimais = 2)]
        public decimal? VL_TOT_DEBITOS { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 2)]
        public decimal? VL_AJ_DEBITOS { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? VL_TOT_AJ_DEBITOS { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal? VL_ESTORNOS_CRED { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal? VL_TOT_CREDITOS { get; set; }

        [CampoDecimal(Ordem = 7, CasasDecimais = 2)]
        public decimal? VL_AJ_CREDITOS { get; set; }

        [CampoDecimal(Ordem = 8, CasasDecimais = 2)]
        public decimal? VL_TOT_AJ_CREDITOS { get; set; }

        [CampoDecimal(Ordem = 9, CasasDecimais = 2)]
        public decimal? VL_ESTORNOS_DEB { get; set; }

        [CampoDecimal(Ordem = 10, CasasDecimais = 2)]
        public decimal? VL_SLD_CREDOR_ANT { get; set; }

        [CampoDecimal(Ordem = 11, CasasDecimais = 2)]
        public decimal? VL_SLD_APURADO { get; set; }

        [CampoDecimal(Ordem = 12, CasasDecimais = 2)]
        public decimal? VL_TOT_DED { get; set; }

        [CampoDecimal(Ordem = 13, CasasDecimais = 2)]
        public decimal? VL_ICMS_RECOLHER { get; set; }

        [CampoDecimal(Ordem = 14, CasasDecimais = 2)]
        public decimal? VL_SLD_CREDOR_TRANSPORTAR { get; set; }

        [CampoDecimal(Ordem = 15, CasasDecimais = 2)]
        public decimal? DEB_ESP { get; set; }
    }   
}
