using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class main_solicitud_extrafinanciamiento : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"data source=(local)\sqle2017,Initial Catalog=financiera; Integrated Security=true");
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void btn_Click(object sender, EventArgs e)
    {
        if (conn.State == System.Data.ConnectionState.Closed)
            conn.Open();
        SqlCommand sqlcomm = new SqlCommand("[dbo].[PRC_CREA_SOLICITUD_EXTRAFINANCIAMIENTO]", conn);
        sqlcomm.CommandType = System.Data.CommandType.StoredProcedure;
        sqlcomm.Parameters.AddWithValue("@pId_extrafinanciamiento", txtId_extra.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pId_financiera", txtfinanciera.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pIdCliente",txtCliente.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pIdTipoEntrega", txtTipo_entrega.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pIdTipoDesembolso", txtdesembolso.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pMonto", txtMonto.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pEstado", txtestado.Text.Trim());
       // sqlcomm.Parameters.AddWithValue("@pGaranti", txtGarantia.Text.Trim());
        sqlcomm.ExecuteNonQuery();
        conn.Close();
        if (int.Parse(txtfinanciera.Text.Trim()) == 0)
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