using BLL;
using System;
using System.Linq;
using System.Text.RegularExpressions;

public partial class main_ConsultaCuentaDetalle : System.Web.UI.Page {
  protected BLLConsultaCuentaDetalle _obConsultaCuentaDetalle = null;
  protected void Page_Load(object sender, EventArgs e) {
    _lbMensajeUsuario.Text = "";
    _lbMensajeUsuario.CssClass = "";
    if(_txFechaBusqueda.Text == "") {
      _txFechaBusqueda.Text = DateTime.Now.ToString("MM/yyyy");
    }
    if (!IsPostBack) {
      string[] _vrPeriodoBusqueda = _txFechaBusqueda.Text.Split('/');
      string _stPeriodoBusqueda = _vrPeriodoBusqueda[1] + "-" + _vrPeriodoBusqueda[0] + "-01";
      CargarInformacionMovimientoCuenas(_stPeriodoBusqueda);
    }
  }
  private void CargarInformacionMovimientoCuenas(string _stPeriodoBusqueda) {
    try {
      if (Request.QueryString.AllKeys.Contains("nc")) {
        string _stNumeroCuenta = Request.QueryString["nc"];
        _obConsultaCuentaDetalle = new BLLConsultaCuentaDetalle();
        int _inEstadoEjecucion = _obConsultaCuentaDetalle.BuscarInformacionMovimientos(_stNumeroCuenta, _stPeriodoBusqueda);
        if(_inEstadoEjecucion == 0) {
          _rpMovimientoCuenta.DataSource = null;
          _rpMovimientoCuenta.DataBind();

          _rpMovimientoCuenta.DataSource = _obConsultaCuentaDetalle.Cuenta.MovimientosCuenta;
          _rpMovimientoCuenta.DataBind();

          _lbMensajeUsuario.Text = "Consulta realizada con éxito";
          _lbMensajeUsuario.CssClass = "text-bold text-info";
        }
        else if(_inEstadoEjecucion == 5) {
          _lbMensajeUsuario.Text = "No se encontraron datos según los criterios de busqueda";
          _lbMensajeUsuario.CssClass = "text-bold text-danger";
        }
        else {
          _lbMensajeUsuario.Text = "Error inesperado de la aplicación, ingrese nuevamente a la opción";
          _lbMensajeUsuario.CssClass = "text-bold text-danger";
        }
      }
      else {
        _lbMensajeUsuario.Text = "Parametros no encontrados, ingrese nuevamente a la opción";
        _lbMensajeUsuario.CssClass = "text-bold text-danger";
      }
    }
    catch(Exception ex) {
      _lbMensajeUsuario.Text = $"Error de ejecución. {ex.Message}";
      _lbMensajeUsuario.CssClass = "text-bold text-danger";
    }
  }
  protected void OnClicBuscarMovimiento(object sender, EventArgs e) {
    if (_txFechaBusqueda.Text != "") {
      bool _boValidaFecha = Regex.IsMatch(_txFechaBusqueda.Text, "[0-9]/[0-9]");
      if (_boValidaFecha) {
        string[] _vrPeriodoBusqueda = _txFechaBusqueda.Text.Split('/');
        string _stPeriodoBusqueda = _vrPeriodoBusqueda[1] + "-" + _vrPeriodoBusqueda[0] + "-01";
        CargarInformacionMovimientoCuenas(_stPeriodoBusqueda);
      }
      else {
        _lbMensajeUsuario.Text = "Formato de fecha para busqueda incorrecto";
        _lbMensajeUsuario.CssClass = "text-bold text-danger";
      }
    }
    else {
      _lbMensajeUsuario.Text = "Debe ingresar un periodo de consulta valido";
      _lbMensajeUsuario.CssClass = "text-bold text-danger";
    }
    System.Threading.Thread.Sleep(1000);
  }
}