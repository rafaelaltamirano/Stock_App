using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Deposito
{
    class Pasillo
    {
        [DisplayName("codigo de pasillo")]
        public string idPasillo { get; set; }
        [DisplayName("NumLado")]
        public string numLado { get; set; }
        [DisplayName("Compartimientos")]
        public Compartimiento Compartimiento { get; set; }

    }
}
