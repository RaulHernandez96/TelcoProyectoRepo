using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class MSolicitudPrestamo
    {
        public int idFinanciera { get; set; }
        public string dpiCliente { get; set; }
        public int idTipoCliente { get; set; }
        public int idTipoEntrega { get; set; }
        public int idTipoDesembolso { get; set; }
        public double capital { get; set; }
        public int plazo { get; set; }
        public string garantia { get; set; }
        public string utilidadDinero { get; set; }
        public string historialCompras { get; set; }
        public int estadoAutorizacion { get; set; }
        public string fecha { get; set; }
    }
}
