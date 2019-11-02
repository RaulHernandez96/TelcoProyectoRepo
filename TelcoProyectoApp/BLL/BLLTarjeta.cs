using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using MODELS;

namespace BLL
{
    public class BLLTarjeta
    {
        DProcedimiento objProc = null;
        DExecute objExcute = null;
        public int BuscarTarjeta(string NumeroTarjeta)
        {
            objProc = new DProcedimiento();
            objExcute = new DExecute();
            objProc.NombreProcedimiento = "[dbo].[PRC_CREA_SOLICITUD_CREDITO]";
        }
    }
}
