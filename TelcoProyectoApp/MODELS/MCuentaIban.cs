using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class MCuentaIban
    {
        public int idCuentaIban { get; set; }
        public string numeroCuenta { get; set; }
        public string descripcionCuenta { get; set; }
        public string nombreCuenta { get; set; }
        public int idClienteRef { get; set; }
    }
}
