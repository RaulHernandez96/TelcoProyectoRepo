﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class main_solicitud_tarjeta_credito : System.Web.UI.Page
{
    SqlConnection conn = new SqlConnection(@"data source=(local)\sqle2017,Initial Catalog=financiera; Integrated Security=true");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnInsertar_Click(object sender, EventArgs e)
    {
        string pIdSolicitud_tarjeta_credito;
        pIdSolicitud_tarjeta_credito ="";
        if (conn.State == System.Data.ConnectionState.Closed)
            conn.Open();
        SqlCommand sqlcomm = new SqlCommand("[dbo].[PRC_CREA_SOLICITUD_TARJETA]", conn);
        sqlcomm.CommandType = System.Data.CommandType.StoredProcedure;
        sqlcomm.Parameters.AddWithValue("@pIdFinanciera", txtid_financiera.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pIdCliente", txtDPI_cliente.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pIdTipoCredito", txtTipo_credito.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pId_tipo_tarjeta", txtTipo_tarjeta.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pIdTipoEntrega", txtTipo_entrega.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pIdTipoDesembolso", txtTipo_desembolso.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pLimite", txtlimite.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pHistorialCompra", txtHistorial_compras.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pEstado", txtEstado_autorizacion.Text.Trim());
        sqlcomm.Parameters.AddWithValue("@pIdCategoria_tarjeta", txtCategoria_tarjeta.Text.Trim());
        sqlcomm.ExecuteNonQuery();
        conn.Close();
        if (int.Parse(txtid_financiera.Text.Trim()) == 0)
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