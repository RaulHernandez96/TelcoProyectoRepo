using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

public partial class main_ConsultaTarjeta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void buscarInfo(object sender, EventArgs e)
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ConnectionString);
        try
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            SqlCommand sqlcomm = new SqlCommand("[dbo].[PRC_LISTA_TARJETA]", conn);
            sqlcomm.CommandType = CommandType.StoredProcedure;
            sqlcomm.Parameters.Add(new SqlParameter("@pNumeroTarjeta", txtNumeroTarjeta.Text));
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = sqlcomm;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);            
            gvPrueba.DataSource = tabla;
            sqlcomm.ExecuteNonQuery();
            conn.Close();      
     
            if (tabla.Rows.Count>0)
            {
                foreach(DataRow InfoCuenta in tabla.Rows)
                {
                   lbCliente.Text=InfoCuenta["primer_nombre"].ToString()+" "+InfoCuenta["primer_apellido"].ToString();
                    lbNumeroTarjeta.Text = InfoCuenta["numero_tarjeta"].ToString();
                    lbNombreTarjeta.Text = InfoCuenta["nombre_tarjeta"].ToString();
                    lbInteresTarjeta.Text = InfoCuenta["monto_interes_tarjeta"].ToString();
                    //lbProveedorTarjet.Text = InfoCuenta["id_proveedor_tarjeta"].ToString();
                    lbLimite.Text = InfoCuenta["maximo_credito"].ToString();
                    lbFechaPago.Text =DateTime.Parse( InfoCuenta["fecha_pago"].ToString()).ToString("dd-MM-yyyy");
                    lbFechaCorte.Text =DateTime.Parse( InfoCuenta["fecha_corte"].ToString()).ToString("dd-MM-yyyy");
                    lbFechaVencimineto.Text =DateTime.Parse( InfoCuenta["fecha_vencimiento"].ToString()).ToString("dd-MM-yyyy");
                    lbEstado.Text = InfoCuenta["descripcion_estado_tarjeta"].ToString();
                }
            }


            _lbMensajeUsuario.Text = "Consulta realizada con éxito";
            _lbMensajeUsuario.CssClass = "text-bold text-info";
        }
        catch (Exception ex)
        {
            _lbMensajeUsuario.Text = $"Error de ejecución. {ex.Message}";
            _lbMensajeUsuario.CssClass = "text-bold text-danger";



        }
    }
}