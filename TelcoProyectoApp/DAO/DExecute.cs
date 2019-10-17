using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class DExecute : DConexion
    {

        public void Upsert(DProcedimiento procedimiento)
        {
            try
            {
                abrirConexion();
                SqlCommand cmd = oCnx.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedimiento.NombreProcedimiento;

                foreach (var item in procedimiento.Parametros)
                {
                    cmd.Parameters.AddWithValue(item.Nombre, item.Valor).DbType = item.Tipo;
                }
                cmd.ExecuteNonQuery();
                cerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public DataTable Consultar(DProcedimiento procedimiento)
        {
            DataTable dtlDatos = new DataTable("datos");
            try
            {

                abrirConexion();
                SqlCommand cmd = oCnx.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = procedimiento.NombreProcedimiento;

                if (procedimiento.Parametros != null)
                {
                    foreach (var item in procedimiento.Parametros)
                    {
                        cmd.Parameters.AddWithValue(item.Nombre, item.Valor).DbType = item.Tipo;
                    }
                }

                SqlDataAdapter msqDta = new SqlDataAdapter(cmd);
                msqDta.Fill(dtlDatos);

                cerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
            return dtlDatos;
        }
    }
}
