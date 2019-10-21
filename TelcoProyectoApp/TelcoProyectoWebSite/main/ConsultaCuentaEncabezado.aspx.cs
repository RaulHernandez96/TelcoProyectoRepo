using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

public partial class main_ConsultaCuentaEncabezado : System.Web.UI.Page {

  protected BLLConsultaCuentaEncabezado _obConsultaCuentaEncabezado = null;
  protected void Page_Load(object sender, EventArgs e) {
    _lbMensajeUsuario.Text = "";
    _lbMensajeUsuario.CssClass = "";
    CargaInformacionCuentaPantalla();
  }
  private void CargaInformacionCuentaPantalla() {
    try {
      if (Request.QueryString.AllKeys.Contains("nc")) {
        string _numeroCuenta = Request.QueryString["nc"];
        _obConsultaCuentaEncabezado = new BLLConsultaCuentaEncabezado();
        int _inEstadoEjecucion = _obConsultaCuentaEncabezado.BuscarInformacionCuenta(_numeroCuenta);
        if(_inEstadoEjecucion == 0) {

          _lbPropietarioCuenta.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? _obConsultaCuentaEncabezado.Cuenta.Propietario : "#Sin datos#" : "#Sin datos#";

          _lbTipoCuenta.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? _obConsultaCuentaEncabezado.Cuenta.TipoCuenta : "#Sin datos#" : "#Sin datos#";

          _lbTipoMoneda.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? _obConsultaCuentaEncabezado.Cuenta.TipoMoneda : "#Sin datos#" : "#Sin datos#";

          _lbFechaCreacion.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? _obConsultaCuentaEncabezado.Cuenta.FechaCreacion.ToString("dd/MM/yyyy") : "#Sin datos#" : "#Sin datos#";

          _lbSaldoDisponible.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.TotalDisponible) 
            : "#Sin datos#" : "#Sin datos#";

          _lbSaldoEfectivo.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.SaldoEfectivo)
            : "#Sin datos#" : "#Sin datos#";

          _lbSaldoCheques.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.SaldoCheque)
            : "#Sin datos#" : "#Sin datos#";

          _lbSaldoReserva.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.SaldoReserva)
            : "#Sin datos#" : "#Sin datos#";

          _lbSaldoContable.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.SaldoContable)
            : "#Sin datos#" : "#Sin datos#";

          _lbSaldoInicial.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.SaldoInicial)
            : "#Sin datos" : "#Sin datos#";

          _lbInteresesMes.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.InteresMes)
            : "#Sin datos#" : "#Sin datos#";

          _lbDepositosATM.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.DepositoATM)
            : "#Sin datos#" : "#Sin datos#";

          _lbSaldoBloqueado.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.SaldoBloqueado)
            : "#Sin datos#" : "#Sin datos#";

          _lb24Horas.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.Reserva24Horas)
            : "#Sin datos#" : "#Sin datos#";

          _lb48Horas.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.Reserva48Horas)
            : "#Sin datos#" : "#Sin datos#";

          _lb72Horas.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.Reserva72Horas)
            : "#Sin datos#" : "#Sin datos#";

          _lbGirosExterior.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.ReservaGirosExterior)
            : "#Sin datos#" : "#Sin datos#";

          _lbInteresesSobregiro.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.InteresPorSobregiro)
            : "#Sin datos#" : "#Sin datos#";

          _lbSobregiroAutorizado.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.SobregiroAutorizado)
            : "#Sin datos#" : "#Sin datos#";

          _lbTasaSobregiro.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.TasaDeSobregiro)
            : "#Sin datos#" : "#Sin datos#";

          _lbIntereseSobregiroAcumulado.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.InteresSobregiroAcumulado)
            : "#Sin datos#" : "#Sin datos#";

          _lbExpiracionSobregiro.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? _obConsultaCuentaEncabezado.Cuenta.ExpiracionSobregiro.ToString("dd/MM/yyyy") : "#Sin datos#" 
            : "#Sin datos#";

          _lbSobregiroDisponible.Text = _obConsultaCuentaEncabezado != null
            ? _obConsultaCuentaEncabezado.Cuenta != null
            ? string.Format("{0:0,0.00}", _obConsultaCuentaEncabezado.Cuenta.SobregiroDisponible)
            : "#Sin datos#" : "#Sin datos#";

          _lbMensajeUsuario.Text = "Consulta realizada con éxito";
          _lbMensajeUsuario.CssClass = "text-bold text-info";
        }
        else if(_inEstadoEjecucion == 5) {
          _lbMensajeUsuario.Text = "No se encontraron datos según los criterios de busqueda";
          _lbMensajeUsuario.CssClass = "text-bold text-danger";
          _btVerEstadoCuenta.Enabled = false;
        }
        else {
          _lbMensajeUsuario.Text = "Error inesperado de la aplicación, ingrese nuevamente a la opción";
          _lbMensajeUsuario.CssClass = "text-bold text-danger";
          _btVerEstadoCuenta.Enabled = false;
        }
      }
      else {
        _lbMensajeUsuario.Text = "Parametros no encontrados, ingrese nuevamente a la opción";
        _lbMensajeUsuario.CssClass = "text-bold text-danger";
        _btVerEstadoCuenta.Enabled = false;
      }
    }
    catch(Exception ex) {
      _lbMensajeUsuario.Text = $"Error de ejecución. {ex.Message}";
      _lbMensajeUsuario.CssClass = "text-bold text-danger";
      _btVerEstadoCuenta.Enabled = false;
    }
  }

  protected void OnClicVerEstadoCuenta(object sender, EventArgs e) {
    if(_obConsultaCuentaEncabezado != null) {
      if(_obConsultaCuentaEncabezado.Cuenta != null) {
        Response.Redirect($"ConsultaCuentaDetalle.aspx?nc={_obConsultaCuentaEncabezado.Cuenta.NumeroCuenta}");
      }
      else {
        _lbMensajeUsuario.Text = "No se pudo enviar los parametros necesario, ingrese nuevamente a la opción";
        _lbMensajeUsuario.CssClass = "text-bold text-danger";
      }
    }
    else {
      _lbMensajeUsuario.Text = "No se pudo enviar los parametros necesario, ingrese nuevamente a la opción";
      _lbMensajeUsuario.CssClass = "text-bold text-danger";
    }
  }
}