using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using MODELS;

namespace BLL
{
    public class BLLSolitudPrestamo
    {
        DProcedimiento objProc = null;
        DExecute objDExecute = null;

        public void solictudPrestamo(MSolicitudPrestamo objMSolicitudPrestamo)
        {
            objProc = new DProcedimiento();
            objDExecute = new DExecute();
            objProc.NombreProcedimiento = "[dbo].[PRC_CREA_SOLICITUD_CREDITO]";

            objProc.Parametros.Add(new DParametro { Nombre = "@pIdFinanciera", Valor = objMSolicitudPrestamo.idFinanciera, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pIdCliente", Valor = objMSolicitudPrestamo.dpiCliente, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pIdTipoCredito", Valor = objMSolicitudPrestamo.idTipoCredito, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pIdTipoEntrega", Valor = objMSolicitudPrestamo.idTipoEntrega, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pIdTipoDesembolso", Valor = objMSolicitudPrestamo.idTipoDesembolso, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pCapital", Valor = objMSolicitudPrestamo.capital, Tipo = DbType.Double, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pPlazo", Valor = objMSolicitudPrestamo.plazo, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pGarantia", Valor = objMSolicitudPrestamo.garantia, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pUtilidadDinero", Valor = objMSolicitudPrestamo.utilidadDinero, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pHistorialCompra", Valor = objMSolicitudPrestamo.historialCompras, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pProyeccionPago", Valor = objMSolicitudPrestamo.proyeccionPago, Tipo = DbType.String, Out = false });


        }
        
    }
}
