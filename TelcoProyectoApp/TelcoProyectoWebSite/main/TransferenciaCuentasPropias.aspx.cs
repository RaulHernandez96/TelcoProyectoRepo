using BLL;
using MODELS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class main_TransferenciaCuentasPropias : System.Web.UI.Page {
  protected BLLTransferenciaListadoCuentaPropias _obTransferenciaListadoCuentaPropias = null;
  protected BLLTransferenciaCuentasPropias _obTransferenciaCuentasPropias = null;
  protected void Page_Load(object sender, EventArgs e) {
    _lbMensajeUsuario.Text = "";
    _lbMensajeUsuario.CssClass = "";
    if (!IsPostBack) {
      CargarInformacionTransferencia();
    }
  }
  private void CargarInformacionTransferencia() {
    try {
      _obTransferenciaListadoCuentaPropias = new BLLTransferenciaListadoCuentaPropias();
      int _inEstadoEjecucion = _obTransferenciaListadoCuentaPropias.BuscarInformacionCuentas(1);
      if (_inEstadoEjecucion == 0) {
        _obTransferenciaListadoCuentaPropias._liCuentas.ForEach(delegate (MCuenta _obCuenta) {
          _obCuenta.GenerarNombresPublicos();
        });
        _dlCuentaOrigen.DataSource = _obTransferenciaListadoCuentaPropias._liCuentas;
        _dlCuentaOrigen.DataValueField = "NumeroCuenta";
        _dlCuentaOrigen.DataTextField = "NombrePublico";
        _dlCuentaOrigen.DataBind();

        if (Request.QueryString.AllKeys.Contains("nc")) {
          _dlCuentaOrigen.SelectedValue = Request.QueryString["nc"];
        }

        _dlCuentaDestino.DataSource = _obTransferenciaListadoCuentaPropias._liCuentas;
        _dlCuentaDestino.DataValueField = "NumeroCuenta";
        _dlCuentaDestino.DataTextField = "NombrePublico";
        _dlCuentaDestino.DataBind();
      }
      else if (_inEstadoEjecucion == 5) {
        _lbMensajeUsuario.Text = $"No se encontrason datos, vuelva a ingresar a la opción.";
        _lbMensajeUsuario.CssClass = "text-bold text-danger";
        _btValidarTransferencia.Enabled = false;
      }
      else {
        _lbMensajeUsuario.Text = $"Error inesperado de ejecución, vuelva a ingresar a la opción.";
        _lbMensajeUsuario.CssClass = "text-bold text-danger";
        _btValidarTransferencia.Enabled = false;
      }
    }
    catch (Exception ex) {
      _lbMensajeUsuario.Text = $"Error de aplicación. {ex.Message}";
      _lbMensajeUsuario.CssClass = "text-bold text-danger";
      _btValidarTransferencia.Enabled = false;
    }
  }

  protected void OnClicValidar(object sender, EventArgs e) {
    try {
      if (_dlCuentaOrigen.SelectedValue != _dlCuentaDestino.SelectedValue) {
        if (Convert.ToDouble(_txMontoTransferir.Text) > 0) {
          _obTransferenciaCuentasPropias = new BLLTransferenciaCuentasPropias();
          if (_dlCalendarizarProgramas.SelectedValue == "0") {
            MTransferencia _obTransferencia = new MTransferencia {
              CuentaOrigen = _dlCuentaOrigen.SelectedValue,
              CuentaDestino = _dlCuentaDestino.SelectedValue,
              MontoTransferencia = Convert.ToDouble(_txMontoTransferir.Text),
              DescripcionTransferencia = _txDescripcionTrasnferir.Text,
              Calendarizado = false,
              Programado = false,
              UsuarioTransferencia = "RaulHernandez"
            };
            int _inEstadoEjecucion = _obTransferenciaCuentasPropias.InsertarInformacionTransferencia(_obTransferencia);
            if (_inEstadoEjecucion != 0) {
              _lbMensajeUsuario.Text = "Error al crear transferencia.";
              _lbMensajeUsuario.CssClass = "text-bold text-danger";
            }
            else {
              if (_obTransferenciaCuentasPropias.Transferencia != null) {
                Response.Redirect($"ConfirmacionTrasnferencia.aspx?nt={_obTransferenciaCuentasPropias.Transferencia.NumeroTransferencia}");
              }
              else {
                _lbMensajeUsuario.Text = $"No se pudo capturar la transferencia, comuniquese con el banco.";
                _lbMensajeUsuario.CssClass = "text-bold text-danger";
              }
            }
          }
          else if (_dlCalendarizarProgramas.SelectedValue == "1") {
            if (_txFechaIncioTransferencia.Text != "") {
              if (_txFechaFinalizaTransferencia.Text != "") {
                bool _boValidaFormato = Regex.IsMatch(_txFechaIncioTransferencia.Text, @"^\d{4}-((0\d)|(1[012]))-(([012]\d)|3[01])$");
                if (_boValidaFormato) {
                  _boValidaFormato = Regex.IsMatch(_txFechaFinalizaTransferencia.Text, @"^\d{4}-((0\d)|(1[012]))-(([012]\d)|3[01])$");
                  if (_boValidaFormato) {
                    DateTime _dtFechaInicioCalendarizacion = DateTime.Parse(_txFechaIncioTransferencia.Text);
                    DateTime _dtFechaFinalizacionCalendarizacion = DateTime.Parse(_txFechaFinalizaTransferencia.Text);
                    if (_dtFechaInicioCalendarizacion > DateTime.Now) {
                      if (_dtFechaInicioCalendarizacion < _dtFechaFinalizacionCalendarizacion) {
                        _obTransferenciaCuentasPropias = new BLLTransferenciaCuentasPropias();
                        MTransferencia _obTransferencia = new MTransferencia {
                          CuentaOrigen = _dlCuentaOrigen.SelectedValue,
                          CuentaDestino = _dlCuentaDestino.SelectedValue,
                          MontoTransferencia = Convert.ToDouble(_txMontoTransferir.Text),
                          DescripcionTransferencia = _txDescripcionTrasnferir.Text,
                          Calendarizado = true,
                          PeriodoCalendarizacion = Convert.ToInt32(_dlPeriodoCalendarizacion.SelectedValue),
                          FechaInicioCalendarizacion = _dtFechaInicioCalendarizacion,
                          FechaFinalizacionCalendarizacion = _dtFechaFinalizacionCalendarizacion,
                          Programado = false,
                          UsuarioTransferencia = "RaulHernandez"
                        };
                        int _inEstadoEjecucion = _obTransferenciaCuentasPropias.InsertarInformacionTransferencia(_obTransferencia);
                        if (_inEstadoEjecucion != 0) {
                          _lbMensajeUsuario.Text = "Error al crear transferencia.";
                          _lbMensajeUsuario.CssClass = "text-bold text-danger";
                        }
                        else {
                          if (_obTransferenciaCuentasPropias.Transferencia != null) {
                            Response.Redirect($"ConfirmacionTrasnferencia.aspx?nt={_obTransferenciaCuentasPropias.Transferencia.NumeroTransferencia}");
                          }
                          else {
                            _lbMensajeUsuario.Text = $"No se pudo capturar la transferencia, comuniquese con el banco.";
                            _lbMensajeUsuario.CssClass = "text-bold text-danger";
                          }
                        }
                      }
                      else {
                        _lbMensajeUsuario.Text = $"La fecha de finalización no puede ser menor o igual a la de inicio para calendizar.";
                        _lbMensajeUsuario.CssClass = "text-bold text-danger";
                      }
                    }
                    else {
                      _lbMensajeUsuario.Text = $"La fecha de inicio debe ser mayor a la fecha actual para calendizar.";
                      _lbMensajeUsuario.CssClass = "text-bold text-danger";
                    }
                  }
                  else {
                    _lbMensajeUsuario.Text = $"Formato para fecha de finalización no válido.";
                    _lbMensajeUsuario.CssClass = "text-bold text-danger";
                  }
                }
                else {
                  _lbMensajeUsuario.Text = $"Formato para fecha de inicio no válido.";
                  _lbMensajeUsuario.CssClass = "text-bold text-danger";
                }
              }
              else {
                _lbMensajeUsuario.Text = $"Debe ingresar un valor válido como fecha de fin para la calendarización.";
                _lbMensajeUsuario.CssClass = "text-bold text-danger";
              }
            }
            else {
              _lbMensajeUsuario.Text = $"Debe ingresar un valor válido como fecha de inicio para la calendarización.";
              _lbMensajeUsuario.CssClass = "text-bold text-danger";
            }
          }
          else if (_dlCalendarizarProgramas.SelectedValue == "2") {
            if (_txFechaProgramacion.Text != "") {
              bool _boValidaFormato = Regex.IsMatch(_txFechaProgramacion.Text, @"^\d{4}-((0\d)|(1[012]))-(([012]\d)|3[01])$");
              if (_boValidaFormato) {
                DateTime _dtFechaProgramacion = DateTime.Parse(_txFechaProgramacion.Text);
                if (_dtFechaProgramacion > DateTime.Now) {
                  _obTransferenciaCuentasPropias = new BLLTransferenciaCuentasPropias();
                  MTransferencia _obTransferencia = new MTransferencia {
                    CuentaOrigen = _dlCuentaOrigen.SelectedValue,
                    CuentaDestino = _dlCuentaDestino.SelectedValue,
                    MontoTransferencia = Convert.ToDouble(_txMontoTransferir.Text),
                    DescripcionTransferencia = _txDescripcionTrasnferir.Text,
                    Calendarizado = false,
                    Programado = true,
                    FechaProgramacion = _dtFechaProgramacion,
                    UsuarioTransferencia = "RaulHernandez"
                  };
                  int _inEstadoEjecucion = _obTransferenciaCuentasPropias.InsertarInformacionTransferencia(_obTransferencia);
                  if (_inEstadoEjecucion != 0) {
                    _lbMensajeUsuario.Text = "Error al crear transferencia.";
                    _lbMensajeUsuario.CssClass = "text-bold text-danger";
                  }
                  else {
                    if (_obTransferenciaCuentasPropias.Transferencia != null) {
                      Response.Redirect($"ConfirmacionTrasnferencia.aspx?nt={_obTransferenciaCuentasPropias.Transferencia.NumeroTransferencia}");
                    }
                    else {
                      _lbMensajeUsuario.Text = $"No se pudo capturar la transferencia, comuniquese con el banco.";
                      _lbMensajeUsuario.CssClass = "text-bold text-danger";
                    }
                  }
                }
                else {
                  _lbMensajeUsuario.Text = $"La fecha de programación no puede ser menor o igual a la fecha actual.";
                  _lbMensajeUsuario.CssClass = "text-bold text-danger";
                }
              }
              else {
                _lbMensajeUsuario.Text = $"Formato para la fecha de programación no válido.";
                _lbMensajeUsuario.CssClass = "text-bold text-danger";
              }
            }
            else {
              _lbMensajeUsuario.Text = $"Debe ingresar un valor válido como fecha de programación.";
              _lbMensajeUsuario.CssClass = "text-bold text-danger";
            }
          }
          else {
            _lbMensajeUsuario.Text = $"No se encontro valor de calentarización/programación, ingrese nuevamente a la opción.";
            _lbMensajeUsuario.CssClass = "text-bold text-danger";
          }
        }
        else {
          _lbMensajeUsuario.Text = $"Monto ingresado inválido, ingrese nuevamente el monto de la trasnferencia.";
          _lbMensajeUsuario.CssClass = "text-bold text-danger";
        }
      }
      else {
        _lbMensajeUsuario.Text = $"Cuenta origen y cuenta destino no pueden ser las mismas, seleccione otra cuenta y repita la operación.";
        _lbMensajeUsuario.CssClass = "text-bold text-danger";
      }
    }
    catch (Exception ex) {
      _lbMensajeUsuario.Text = $"Error de aplicación. {ex.Message}";
      _lbMensajeUsuario.CssClass = "text-bold text-danger";
    }
  }
}