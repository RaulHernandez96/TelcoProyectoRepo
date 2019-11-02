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
    public class BLLSolicitudExtraFinan
    {
        DProcedimiento objProc = null;
        DExecute objExcute = null;

        public void insertaSolicitud(MSolicitudExtraFinan objMsolicitudExtraFinan)
        {
            objProc = new DProcedimiento();
            objExcute = new DExecute();
            objProc.NombreProcedimiento = "[dbo].[PRC_CREA_SOLICITUD_EXTRAFINANCIAMIENTO]";

            objProc.Parametros.Add(new DParametro { Nombre = "@pId_extrafinanciamiento", Valor = objMsolicitudExtraFinan.IdTipoExtraFinan, Tipo = DbType.Int32, Out = false });
            //objProc.Parametros.Add(new DParametro { Nombre = "@pId_financiera", Valor = objMsolicitudExtraFinan.IdFinan, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pIdCliente", Valor = objMsolicitudExtraFinan.IdCliente, Tipo = DbType.Int32, Out = false });       
            objProc.Parametros.Add(new DParametro { Nombre = "@pIdTipoEntrega", Valor = objMsolicitudExtraFinan.IdTipoEntrega, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pIdTipoDesembolso", Valor = objMsolicitudExtraFinan.IdTipoDesembolso, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pMonto", Valor = objMsolicitudExtraFinan.Monto, Tipo = DbType.Double, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "@pUsuario_alta", Valor = objMsolicitudExtraFinan.UsuarioAlta, Tipo = DbType.String, Out = false });
            
            objExcute.Upsert(objProc);



        }
    }

}
