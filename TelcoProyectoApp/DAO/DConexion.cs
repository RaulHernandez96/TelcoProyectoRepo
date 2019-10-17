using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace DAO
{
    public class DConexion
    {
        public SqlConnection oCnx;

        public DConexion()
        {
            oCnx = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString());
        }

        public void abrirConexion()
        {
            try
            {


                if (oCnx.State == ConnectionState.Broken || oCnx.State == ConnectionState.Closed)
                    oCnx.Open();
            }
            catch (Exception e)
            {

                throw new Exception("Error con la conexión a la base de datos ", e);
            }
        }

        public void cerrarConexion()
        {
            try
            {
                if (oCnx.State == ConnectionState.Open)
                    oCnx.Close();
            }
            catch (Exception e)
            {

                throw new Exception("Error al intentar cerrar la conexión con la base de datos ", e);
            }
        }
    }
}
