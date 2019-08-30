using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Deposito
{
    class Cliente : Persona
    {
        [DisplayName("ID Cliente")]
        public string idcliente { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }

        [DisplayName("Pasillo")]
        public Pasillo Pasillo { get; set; }
        [DisplayName("Compartimineto")]
        public Compartimiento Compartimiento {get;set;}
    }
}
