using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MODELS;

public partial class main_MainLayout : System.Web.UI.MasterPage {
  protected void Page_Load(object sender, EventArgs e) {
    if (Session["atributos_usuario"] == null) {
      Response.Redirect("/security/InicioSesion.aspx");
    }
    if (Session["permisos_forma"] == null) {
      Response.Redirect("/security/InicioSesion.aspx");
    }
    MUsuario _obUsuario = (MUsuario)Session["atributos_usuario"];
    _lbNombreUsuario.Text = _obUsuario.cliente.primerNombre + " " + _obUsuario.cliente.segundoNombre + " " + _obUsuario.cliente.primerApellido + " " + _obUsuario.cliente.segundoApellido;

    DataTable dt = (DataTable)Session["permisos_forma"];

    foreach (DataRow dtRow in dt.Rows) {
      literalMenu.Text += "<li><a href = " + ResolveUrl("~/" + dtRow["nombre_forma"].ToString()) + "><i class='fa fa-calendar'></i><span>" + dtRow["descripcion"] + "</span><span class='pull-right-container'><small class='label pull-right bg-red'>3</small><small class='label pull-right bg-blue'>17</small></span></a></li>";
    }

  }
}
