using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// Este registro deve ser apresentado para discriminar os valores totais dos itens/produtos do inventário realizado em
    /// 31 de dezembro de cada exercício, ou nas demais datas estabelecidas pela legislação fiscal ou comercial. O inventário
    /// deverá ser apresentado no arquivo da EFD, no segundo mês subsequente ao evento. Ex. inventário realizado em 31/12/08
    /// deverá ser apresentado na EFD de período de referência fevereiro de 2009.
    /// Atribuir valor Zero ao inventário significa escriturar sem estoque.
    /// </summary>
    public class RegistroH005 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "H005"; }
        }

        [CampoData(Ordem = 2)]
        public DateTime? DT_INV { get; set; }

        [CampoDecimal(Ordem = 3, CasasDecimais = 2)]
        public decimal? VL_INV { get; set; }

        [CampoTextoVariavel(Ordem = 4, Tamanho = 2)]
        public string MOT_INV { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "H005-" + this.GetNumeroControleRegistro(); }
        }
    }
}