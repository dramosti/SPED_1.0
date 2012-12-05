using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Registro;
using Hlp.Sped.Infrastructure.Annotations;

namespace Hlp.Sped.Domain.Models.Fiscal
{
    /// <summary>
    /// REGISTRO E500: PERÍODO DE APURAÇÃO DO IPI.
    /// Este registro deve ser apresentado pelos estabelecimentos industriais ou equiparados, conforme dispõe o
    /// Regulamento do IPI, para identificação do(s) período(s) de apuração. O(s) período(s) informado(s) deve(m) abranger todo
    /// o período previsto no registro 0000. Poderá coexistir um período mensal com períodos decendiais. Para os períodos
    /// decendiais, não poderá haver sobreposição ou omissão de datas.
    /// </summary>
    public class RegistroE500 : RegistroBase
    {
        [CampoTextoFixo(Ordem = 1)]
        public override string REG
        {
            get { return "E500"; }
        }

        [CampoTextoNumerico(Ordem = 2, ComprimentoFixo = true, Tamanho = 1)]
        public string IND_APUR { get; set; }

        [CampoData(Ordem = 3)]
        public DateTime? DT_INI { get; set; }

        [CampoData(Ordem = 4)]
        public DateTime? DT_FIN { get; set; }

        public override string CODIGO_ORDENACAO
        {
            get { return "E500-" + this.GetNumeroControleRegistro(); }
        }
    }   
}