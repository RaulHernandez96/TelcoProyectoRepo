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

public partial class main_Wsolicitud_prestamo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            SelectFinan();
            SelectTipoCredito();
            SelectTipoEntrega();
            SelectTipoDesembolso();
        }

    }
    private void SelectFinan()
    {
        ddlFinanciera.DataSource = Consulta("SELECT id_financiera,nombre FROM catalogo_financiera");
        ddlFinanciera.DataTextField = "nombre";
        ddlFinanciera.DataValueField = "id_financiera";
        ddlFinanciera.DataBind();
        ddlFinanciera.Items.Insert(0, new ListItem("[Elegir]", "0"));
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
            MSolicitudPrestamo objMSolicitudPrestamo = new MSolicitudPrestamo();
            BLLSolicitudPrestamo bLLSolicitudPrestamo = new BLLSolicitudPrestamo();

            //objMSolicitudPrestamo.idFinanciera = Convert.ToInt32(txtid_financiera.Text);
            objMSolicitudPrestamo.idFinanciera = Convert.ToInt32(ddlFinanciera.SelectedValue);
            objMSolicitudPrestamo.dpiCliente = Convert.ToInt32(txtDPI_cliente.Text);
            objMSolicitudPrestamo.idTipoCredito = Convert.ToInt32(ddlTipoCredito.SelectedValue);
            objMSolicitudPrestamo.idTipoEntrega = Convert.ToInt32(ddlTipoEntrega.SelectedValue);
            objMSolicitudPrestamo.idTipoDesembolso = Convert.ToInt32(ddlTipoDesembolso.SelectedValue);
            objMSolicitudPrestamo.capital = Convert.ToDouble(txtCapital.Text);
            objMSolicitudPrestamo.plazo = Convert.ToInt32(txtPlazo.Text);
            objMSolicitudPrestamo.garantia = txtGarantia.Text;
            objMSolicitudPrestamo.utilidadDinero = txtUtilidad_dinero.Text;
            objMSolicitudPrestamo.historialCompras = txtHistorial_compras.Text;
            objMSolicitudPrestamo.proyeccionPago = txtProyeccion.Text;
            bLLSolicitudPrestamo.insertaSolicitud(objMSolicitudPrestamo);
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
        SqlCommand cmd = new SqlCommand(srtSql,sqlcon);
        SqlDataAdapter da = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        da.Fill(ds);
        sqlcon.Close();
        return ds;
    }
}