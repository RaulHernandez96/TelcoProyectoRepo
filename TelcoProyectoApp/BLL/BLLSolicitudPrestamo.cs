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
    public class BLLSolicitudPrestamo
    {
        DProcedimiento objProc = null;
        DExecute objExcute = null;

        public void insertaSolicitud(MSolicitudPrestamo objMSolicitaPrestamo)
        {
            objProc = new DProcedimiento();
            objExcute = new DExecute();
            objProc.NombreProcedimiento = "[dbo].[PRC_CREA_SOLICITUD_CREDITO]";

            objProc.Parametros.Add(new DParametro { Nombre = "pIdFinanciera", Valor = objMSolicitaPrestamo.idFinanciera, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "pIdCliente", Valor = objMSolicitaPrestamo.dpiCliente, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "pIdTipoCredito", Valor = objMSolicitaPrestamo.idTipoCredito, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "pIdTipoEntrega", Valor = objMSolicitaPrestamo.idTipoEntrega, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "pIdTipoDesembolso", Valor = objMSolicitaPrestamo.idTipoDesembolso, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "pCapital", Valor = objMSolicitaPrestamo.capital, Tipo = DbType.Double, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "pPlazo", Valor = objMSolicitaPrestamo.plazo, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "pGarantia", Valor = objMSolicitaPrestamo.garantia, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "pUtilidadDinero", Valor = objMSolicitaPrestamo.utilidadDinero, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "pHistorialCompra", Valor = objMSolicitaPrestamo.historialCompras, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "pProyeccionPago", Valor = objMSolicitaPrestamo.proyeccionPago, Tipo = DbType.String, Out = false });

            objExcute.Upsert(objProc);



        }

    }

}
