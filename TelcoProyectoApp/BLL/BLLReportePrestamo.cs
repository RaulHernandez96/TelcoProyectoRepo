using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;

namespace BLL
{
    public class BLLReportePrestamo
    {

        DProcedimiento objProc = null;
        DExecute objExcute = null;
        public DataTable prestamoVigente(int pIdCliente)
        {
            objProc = new DProcedimiento();
            objExcute = new DExecute();
            objProc.NombreProcedimiento = "PRC_PRESTAMOS_X_CLIENTE";

            objProc.Parametros.Add(new DParametro { Nombre = "@pIdCliente", Valor = pIdCliente, Tipo = DbType.String, Out = false });
            

            return objExcute.Consultar(objProc);
        }
    }
}
