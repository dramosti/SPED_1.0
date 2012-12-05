using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Annotations.Base;

namespace Hlp.Sped.Infrastructure.Registro
{
    internal class EspecificacaoRegistro
    {
        private static List<EspecificacaoRegistro> _Especificacoes =
            new List<EspecificacaoRegistro>();

        private string _IdentificadorTipoRegistro;

        public string IdentificadorTipoRegistro
        {
            get { return _IdentificadorTipoRegistro; }
        }

        private IEnumerable<CampoRegistro> _Campos;

        public IEnumerable<CampoRegistro> Campos
        {
            get { return _Campos; }
        }

        private EspecificacaoRegistro(RegistroBase registro)
        {
            this._IdentificadorTipoRegistro = registro.REG;
            this._Campos = (from p in registro.GetType().GetProperties()
                            select new
                            {
                                campos = new CampoRegistro() { Nome = p.Name, TipoCampo = (TipoCampoAttribute)(p.GetCustomAttributes(typeof(TipoCampoAttribute), true).FirstOrDefault()) },
                                p.Name,
                                TipoCampo = (TipoCampoAttribute)(p.GetCustomAttributes(typeof(TipoCampoAttribute), true).FirstOrDefault())
                            })
                            .Where(p => p.TipoCampo != null)
                            .OrderBy(p => p.TipoCampo.Ordem)
                            .Select(p => new CampoRegistro() { Nome = p.Name, TipoCampo = p.TipoCampo })
                            .ToList();
        }

        public static void InicializarAnaliseEspecificacoesRegistro()
        {
            EspecificacaoRegistro._Especificacoes.Clear();
        }

        public static EspecificacaoRegistro GetEspecificacaoRegistro(RegistroBase registro)
        {
            EspecificacaoRegistro especificacao = (from e in EspecificacaoRegistro._Especificacoes
                                                   where e.IdentificadorTipoRegistro == registro.REG
                                                   select e).FirstOrDefault();

            if (especificacao == null)
            {
                especificacao = new EspecificacaoRegistro(registro);
                EspecificacaoRegistro._Especificacoes.Add(especificacao);
            }

            return especificacao;
        }
    }
}
