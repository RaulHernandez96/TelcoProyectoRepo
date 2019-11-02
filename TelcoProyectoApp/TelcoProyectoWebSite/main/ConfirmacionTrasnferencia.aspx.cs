using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main_ConfirmacionTrasnferencia : System.Web.UI.Page {
  BLLTransferenciaCuentasPropias _obTransferenciaCuentasPropias = null;
  BLLConsultaCuentaEncabezado _obConsultaCuentaEncabezadoOrigen = null;
  BLLConsultaCuentaEncabezado _obConsultaCuentaEncabezadoDestino = null;
  protected void Page_Load(object sender, EventArgs e) {
    _lbMensajeUsuario.Text = "";
    _lbMensajeUsuario.CssClass = "";
    CargarInformacionTransferencia();
  }
  private void CargarInformacionTransferencia() {
    try {
      if (Request.QueryString.AllKeys.Contains("nt")) {
        string _stNumeroTransaccion = Request.QueryString["nt"];
        _obTransferenciaCuentasPropias = new BLLTransferenciaCuentasPropias();
        int _inEstadoEjecucion = _obTransferenciaCuentasPropias.BuscarInformacionTransferencia(_stNumeroTransaccion);
        if(_inEstadoEjecucion == 0) {
          _obConsultaCuentaEncabezadoOrigen = new BLLConsultaCuentaEncabezado();
          _inEstadoEjecucion = _obConsultaCuentaEncabezadoOrigen.BuscarInformacionCuenta(_obTransferenciaCuentasPropias.Transferencia.CuentaOrigen);
          if(_inEstadoEjecucion == 0) {
            _obConsultaCuentaEncabezadoDestino = new BLLConsultaCuentaEncabezado();
            _inEstadoEjecucion = _obConsultaCuentaEncabezadoDestino.BuscarInformacionCuenta(_obTransferenciaCuentasPropias.Transferencia.CuentaDestino);
            if(_inEstadoEjecucion == 0) {
              _lbTipoCuentaOrigen.Text = _obConsultaCuentaEncabezadoOrigen != null
                ? _obConsultaCuentaEncabezadoOrigen.Cuenta != null 
                ? _obConsultaCuentaEncabezadoOrigen.Cuenta.TipoCuenta : "#N/A#" : "#N/A#";

              _lbTipoMonedaOrigen.Text = _obConsultaCuentaEncabezadoOrigen != null
                ? _obConsultaCuentaEncabezadoOrigen.Cuenta != null
                ? _obConsultaCuentaEncabezadoOrigen.Cuenta.TipoMoneda : "#N/A#" : "#N/A#";

              _lbInformacionCuentaOrigen.Text = (_obConsultaCuentaEncabezadoOrigen != null
                ? _obConsultaCuentaEncabezadoOrigen.Cuenta != null
                ? _obConsultaCuentaEncabezadoOrigen.Cuenta.NumeroCuenta : "#N/A#" : "#N/A#") + "<br>" + 
                (_obConsultaCuentaEncabezadoOrigen != null
                ? _obConsultaCuentaEncabezadoOrigen.Cuenta != null
                ? _obConsultaCuentaEncabezadoOrigen.Cuenta.Propietario : "#N/A#" : "#N/A#");

              _lbTipoCuentaDestino.Text = _obConsultaCuentaEncabezadoOrigen != null
                ? _obConsultaCuentaEncabezadoOrigen.Cuenta != null
                ? _obConsultaCuentaEncabezadoOrigen.Cuenta.TipoCuenta : "#N/A#" : "#N/A#";

              _lbTipoMonedaDestino.Text = _obConsultaCuentaEncabezadoOrigen != null
                ? _obConsultaCuentaEncabezadoOrigen.Cuenta != null
                ? _obConsultaCuentaEncabezadoOrigen.Cuenta.TipoMoneda : "#N/A#" : "#N/A#";

              _lbInformacionCuentaDestino.Text = (_obConsultaCuentaEncabezadoOrigen != null
                ? _obConsultaCuentaEncabezadoOrigen.Cuenta != null
                ? _obConsultaCuentaEncabezadoOrigen.Cuenta.NumeroCuenta : "#N/A#" : "#N/A#") + "<br>" +
                (_obConsultaCuentaEncabezadoOrigen != null
                ? _obConsultaCuentaEncabezadoOrigen.Cuenta != null
                ? _obConsultaCuentaEncabezadoOrigen.Cuenta.Propietario : "#N/A#" : "#N/A#");

              _lbMontoTrasnferencia.Text = _obTransferenciaCuentasPropias != null
                ? _obTransferenciaCuentasPropias.Transferencia != null
                ? string.Format("{0:0,0.00}", _obTransferenciaCuentasPropias.Transferencia.MontoTransferencia) : "#N/A#" : "#N/A#";

              if(_obTransferenciaCuentasPropias.Transferencia.EstadoTransferencia != 1) {
                _btConfirmacion.Enabled = false;
                _btCancelar.Enabled = false;
              }
            }
            else {
              _lbMensajeUsuario.Text = $"No se pudo encontrar la información de la cuenta destino, comuniquese con soporte técnico.";
              _lbMensajeUsuario.CssClass = "text-bold text-danger";
              _btConfirmacion.Enabled = false;
              _btCancelar.Enabled = false;
            }
          }
          else {
            _lbMensajeUsuario.Text = $"No se pudo encontrar información de la cuenta origen, comuniquese con soporte técnico.";
            _lbMensajeUsuario.CssClass = "text-bold text-danger";
            _btConfirmacion.Enabled = false;
            _btCancelar.Enabled = false;
          }
        }
        else {
          _lbMensajeUsuario.Text = $"No se pudo encontrar la información de la transferencia, comuniquese con soporte técnico.";
          _lbMensajeUsuario.CssClass = "text-bold text-danger";
          _btConfirmacion.Enabled = false;
          _btCancelar.Enabled = false;
        }
      }
      else {
        _lbMensajeUsuario.Text = $"Parametro no encontrados, comuniquese con soporte técnico.";
        _lbMensajeUsuario.CssClass = "text-bold text-danger";
        _btConfirmacion.Enabled = false;
        _btCancelar.Enabled = false;
      }
    }
    catch(Exception ex) {
      _lbMensajeUsuario.Text = $"Error de aplicación. {ex.Message}";
      _lbMensajeUsuario.CssClass = "text-bold text-danger";
      _btConfirmacion.Enabled = false;
      _btCancelar.Enabled = false;
    }
  }
  protected void OnClicConfirmar(object sender, EventArgs e) {
    try {
      if (Request.QueryString.AllKeys.Contains("nt")) {
        string _stNumeroTransaccion = Request.QueryString["nt"];
        _obTransferenciaCuentasPropias = new BLLTransferenciaCuentasPropias();
        int _inEstadoEjecucion = _obTransferenciaCuentasPropias.ConfirmarTransferencia(_stNumeroTransaccion);
        if (_inEstadoEjecucion == 0) {
          _lbMensajeUsuario.Text = $"Se realizo la transferencia con éxito";
          _lbMensajeUsuario.CssClass = "text-bold text-success";
          _btConfirmacion.Enabled = false;
          _btCancelar.Enabled = false;
        }
        else {
          _lbMensajeUsuario.Text = $"No se pudo confirmar la transferencia, comuniquese con soporte técnico.";
          _lbMensajeUsuario.CssClass = "text-bold text-danger";
          _btConfirmacion.Enabled = false;
          _btCancelar.Enabled = false;
        }
      }
    }
    catch(Exception ex) {
      _lbMensajeUsuario.Text = $"Error de aplicación. {ex.Message}";
      _lbMensajeUsuario.CssClass = "text-bold text-danger";
      _btConfirmacion.Enabled = false;
      _btCancelar.Enabled = false;
    }
  }

  protected void OnClicCancelar(object sender, EventArgs e) {
    try {
      if (Request.QueryString.AllKeys.Contains("nt")) {
        string _stNumeroTransaccion = Request.QueryString["nt"];
        _obTransferenciaCuentasPropias = new BLLTransferenciaCuentasPropias();
        int _inEstadoEjecucion = _obTransferenciaCuentasPropias.CancelaTransferencia(_stNumeroTransaccion);
        if (_inEstadoEjecucion == 0) {
          _lbMensajeUsuario.Text = $"Se cancelo la transferencia con éxito";
          _lbMensajeUsuario.CssClass = "text-bold text-success";
          _btConfirmacion.Enabled = false;
          _btCancelar.Enabled = false;
        }
        else {
          _lbMensajeUsuario.Text = $"No se pudo confirmar la transferencia, comuniquese con soporte técnico.";
          _lbMensajeUsuario.CssClass = "text-bold text-danger";
          _btConfirmacion.Enabled = false;
          _btCancelar.Enabled = false;
        }
      }
    }
    catch (Exception ex) {
      _lbMensajeUsuario.Text = $"Error de aplicación. {ex.Message}";
      _lbMensajeUsuario.CssClass = "text-bold text-danger";
      _btConfirmacion.Enabled = false;
      _btCancelar.Enabled = false;
    }
  }
}