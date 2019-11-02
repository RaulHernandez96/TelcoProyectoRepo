using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MODELS;
public partial class _Default : System.Web.UI.Page
{
  protected void Page_Load(object sender, EventArgs e)
  {
        MUsuario objMUsuario = new MUsuario();
        objMUsuario = (MUsuario)Session["atributos_usuario"];


        lblEjemplo.Text = "Nombre: " + objMUsuario.cliente.primerNombre + " Usuario:" + objMUsuario.usuario;
  }
}