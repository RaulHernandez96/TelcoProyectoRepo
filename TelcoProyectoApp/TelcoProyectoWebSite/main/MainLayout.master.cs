using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class main_MainLayout : System.Web.UI.MasterPage
{
  protected void Page_Load(object sender, EventArgs e)
  {
        DataTable dt = (DataTable)Session["permisos_forma"];

        foreach (DataRow dtRow in dt.Rows)
        {

            literalMenu.Text += "<li><a href = "+ ResolveUrl("~/" + dtRow["nombre_forma"].ToString() )+ "><i class='fa fa-calendar'></i><span>" + dtRow["descripcion"] + "</span><span class='pull-right-container'><small class='label pull-right bg-red'>3</small><small class='label pull-right bg-blue'>17</small></span></a></li>";
        }
    
  }
}
