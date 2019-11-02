using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using MODELS;
public partial class _Default : System.Web.UI.Page
{
  protected BLLTransferenciaListadoCuentaPropias _obTransferenciaListadoCuentaPropias = null;
  protected MUsuario objMUsuario = new MUsuario();
  protected void Page_Load(object sender, EventArgs e)
  {
    if(Session["atributos_usuario"] == null) {
      Response.Redirect("/security/InicioSesion.aspx");
    }
    objMUsuario = (MUsuario)Session["atributos_usuario"];
    _lbMensajeUsuario.Text = "";
    _lbMensajeUsuario.CssClass = "";
    CargarInformacion();
  }
  private void CargarInformacion() {
    try {
      int _inEstadoEjecucion = 0;
      _obTransferenciaListadoCuentaPropias = new BLLTransferenciaListadoCuentaPropias();
      _inEstadoEjecucion = _obTransferenciaListadoCuentaPropias.BuscarInformacionCuentas(objMUsuario.idCliente);
      if (_inEstadoEjecucion == 0) {
        _rpListadoCuentas.DataSource = null;
        _rpListadoCuentas.DataBind();

        _rpListadoCuentas.DataSource = _obTransferenciaListadoCuentaPropias._liCuentas;
        _rpListadoCuentas.DataBind();
      }
      else {
        _lbMensajeUsuario.Text = "No se encontraron datos para mostrar";
        _lbMensajeUsuario.CssClass = "text-bold text-danger";
      }
    }
    catch (Exception ex) {
      _lbMensajeUsuario.Text = $"Error de ejecución. {ex.Message}";
      _lbMensajeUsuario.CssClass = "text-bold text-danger";
    }
  }
  protected void OnItemDataBoundCuentas(object sender, RepeaterItemEventArgs e) {
    HyperLink _hyCuentaTransferencia = (HyperLink)e.Item.FindControl("_hyNumeroCuenta");
    HyperLink _hyPropietarioTransferencia = (HyperLink)e.Item.FindControl("_hyPropietario");
    MCuenta _obCuenta = (MCuenta)e.Item.DataItem;
    if (_obCuenta != null) {
      if (_hyCuentaTransferencia != null) {
        _hyCuentaTransferencia.NavigateUrl = $"main/ConsultaCuentaEncabezado.aspx?nc={_obCuenta.NumeroCuenta}";
      }
      else {
        throw new Exception("No se logro encontrar información de la cuenta");
      }
      if (_hyPropietarioTransferencia != null) {
        _hyPropietarioTransferencia.NavigateUrl = $"main/ConsultaCuentaEncabezado.aspx?nc={_obCuenta.NumeroCuenta}";
      }
      else {
        throw new Exception("No se logro encontrar información del propietario");
      }
    }
    else {
      throw new Exception("No se lograron encontrar los datos cargados");
    }
  }
}