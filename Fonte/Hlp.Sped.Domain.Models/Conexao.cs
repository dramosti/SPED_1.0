using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hlp.Sped.Infrastructure.Entities;

namespace Hlp.Sped.Domain.Models
{
    public class Conexao : BaseEntity
    {
        private Dictionary<string, string> _PROPRIEDADES = new Dictionary<string,string>();

        public string NOME { get; set; }

        public Dictionary<string, string> PROPRIEDADES
        {
            get { return _PROPRIEDADES; }

        }
    }
}
