using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO E510: CONSOLIDAÇÃO DOS VALORES DO IPI.
    /// Este registro deve ser preenchido com os valores consolidados do IPI, de acordo com o período informado no
    /// registro E500, tomando-se por base as informações prestadas no registro C170.
    /// A consolidação se dará pela sumarização do valor contábil, base de cálculo e imposto relativo a todas as operações,
    /// conforme a combinação de CFOP e código da situação tributária do IPI (CST_IPI).
    /// As informações oriundas dos itens dos documentos fiscais – registro C170 ou do documento NF-e de emissão
    /// própria – serão consideradas no período de apuração mensal ou decendial, conforme preenchimento do campo IND_APUR.
    /// </summary>
    public class RegistroE510 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "E510"; }
        }

        [CampoTextoNumerico(Ordem = 2, ComprimentoFixo = true, Tamanho = 4)]
        public string CFOP { get; set; }

        [CampoTextoNumerico(Ordem = 2, ComprimentoFixo = true, Tamanho = 2)]
        public string CST_IPI { get; set; }

        [CampoDecimal(Ordem = 4, CasasDecimais = 2)]
        public decimal? VL_CONT_IPI { get; set; }

        [CampoDecimal(Ordem = 5, CasasDecimais = 2)]
        public decimal? VL_BC_IPI { get; set; }

        [CampoDecimal(Ordem = 6, CasasDecimais = 2)]
        public decimal? VL_IPI { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "E500-" + this.GetNumeroControleRegistro(); }
        }
    }   
}