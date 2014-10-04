using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using Hlp.Sped.Infrastructure.Annotations;
using Hlp.Sped.Infrastructure.Annotations.Base;

namespace Hlp.Sped.Infrastructure.Registro
{
    [Serializable]
    public abstract class RegistroBase
    {
        // Atributo de controle incrementado a cada invocação do método GetNumeroControleRegistro.
        // É utilizado para fins de ordenação de registros-pai e filhos.
        private static int _NumeroControleRegistro = 0;

        public abstract string REG { get; }

        public virtual string CODIGO_ORDENACAO
        {
            get { return this.REG; }
        }

        

        // O método abaixo deve ser invocado a fim de zerar instâncias estáticas
        // contendo especificações de registros.
        public static void InicializarProcessamentoRegistros()
        {
            EspecificacaoRegistro.InicializarAnaliseEspecificacoesRegistro();
        }

        // O método estático a seguir é utilizado para fins de ordenação de blocos
        // e de registros do tipo 9900.
        public static int? GetValorOrdenacaoBloco(string codigoTipoRegistro)
        {
            char caracterIdentificacaoBloco = codigoTipoRegistro[0];
            switch (caracterIdentificacaoBloco)
            {
                case '0':
                    return 0;
                case 'A':
                    return 30;
                case 'C':
                    return 100;
                case 'D':
                    return 200;
                case 'E':
                    return 300;
                case 'F':
                    return 320;
                case 'G':
                    return 400;
                case 'H':
                    return 500;
                case 'I':
                    return 600;
                case 'J':
                    return 700;
                case 'K':
                    return 750;
                case 'M':
                    return 780;
                case 'P':
                    return 800;
                case '1':
                    return 890;
                case '9':
                    return 900;
            }

            return null;
        }
             
        public override string ToString()
        {
            /*
            var propriedades = (from p in this.GetType().GetProperties()
                                select new 
                                {
                                    p.Name, 
                                    TipoCampo = (TipoCampoAttribute)(p.GetCustomAttributes(typeof(TipoCampoAttribute), true).FirstOrDefault())
                                }).Where(p => p.TipoCampo != null).OrderBy(p => p.TipoCampo.Ordem);
            */
            try
            {
                var propriedades = EspecificacaoRegistro.GetEspecificacaoRegistro(this);

                StringBuilder resultado = new StringBuilder();
                foreach (var c in propriedades.Campos)
                    resultado.Append("|" + ConvertPropertyToText(c.Nome, c.TipoCampo));
                resultado.Append("|");

                return resultado.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual string GetKeyValue()
        {
            return this.REG;
        }

        public string GetNumeroControleRegistro()
        {
            RegistroBase._NumeroControleRegistro++;
            return RegistroBase._NumeroControleRegistro.ToString().PadLeft(15, '0');
        }

        private string ConvertPropertyToText(string propriedade, TipoCampoAttribute tipoCampo)
        {
            Type atributo = tipoCampo.GetType();
            if (atributo == typeof(CampoTextoFixoAttribute))
            {
                return this.GetType().GetProperty(propriedade).GetValue(this, null).ToString();
            }
            if (atributo == typeof(CampoTextoVariavelAttribute))
            {
                string valor = (string)this.GetType().GetProperty(propriedade).GetValue(this, null);
                if (!String.IsNullOrWhiteSpace(valor))
                {
                    valor = valor.Replace("|", " ").Trim();
                    CampoTextoVariavelAttribute atrib = (CampoTextoVariavelAttribute)tipoCampo;
                    if (atrib.Tamanho > 0 && valor.Length > atrib.Tamanho)
                        return valor.Substring(0, atrib.Tamanho).Trim();
                    else
                        return valor;
                }
                else
                    return String.Empty;
            }
            else if (atributo == typeof(CampoTextoNumericoAttribute))
            {
                string valor =
                    this.GetType().GetProperty(propriedade).GetValue(this, null) == null ? null : this.GetType().GetProperty(propriedade).GetValue(this, null).ToString();
                if (!String.IsNullOrWhiteSpace(valor))
                {
                    CampoTextoNumericoAttribute atrib = (CampoTextoNumericoAttribute)tipoCampo;
                    StringBuilder strb = new StringBuilder(valor);
                    strb.Replace(".", "");
                    strb.Replace("-", "");
                    strb.Replace("/", "");
                    valor = strb.ToString();
                    if (atrib.ComprimentoFixo)
                        return valor.PadLeft(atrib.Tamanho, '0');
                    else
                        return valor;
                }
                else
                    return String.Empty;
            }
            else if (atributo == typeof(CampoCodigoAttribute))
            {
                string valor =
                    this.GetType().GetProperty(propriedade).GetValue(this, null) == null ? null : this.GetType().GetProperty(propriedade).GetValue(this, null).ToString();
                if (!String.IsNullOrWhiteSpace(valor))
                {
                    CampoCodigoAttribute atrib = (CampoCodigoAttribute)tipoCampo;
                    StringBuilder strb = new StringBuilder(valor);
                    strb.Replace(".", "");
                    strb.Replace("-", "");
                    strb.Replace("/", "");
                    valor = strb.ToString().Trim();
                    if (atrib.ComprimentoFixo)
                        return valor.PadLeft(atrib.Tamanho, '0');
                    else
                        return valor;
                }
                else
                    return String.Empty;
            }
            else if (atributo == typeof(CampoDataAttribute))
            {
                DateTime? data = (DateTime?)this.GetType().GetProperty(propriedade).GetValue(this, null);
                if (data.HasValue)
                    return data.Value.ToString("ddMMyyyy");
                else
                    return String.Empty;
            }
            else if (atributo == typeof(CampoDecimalAttribute))
            {
                decimal? valor = (decimal?)this.GetType().GetProperty(propriedade).GetValue(this, null);
                if (valor.HasValue)
                {
                    if (valor > 0)
                    {
                        CampoDecimalAttribute atrib = (CampoDecimalAttribute)tipoCampo;
                        return valor.Value.ToString("0." + "0".PadRight(atrib.CasasDecimais, '0'));
                    }
                    else
                    {
                        return valor.Value.ToString();
                    }
                }
                else
                    return String.Empty;
            }

            return String.Empty;
        }
    }
}
