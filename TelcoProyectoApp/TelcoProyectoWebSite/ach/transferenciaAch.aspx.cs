using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MODELS;
using BLL;
public partial class ach_transferenciaAch : System.Web.UI.Page
{
    private BLLAch objBLLAch = new BLLAch();
    private MTransferenciaACH objMTransAch = new MTransferenciaACH();
    protected void Page_Load(object sender, EventArgs e)
    {
        cboCuentaOrigen.DataSource = objBLLAch.listaCuentas(((MUsuario)Session["atributos_usuario"]).idCliente, "1");
        cboCuentaOrigen.DataValueField = "id_cuenta";
        cboCuentaOrigen.DataTextField = "det_cuenta";
        cboCuentaOrigen.DataBind();

        cboCuentaDestino.DataSource = objBLLAch.listaCuentas(((MUsuario)Session["atributos_usuario"]).idCliente, "2");
        cboCuentaDestino.DataValueField = "id_cuenta_iban";
        cboCuentaDestino.DataTextField = "det_cuenta";
        cboCuentaDestino.DataBind();

        cboMoneda.DataSource = objBLLAch.listaMoneda();
        cboMoneda.DataValueField = "id_moneda";
        cboMoneda.DataTextField = "descripcion";
        cboMoneda.DataBind();
    }



    protected void cboCuentaOrigen_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        objMTransAch.idCuentaPrincipal = Convert.ToInt32(cboCuentaOrigen.SelectedValue.ToString());
        objMTransAch.idCuentaRelacion = Convert.ToInt32(cboCuentaDestino.SelectedValue.ToString());
        objMTransAch.idMoneda = Convert.ToInt32(cboMoneda.SelectedValue.ToString());
        objMTransAch.idTipoTransferencia = 1;
        objMTransAch.monto = Convert.ToDouble(txtMonto.Text);
        objMTransAch.descripcion = txtDescripcion.Text;

        objBLLAch.transferenciaAch(objMTransAch);

    }
}