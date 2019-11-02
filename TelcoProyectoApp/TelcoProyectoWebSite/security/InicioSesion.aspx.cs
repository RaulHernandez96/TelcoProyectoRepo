using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MODELS;
using BLL;
using System.Data;
public partial class security_Default : System.Web.UI.Page
{
    private DataTable dt;
    private BLLLogin objBLLLogin;
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void _btInicioSesion_Click(object sender, EventArgs e)
    {
        if (_txUsuario.Text != "" && _txContrasenia.Text != "")
        {
            dt = new DataTable();
            dt = BLLLogin.permisos(1, _txUsuario.Text, _txContrasenia.Text);
         //   MLogin objLogin = null;
            if(dt.Rows.Count>0)
            {
                objBLLLogin = new BLLLogin();
                Session["atributos_usuario"] = objBLLLogin.atributosUsuario(Convert.ToInt32(dt.Rows[0]["id_usuario"].ToString()));
                Session["permisos_forma"] = dt;
                Response.Redirect(ResolveUrl("~/" + "Default.aspx"));


            }

         }
    }
}