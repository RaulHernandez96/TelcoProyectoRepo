using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
   public class MTransferenciaACH
    {
        public int idCuentaPrincipal { get; set; }
        public int idCuentaRelacion { get; set; }
        public int idMoneda { get; set; }
        public int idTipoTransferencia { get; set; }
        public double monto { get; set; }
        public string descripcion { get; set; }
    }
}
