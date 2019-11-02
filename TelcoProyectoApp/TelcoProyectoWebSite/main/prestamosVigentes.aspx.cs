using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MODELS;
using BLL;
public partial class main_prestamosVigentes : System.Web.UI.Page
{
    private BLLReportePrestamo objBLLPrestamo = new BLLReportePrestamo();
    protected void Page_Load(object sender, EventArgs e)
    {
        grdPrestamosVigentes.DataSource = objBLLPrestamo.prestamoVigente(((MUsuario)Session["atributos_usuario"]).idCliente);
        grdPrestamosVigentes.DataBind();
    }
}