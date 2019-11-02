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

public partial class main_WSolicitudTarjetaCredito : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SelectFinan();
            SelectTipoCredito();
            SelectTipoEntrega();
            SelectTipoDesembolso();
            SelectTipoCategoria();
            SelectTipoTarjeta();
        }

    }
    private void SelectTipoTarjeta()
    {
        ddlTipoTarjeta.DataSource = Consulta("SELECT id_tipo_tarjeta,descripcion_tipo_tarjeta FROM tipo_tarjeta");
        ddlTipoTarjeta.DataTextField = "descripcion_tipo_tarjeta";
        ddlTipoTarjeta.DataValueField = "id_tipo_tarjeta";
        ddlTipoTarjeta.DataBind();
        ddlTipoTarjeta.Items.Insert(0, new ListItem("[Elegir]", "0"));
    }
    private void SelectTipoCategoria()
    {
        ddlCategoriaTarjeta.DataSource = Consulta("SELECT id_catergoria_tarjeta,descripcion from categoria_tarjeta");
        ddlCategoriaTarjeta.DataTextField = "descripcion";
        ddlCategoriaTarjeta.DataValueField = "id_catergoria_tarjeta";
        ddlCategoriaTarjeta.DataBind();
        ddlCategoriaTarjeta.Items.Insert(0, new ListItem("[Elegir]", "0"));
    }
    private void SelectFinan()
    {
        ddlIdFinan.DataSource = Consulta("SELECT id_financiera,nombre FROM catalogo_financiera");
        ddlIdFinan.DataTextField = "nombre";
        ddlIdFinan.DataValueField = "id_financiera";
        ddlIdFinan.DataBind();
        ddlIdFinan.Items.Insert(0, new ListItem("[Elegir]", "0"));
    }
    private void SelectTipoCredito()
    {
        ddlTipoCredito.DataSource = Consulta("SELECT * FROM tipo_credito");
        ddlTipoCredito.DataTextField = "descripcion";
        ddlTipoCredito.DataValueField = "id_tipo_credito";
        ddlTipoCredito.DataBind();
        ddlTipoCredito.Items.Insert(0, new ListItem("[Elegir]", "0"));
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

    protected void btnInsertar_Click(object sender, EventArgs e)
    {
        try
        {
            MSolicitudTarjetaCredito objSolicitudTarjeta = new MSolicitudTarjetaCredito();
            BLLSolicitudTarjetaCredito bLLSolicitudTarjeta = new BLLSolicitudTarjetaCredito();

            objSolicitudTarjeta.IdFinanciera = Convert.ToInt32(ddlIdFinan.SelectedValue);
            objSolicitudTarjeta.IdCliente = Convert.ToInt32(txtDPI_cliente.Text);
            objSolicitudTarjeta.IdTipoCredtio = Convert.ToInt32(ddlTipoCredito.SelectedValue);
            objSolicitudTarjeta.IdTipoTarjeta = Convert.ToInt32(ddlTipoTarjeta.SelectedValue);
            objSolicitudTarjeta.IdTipoEntrega = Convert.ToInt32(ddlTipoEntrega.SelectedValue);
            objSolicitudTarjeta.IdTipoDesembolso = Convert.ToInt32(ddlTipoDesembolso.SelectedValue);
            objSolicitudTarjeta.Limite = Convert.ToDouble(txtlimite.Text);
            objSolicitudTarjeta.HistorialCompra = txtHistorialCompra.Text;
            objSolicitudTarjeta.IdCategoriaTarjeta = Convert.ToInt32(ddlCategoriaTarjeta.SelectedValue);

            bLLSolicitudTarjeta.insertarSolicitud(objSolicitudTarjeta);
            _lbMensajeUsuario.Text = "solicitdud ingresada ";
            _lbMensajeUsuario.CssClass = "text-bold text-info";
        }
        catch(Exception ex)
        {
            _lbMensajeUsuario.Text = $"Error de ejecución. {ex.Message}";
            _lbMensajeUsuario.CssClass = "text-bold text-danger";
        }
        


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
}