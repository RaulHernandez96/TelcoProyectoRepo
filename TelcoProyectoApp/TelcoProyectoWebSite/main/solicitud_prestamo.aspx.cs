using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Windows.Input;

public partial class main_solicitud_prestamo : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"data source=(local)\sqle2017,Initial Catalog=financiera; Integrated Security=true");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInsertar_Click(object sender, EventArgs e)
    {
        if (conn.State == System.Data.ConnectionState.Closed)
            conn.Open();
        SqlCommand sqlcomm = new SqlCommand("[dbo].[PRC_CREA_SOLICITUD_CREDITO]", conn);
        sqlcomm.CommandType = System.Data.CommandType.StoredProcedure;
        sqlcomm.Parameters.AddWithValue("@pIdFinanciera", txtid_financiera.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pIdCliente",txtDPI_cliente.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pIdTipoCredito",txtTipo_credito.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pIdTipoEntrega",txtTipo_entrega.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pIdTipoDesembolso",txtTipo_desembolso.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pCapital",txtCapital.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pPlazo",txtPlazo.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pGarantia",txtGarantia.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pUtilidadDinero",txtUtilidad_dinero.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pHistorialCompra",txtHistorial_compras.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pProyeccionPago", txtProyeccion.Text.Trim());
        sqlcomm.ExecuteNonQuery();
        conn.Close();
        if(int.Parse(txtid_financiera.Text.Trim())==0)
        {
            string script = "alert(\"Solicitud Creada correctamente\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);

        }
        else
        {
            string script = "alert(\"Ocurrio un error en la creacion de la Solicitud\");";
            ScriptManager.RegisterStartupScript(this, GetType(),
                                  "ServerControlScript", script, true);
        }


    }
}