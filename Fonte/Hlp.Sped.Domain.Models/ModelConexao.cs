using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hlp.Sped.Domain.Models
{
    [System.Serializable]
    public class ModelConexao
    {
        public bool bCOMPLETO { get; set; }

        public List<ItemConn> CONEXOES { get; set; }
    }

    public class ItemConn
    {
        public string PATH { get; set; }
        private string _PORTA = "3050";
        public string NAME { get; set; }


        public string PORTA
        {
            get { return _PORTA; }
            set { _PORTA = value; }
        }
    }

}
