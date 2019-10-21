using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main_MainLayout : System.Web.UI.MasterPage
{
  protected void Page_Load(object sender, EventArgs e)
  {
        literalMenu.Text = "<li><a href = 'pages/calendar.html'><i class='fa fa-calendar'></i><span>PRUEBA HENRY</span><span class='pull-right-container'><small class='label pull-right bg-red'>3</small><small class='label pull-right bg-blue'>17</small></span></a></li>";
  }
}
