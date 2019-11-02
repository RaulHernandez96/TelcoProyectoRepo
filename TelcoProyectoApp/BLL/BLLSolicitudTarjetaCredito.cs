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
    
    public class BLLSolicitudTarjetaCredito
    {
        DProcedimiento objProc = null;
        DExecute objExcute = null;

        public void insertarSolicitud(MSolicitudTarjetaCredito objMSolicitaPrestamoTarjeta)
        {
            objProc = new DProcedimiento();
            objExcute = new DExecute();
            objProc.NombreProcedimiento = "[dbo].[PRC_CREA_SOLICITUD_TARJETA]";

            objProc.Parametros.Add(new DParametro { Nombre = "@pIdFinanciera", Valor = objMSolicitaPrestamoTarjeta.IdFinanciera, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pIdCliente", Valor = objMSolicitaPrestamoTarjeta.IdCliente, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pIdTipoCredito", Valor = objMSolicitaPrestamoTarjeta.IdTipoCredtio, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pId_tipo_tarjeta", Valor = objMSolicitaPrestamoTarjeta.IdTipoTarjeta, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pIdTipoEntrega", Valor = objMSolicitaPrestamoTarjeta.IdTipoEntrega, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pIdTipoDesembolso", Valor = objMSolicitaPrestamoTarjeta.IdTipoDesembolso, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pLimite", Valor = objMSolicitaPrestamoTarjeta.Limite, Tipo = DbType.Double, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pHistorialCompra", Valor = objMSolicitaPrestamoTarjeta.HistorialCompra, Tipo = DbType.String, Out = false });          
            objProc.Parametros.Add(new DParametro { Nombre = "@pIdCategoria_tarjeta", Valor = objMSolicitaPrestamoTarjeta.IdCategoriaTarjeta, Tipo = DbType.Int32, Out = false });

            objExcute.Upsert(objProc);

        }

    }
}
