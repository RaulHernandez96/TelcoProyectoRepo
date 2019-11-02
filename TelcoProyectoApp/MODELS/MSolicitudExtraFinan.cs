using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class MSolicitudExtraFinan
    {
        public int IdTipoExtraFinan { get; set; }
        public int IdFinan { get; set; }
        public int IdCliente { get; set; }
        public int IdTipoEntrega { get; set; }
        public int IdTipoDesembolso { get; set; }
        public double Monto { get; set; }
        public string UsuarioAlta { get; set; }

    }
}
