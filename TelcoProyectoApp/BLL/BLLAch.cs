using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MODELS;
using DAO;
namespace BLL
{
    public class BLLAch
    {

        DProcedimiento objProc = null;
        DExecute objExcute = null;
        public string agregaCuentaAch(MCuentaIban objCuentaIban)
        {

            //   string vRes = string.Empty;


            objProc = new DProcedimiento();
            objExcute = new DExecute();
            objProc.NombreProcedimiento = "PRC_CREA_CUENTA_ACH";

            objProc.Parametros.Add(new DParametro { Nombre = "@pNumero_cuenta", Valor = objCuentaIban.numeroCuenta, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pDescripcion_cuenta", Valor = objCuentaIban.descripcionCuenta, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pNombre_cuenta", Valor = objCuentaIban.nombreCuenta, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pIdClienteRef", Valor = objCuentaIban.idClienteRef, Tipo = DbType.String, Out = false });



            return objExcute.Consultar(objProc).Rows[0][0].ToString();


        }
        public DataTable listaCuentas(int pIdCliente, string pOp)
        {
            objProc = new DProcedimiento();
            objExcute = new DExecute();
            objProc.NombreProcedimiento = "PRC_LISTA_CUENTA_X_CLIENTE";

            objProc.Parametros.Add(new DParametro { Nombre = "@pIdCliente", Valor = pIdCliente, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pOp", Valor = pOp, Tipo = DbType.String, Out = false });


            return objExcute.Consultar(objProc);

        }

        public DataTable listaMoneda()
        {
            objProc = new DProcedimiento();
            objExcute = new DExecute();
            objProc.NombreProcedimiento = "PRC_LISTA_MONEDA";


            return objExcute.Consultar(objProc);

        }

        public DataTable transferenciaAch(MTransferenciaACH objMTransAch)
        {
            objProc = new DProcedimiento();
            objExcute = new DExecute();
            objProc.NombreProcedimiento = "PRC_TRANSFERENCIA_TERCEROS";

            objProc.Parametros.Add(new DParametro { Nombre = "@pIdCuentaPrincipal", Valor = objMTransAch.idCuentaPrincipal, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pIdCuentaRelacion", Valor = objMTransAch.idCuentaRelacion, Tipo = DbType.Int32, Out = false });

            objProc.Parametros.Add(new DParametro { Nombre = "@pIdMoneda", Valor = objMTransAch.idMoneda, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pIdTipoTransferencia", Valor = objMTransAch.idTipoTransferencia, Tipo = DbType.Int32, Out = false });

            objProc.Parametros.Add(new DParametro { Nombre = "@pMonto", Valor = objMTransAch.monto, Tipo = DbType.Double, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pDescripcion", Valor = objMTransAch.descripcion, Tipo = DbType.String, Out = false });

            return objExcute.Consultar(objProc);

        }
    }
}
