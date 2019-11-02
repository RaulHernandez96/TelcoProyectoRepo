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
        string vTreeview = string.Empty;
        string vNombreMenu = string.Empty;
        string vNombreMenuAnt = string.Empty;
        string vOpciones = string.Empty;
        string vMenu = string.Empty;
        int vContador = 0;

        literalMenu.Text = string.Empty;
        foreach (DataRow dtRow in dt.Rows)
        {

            //vTreeview = dtRow["esTreeview"].ToString();


            //if (vTreeview == "1")
            //{

            //    if (vContador <=1)
            //    {
            //        vNombreMenu = dtRow["nombre_menu"].ToString();
            //        vNombreMenuAnt = dtRow["nombre_menu"].ToString();

            //    }



            //    if (vNombreMenu == vNombreMenuAnt)
            //    {
            //        vOpciones += "<li><a href = " + ResolveUrl("~/" + dtRow["nombre_forma"].ToString()) + " ><i class='fa fa-circle-o'></i>" + dtRow["descripcion"].ToString() + "</a></li>";
            //    }


            //    if (vNombreMenu != dtRow["nombre_menu"].ToString() || vContador == 0)
            //    {

            //        literalMenu.Text += "<li class='treeview'> " +
            //                 "<a href = '#'> " +
            //                     "<i class='fa fa-edit'></i> " +
            //                    "<span>" + dtRow["nombre_menu"].ToString() + "</span> " +
            //                    "<span class='pull-right-container'> " +
            //                        "<i class='fa fa-angle - left pull - right'></i> " +
            //                    "</span> " +
            //                "</a> " +
            //                "<ul class='treeview-menu'> " + vOpciones + "</ul> " +
            //        "</li> ";

            //        vOpciones = string.Empty;
            //        vContador = 0;


            //    }
            //    else if(vNombreMenu == dtRow["nombre_menu"].ToString() || vContador > 0)
            //    {
            //        literalMenu.Text += "<li class='treeview'> " +
            //                 "<a href = '#'> " +
            //                     "<i class='fa fa-edit'></i> " +
            //                    "<span>" + dtRow["nombre_menu"].ToString() + "</span> " +
            //                    "<span class='pull-right-container'> " +
            //                        "<i class='fa fa-angle - left pull - right'></i> " +
            //                    "</span> " +
            //                "</a> " +
            //                "<ul class='treeview-menu'> " + vOpciones + "</ul> " +
            //        "</li> ";

            //        vOpciones = string.Empty;
            //        vContador = 0;
            //    }
            //    vContador++;
            //    vNombreMenu = dtRow["nombre_menu"].ToString();



            //    //<li><a href = 'pages/layout/top-nav.html' >< i class='fa fa-circle-o'></i>Top Navigation</a></li>
            //    //<li><a href = 'pages/layout/boxed.html' >< i class='fa fa-circle-o'></i>Boxed</a></li>
            //    //<li><a href = 'pages/layout/fixed.html' >< i class='fa fa-circle-o'></i>Fixed</a></li>
            //    //<li><a href = 'pages/layout/collapsed-sidebar.html' >< i class='fa fa-circle-o'></i>Collapsed Sidebar</a></li>

            //}
            //else
            //{

            literalMenu.Text += "<li><a href = " + ResolveUrl("~/" + dtRow["nombre_forma"].ToString()) + "><i class='fa fa-edit'></i><span>" + dtRow["descripcion"] + "</span><span class='pull-right-container'><i class='fa fa-angle - left pull - right'></i></small></span></a></li>";

            //}


        }

    }
}
