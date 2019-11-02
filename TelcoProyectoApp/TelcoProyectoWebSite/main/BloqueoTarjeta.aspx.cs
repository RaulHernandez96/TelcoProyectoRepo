using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


public partial class main_BloqueoTarjeta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        
        btnBloquear.Visible = false;
        


       

    }

    protected void buscarInfo(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        try
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            SqlCommand sqlcomm = new SqlCommand("[dbo].[PRC_LISTAR_TARJETA_X_BLOQUEO]", conn);
            sqlcomm.CommandType = CommandType.StoredProcedure;
            sqlcomm.Parameters.Add(new SqlParameter("@pNumeroTarjeta", txtNumeroTarjeta.Text));
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = sqlcomm;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            gvPrueba.DataSource = tabla;
            sqlcomm.ExecuteNonQuery();
            conn.Close();

            if (tabla.Rows.Count > 0)
            {
                foreach (DataRow InfoCuenta in tabla.Rows)
                {
                    lbCliente.Text = InfoCuenta["primer_nombre"].ToString() + " " + InfoCuenta["primer_apellido"].ToString();
                    lbNumeroTarjeta.Text = InfoCuenta["numero_tarjeta"].ToString();                    
                }
            }
            Response.Write("<script>alert('consulta con exito');</script>");
        }
        catch (Exception ex)
        {
            // MessageBox.Show(ex.Message);
            Response.Write("<script>alert('" + ex.Message + "');</script>");


        }
        btnBloquear.Visible = true;
        
    }

    protected void bloquear(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        try
        {
            int valor;
            valor =2;            
                if (conn.State == System.Data.ConnectionState.Closed)
                    conn.Open();
                SqlCommand sqlcomm = new SqlCommand("[dbo].[PRC_BLOQUEO_TARJETA]", conn);
                sqlcomm.CommandType = CommandType.StoredProcedure;
                sqlcomm.Parameters.Add(new SqlParameter("@pNumeroTarjeta", txtNumeroTarjeta.Text));
                sqlcomm.Parameters.Add(new SqlParameter("@pvalor", valor));
            SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = sqlcomm;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                gvPrueba.DataSource = tabla;
                sqlcomm.ExecuteNonQuery();
                conn.Close();
            lbCliente.Text = "";
            lbNumeroTarjeta.Text ="";

            _lbMensajeUsuario.Text = "Bloqueo realizado con exito";
            _lbMensajeUsuario.CssClass = "text-bold text-info";
            txtNumeroTarjeta.Text = "";


        }
        catch (Exception ex)
        {
            _lbMensajeUsuario.Text = $"Error de ejecución. {ex.Message}";
            _lbMensajeUsuario.CssClass = "text-bold text-danger";


        }

    }
}