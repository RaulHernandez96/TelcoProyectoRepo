using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MODELS;
using BLL;
public partial class ach_agregaAch : System.Web.UI.Page
{
    MCuentaIban objCuenta = new MCuentaIban();
    BLLAch objAch = new BLLAch();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAgregaCuenta_Click(object sender, EventArgs e)
    {
        llenaEntidad();

        if (objAch.agregaCuentaAch(objCuenta) == "1")
        {
            txtDesCuenta.Text = string.Empty;
            txtNombreCuenta.Text = string.Empty;
            txtNumCuenta.Text = string.Empty;
            lblMsj.Text = "Cuenta asociada correctamente";
            lblMsj.CssClass = "text-bold";
        }
        else
        {
            lblMsj.CssClass = "text-bold text-danger";
            lblMsj.Text = "El número de cuenta ya existe";
        }
    }
    public void llenaEntidad()
    {
        objCuenta.descripcionCuenta = txtDesCuenta.Text;
        objCuenta.nombreCuenta = txtNombreCuenta.Text;
        objCuenta.numeroCuenta = txtNumCuenta.Text;
        objCuenta.idClienteRef = ((MUsuario)Session["atributos_usuario"]).idCliente;
    }
}