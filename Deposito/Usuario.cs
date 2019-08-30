using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Deposito
{
    class Usuario
    {
        [DisplayName("idUsuario")]
        public string idusuario { get; set; }
        [DisplayName("password")]
        private string pass { get; set; }
        [DisplayName("Email")]
        public string email { get; set; }
        [DisplayName("tipo de usuario")]
        public int tipoUsuario { get; set; }
        [DisplayName("pasillo")]
        public Pasillo pasillo{ get; set; }

    }
}
