using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Deposito
{
    class Deposito
    {
            [DisplayName("codigo de deposito")]
            public string idDeposito { get; set; }
            [DisplayName("direccion")]
            public string Direccion { get; set; }
            [DisplayName("Pasillos")]
            public Pasillo Pasillo { get; set;  }

    }
}
