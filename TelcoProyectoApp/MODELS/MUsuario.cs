using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class MUsuario
    {
        public int idUsuario { get; set; }
        public int idCliente { get; set; }
        public int idTipoUsuario { get; set; }
        public int idFinanciera { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
        public string deBaja { get; set; }
    }
}
