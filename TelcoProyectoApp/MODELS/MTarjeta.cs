using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class MTarjeta
    {
        public string NumeroTarjeta { get; set; }
        public string NombreTarjeta { get; set; }
        public int IdCliente { get; set; }
        public int IdInteres { get; set; }
        public int IdProveedor { get; set; }
        public int Pin { get; set; }
        public string NumeroSeguridad { get; set; }
        public double MaximoCredito { get; set; }
        public DateTime FechaPago { get; set; }
        public DateTime FechaCorte { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public int IdEstadoTarjeta { get; set; }
        public DateTime FechaAlta { get; set; }
        public DateTime FechaBaja { get; set; }
        public string UsuarioAlta { get; set; }
        public string UsuarioBaja { get; set; }

    }
}
