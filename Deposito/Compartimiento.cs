using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Deposito
{
    class Compartimiento
    {
        [DisplayName("id Compartimiento")]
        public string idCompartimiento { get; set; }

        [DisplayName("Producto contenido")]
        public Producto Producto { get; set; }

    }
}
