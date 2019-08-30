using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Deposito
{
    class Producto
    {
        [DisplayName("idPorducto")]
        public string idProducto { get; set; }
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Tipo")]
        public string Tipo { get; set; } 

    }
}
