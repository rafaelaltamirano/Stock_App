using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Deposito
{
    class Persona
    {
        [DisplayName("Nombre")]
        public string Nombre { get; set; }
        [DisplayName("Apellido")]
        public string Apellido { get; set; }
        [DisplayName("DNI")]
        public string DNI { get; set; }
        [DisplayName("Fecha de Nacimiento ")]
        public DateTime fechaNac { get; set; }
        [DisplayName("Direccion")]
        public string direccion { get; set; }
        [DisplayName("Altura")]
        public int Altura { get; set; }
        [DisplayName("Piso")]
        public int Piso { get; set; }
        [DisplayName("Departamento")]
        public int Departamento { get; set; }

    }
}
