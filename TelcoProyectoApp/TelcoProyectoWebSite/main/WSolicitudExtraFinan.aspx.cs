using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAO;
using MODELS;
using System.Data;
using BLL;
using System.Data.SqlClient;
using System.Configuration;

public partial class main_WSolicitudExtraFinan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SelectTipoEntrega();
        SelectTipoDesembolso();
        SelectTipoExtra();
        
    }

    protected void btnInsertar_Click(object sender, EventArgs e)
    {
        

        try
        {

            MSolicitudExtraFinan objSolicitudExtraFinan = new MSolicitudExtraFinan();
            BLLSolicitudExtraFinan bLLSolicitudPrestamo = new BLLSolicitudExtraFinan();
        int valordd,valorEntrega,valorDesembolso;
        valordd =Convert.ToInt32( ddlTipoExtra.SelectedValue);
        valorEntrega = Convert.ToInt32(ddlTipoEntrega.SelectedValue);
        valorDesembolso = Convert.ToInt32(ddlTipoDesembolso.SelectedValue);
        if(valordd==1)
        {
            objSolicitudExtraFinan.IdTipoExtraFinan =1;
        }
        else
        {
            objSolicitudExtraFinan.IdTipoExtraFinan = 2;
        }
        if (valorEntrega==1)
        {
            objSolicitudExtraFinan.IdTipoEntrega =1;
        }
        else
        {
            objSolicitudExtraFinan.IdTipoEntrega = 2;
        }
        if (valorDesembolso==1)
        {
            objSolicitudExtraFinan.IdTipoDesembolso = 1;
        }
        else
        {
            objSolicitudExtraFinan.IdTipoDesembolso = 2;
        }

            
            objSolicitudExtraFinan.IdCliente = Convert.ToInt32(txtDPI_cliente.Text);
            
            
            objSolicitudExtraFinan.Monto =Convert.ToDouble(txtMonto.Text);
            objSolicitudExtraFinan.UsuarioAlta = "kevin";

            bLLSolicitudPrestamo.insertaSolicitud(objSolicitudExtraFinan);
            _lbMensajeUsuario.Text = "solicitdud ingresada ";
            _lbMensajeUsuario.CssClass = "text-bold text-info";

        }
        catch(Exception ex)
        {
            _lbMensajeUsuario.Text = $"Error de ejecución. {ex.Message}";
            _lbMensajeUsuario.CssClass = "text-bold text-danger";
        }

        
    }
    private void SelectTipoEntrega()
    {
        ddlTipoEntrega.DataSource = Consulta("SELECT * FROM tipo_entrega");
        ddlTipoEntrega.DataTextField = "descripcion";
        ddlTipoEntrega.DataValueField = "id_tipo_entrega";
        ddlTipoEntrega.DataBind();
        ddlTipoEntrega.Items.Insert(0, new ListItem("[Elegir]", "0"));
    }
    private void SelectTipoDesembolso()
    {
        ddlTipoDesembolso.DataSource = Consulta("SELECT * FROM tipo_desembolso");
        ddlTipoDesembolso.DataTextField = "descripcion";
        ddlTipoDesembolso.DataValueField = "id_tipo_desembolso";
        ddlTipoDesembolso.DataBind();
        ddlTipoDesembolso.Items.Insert(0, new ListItem("[Elegir]", "0"));
    }
    private void SelectTipoExtra()
    {
        ddlTipoExtra.DataSource = Consulta("SELECT id_extrafinanciamiento,descripcion FROM tipo_extrafinanciamiento");
        ddlTipoExtra.DataTextField = "descripcion";
        ddlTipoExtra.DataValueField = "id_extrafinanciamiento";
        ddlTipoExtra.DataBind();
        ddlTipoExtra.Items.Insert(0, new ListItem("[Elegir]", "0"));
    }
    public DataSet Consulta(string srtSql)
    {
        SqlConnection sqlcon;
        sqlcon = new SqlConnection(ConfigurationManager.ConnectionStrings["conexion"].ToString());
        sqlcon.Open();
        SqlCommand cmd = new SqlCommand(srtSql, sqlcon);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sqlcon.Close();
        return ds;
    }

    protected void prueba(object sender, EventArgs e)
    {
        Labelprueba.Text = ddlTipoExtra.SelectedValue;
    }
}