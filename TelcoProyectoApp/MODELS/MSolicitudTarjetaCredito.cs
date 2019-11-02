using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class MSolicitudTarjetaCredito
    {
        public int IdFinanciera { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoCredtio { get; set; }
        public int IdTipoTarjeta { get; set; }
        public int IdTipoEntrega { get; set; }
        public int IdTipoDesembolso { get; set; }
        public double Limite { get; set; }
        public string HistorialCompra { get; set; }        
        public int IdCategoriaTarjeta { get; set; }

    }
}
