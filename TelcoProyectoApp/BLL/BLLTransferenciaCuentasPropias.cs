using DAO;
using MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
  public class BLLTransferenciaCuentasPropias {
    public MTransferencia Transferencia { get; set; }
    public BLLTransferenciaCuentasPropias() {
      Transferencia = null;
    }
    public BLLTransferenciaCuentasPropias(MTransferencia _obTransferencia) {
      Transferencia = _obTransferencia;
    }
    public int BuscarInformacionTransferencia(string _stNumeroTransferencia) {
      try {
        DExecute _obExecute = new DExecute();
        DProcedimiento _obProcedimiento = new DProcedimiento {
          NombreProcedimiento = "dbo.PRC_LISTA_INFO_TRANSFERENCIA",
          Parametros = new List<DParametro> {
          new DParametro {
            Nombre = "@NumeroTransferencia",
            Valor = _stNumeroTransferencia,
            Tipo = DbType.String
          }
        }
        };
        _obExecute.abrirConexion();
        DataTable _dtInformacionTransferencia = _obExecute.Consultar(_obProcedimiento);
        _obExecute.cerrarConexion();
        if(_dtInformacionTransferencia.Rows.Count > 0) {
          foreach(DataRow _drInformacionTransferencia in _dtInformacionTransferencia.Rows) {
            Transferencia = new MTransferencia {
              NumeroTransferencia = _drInformacionTransferencia["NumeroTransferencia"].ToString(),
              CuentaOrigen = _drInformacionTransferencia["CuentaOrigen"].ToString(),
              CuentaDestino = _drInformacionTransferencia["CuentaDestino"].ToString(),
              MontoTransferencia = Convert.ToDouble(_drInformacionTransferencia["MontoTransferencia"].ToString()),
              DescripcionTransferencia = _drInformacionTransferencia["DescripcionTransferencia"].ToString(),
              Calendarizado = Convert.ToBoolean(_drInformacionTransferencia["Calendarizado"].ToString()),
              PeriodoCalendarizacion = Convert.ToInt32(_drInformacionTransferencia["PeriodoCalendarizacion"].ToString()),
              FechaInicioCalendarizacion = DateTime.Parse(_drInformacionTransferencia["FechaInicioCalendarizacion"].ToString()),
              FechaFinalizacionCalendarizacion = DateTime.Parse(_drInformacionTransferencia["FechaFinalizacionCalendarizacion"].ToString()),
              Programado = Convert.ToBoolean(_drInformacionTransferencia["Programado"].ToString()),
              FechaProgramacion = DateTime.Parse(_drInformacionTransferencia["FechaProgramacion"].ToString()),
              FechaTransferencia = DateTime.Parse(_drInformacionTransferencia["FechaTransferencia"].ToString()),
              UsuarioTransferencia = _drInformacionTransferencia["UsuarioTransferencia"].ToString(),
              EstadoTransferencia = Convert.ToInt32(_drInformacionTransferencia["EstadoTransferencia"].ToString())
            };
          }
          return 0;
        }
        else {
          return 5;
        }
      }
      catch(Exception ex) {
        throw ex;
      }
    }
    public int InsertarInformacionTransferencia(MTransferencia _obTransferencia) {
      try {
        Transferencia = _obTransferencia;
        DExecute _obExecute = new DExecute();
        DProcedimiento _obProcedimiento = new DProcedimiento {
          NombreProcedimiento = "dbo.PRC_CREAR_TRANSACCION",
          Parametros = new List<DParametro> {
            new DParametro {
              Nombre = "@CuentaOrigen",
              Valor = Transferencia.CuentaOrigen,
              Tipo = DbType.String
            },
            new DParametro {
              Nombre = "@CuentaDestino",
              Valor = Transferencia.CuentaDestino,
              Tipo = DbType.String
            },
            new DParametro {
              Nombre = "@MontoTransferencia",
              Valor = Transferencia.MontoTransferencia,
              Tipo = DbType.Decimal
            },
            new DParametro {
              Nombre = "@DescripcionTransferencia",
              Valor = Transferencia.DescripcionTransferencia,
              Tipo = DbType.String
            },
            new DParametro {
              Nombre = "@Calendarizado",
              Valor = Transferencia.Calendarizado,
              Tipo = DbType.Boolean
            },
            new DParametro {
              Nombre = "@PeriodoCalendarizacion",
              Valor = Transferencia.PeriodoCalendarizacion,
              Tipo = DbType.Int32
            },
            new DParametro {
              Nombre = "@FechaInicioCalendarizacion",
              Valor = Transferencia.FechaInicioCalendarizacion,
              Tipo = DbType.DateTime
            },
            new DParametro {
              Nombre = "@FechaFinalizacionCalendarizacion",
              Valor = Transferencia.FechaFinalizacionCalendarizacion,
              Tipo = DbType.DateTime
            },
            new DParametro {
              Nombre = "@Programado",
              Valor = Transferencia.Programado,
              Tipo = DbType.Boolean
            },
            new DParametro {
              Nombre = "@FechaProgramacion",
              Valor = Transferencia.FechaProgramacion,
              Tipo = DbType.DateTime
            },
            new DParametro {
              Nombre = "@UsuarioTransferencia",
              Valor = Transferencia.UsuarioTransferencia,
              Tipo = DbType.String
            }
          }
        };
        _obExecute.abrirConexion();
        DataTable _dtResultadoInsert = _obExecute.Consultar(_obProcedimiento);
        if(_dtResultadoInsert.Rows.Count > 0) {
          int _inResultadoInsert = 0;
          string _stResultadoInsert = "";
          foreach(DataRow _drResultadoInsert in _dtResultadoInsert.Rows) {
            _inResultadoInsert = Convert.ToInt32(_drResultadoInsert["CodigoResultado"].ToString());
            _stResultadoInsert = _drResultadoInsert["MensajeResultado"].ToString();
          }
          if (_inResultadoInsert != 0) {
            throw new Exception($"{_stResultadoInsert} [{_inResultadoInsert}]");
          }
          else {
            Transferencia.NumeroTransferencia = _stResultadoInsert;
            return _inResultadoInsert;
          }
        }
        else {
          return 5;
        }
      }
      catch(Exception ex) {
        throw ex;
      }
    }
    public int ConfirmarTransferencia(string _stNumeroTransferencia) {
      try {
        DExecute _obExecute = new DExecute();
        DProcedimiento _obProcedimiento = new DProcedimiento {
          NombreProcedimiento = "dbo.PRC_CONFIRMA_TRANSFERENCIA",
          Parametros = new List<DParametro> {
          new DParametro {
            Nombre = "@NumeroTransferencia",
            Valor = _stNumeroTransferencia,
            Tipo = DbType.String
          }
        }
        };
        _obExecute.abrirConexion();
        DataTable _dtResultadoInsert = _obExecute.Consultar(_obProcedimiento);
        _obExecute.cerrarConexion();
        if (_dtResultadoInsert.Rows.Count > 0) {
          int _inResultadoInsert = 0;
          string _stResultadoInsert = "";
          foreach (DataRow _drResultadoInsert in _dtResultadoInsert.Rows) {
            _inResultadoInsert = Convert.ToInt32(_drResultadoInsert["CodigoResultado"].ToString());
            _stResultadoInsert = _drResultadoInsert["MensajeResultado"].ToString();
          }
          if (_inResultadoInsert != 0) {
            throw new Exception($"{_stResultadoInsert} [{_inResultadoInsert}]");
          }
          else {
            return _inResultadoInsert;
          }
        }
        else {
          return 5;
        }
      }
      catch (Exception ex) {
        throw ex;
      }
    }
    public int CancelaTransferencia(string _stNumeroTransferencia) {
      try {
        DExecute _obExecute = new DExecute();
        DProcedimiento _obProcedimiento = new DProcedimiento {
          NombreProcedimiento = "dbo.PRC_CANCELAR_TRANSFERENCIA",
          Parametros = new List<DParametro> {
          new DParametro {
            Nombre = "@NumeroTransferencia",
            Valor = _stNumeroTransferencia,
            Tipo = DbType.String
          }
        }
        };
        _obExecute.abrirConexion();
        DataTable _dtResultadoInsert = _obExecute.Consultar(_obProcedimiento);
        _obExecute.cerrarConexion();
        if (_dtResultadoInsert.Rows.Count > 0) {
          int _inResultadoInsert = 0;
          string _stResultadoInsert = "";
          foreach (DataRow _drResultadoInsert in _dtResultadoInsert.Rows) {
            _inResultadoInsert = Convert.ToInt32(_drResultadoInsert["CodigoResultado"].ToString());
            _stResultadoInsert = _drResultadoInsert["MensajeResultado"].ToString();
          }
          if (_inResultadoInsert != 0) {
            throw new Exception($"{_stResultadoInsert} [{_inResultadoInsert}]");
          }
          else {
            return _inResultadoInsert;
          }
        }
        else {
          return 5;
        }
      }
      catch (Exception ex) {
        throw ex;
      }
    }
  }
}
