using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using MODELS;
using System.Data;

namespace BLL
{
    public class BLLLogin : DExecute
    {
        int res = 0;
        public static DataTable permisos(int pIdFinanciera, string pUsuario, string pContrasenia)
        {
            DProcedimiento objProc = null;
            DExecute objExcute = null;

            objProc = new DProcedimiento();
            objExcute = new DExecute();
            objProc.NombreProcedimiento = "PRC_LOGIN_BANCO";

            objProc.Parametros.Add(new DParametro { Nombre = "pIdFinanciera", Valor = pIdFinanciera, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "pUsuario", Valor = pUsuario, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "pContrasenia", Valor = pContrasenia, Tipo = DbType.String, Out = false });



            return objExcute.Consultar(objProc);


        }
    }
}
