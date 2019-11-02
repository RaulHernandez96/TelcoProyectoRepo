using DAO;
using MODELS;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL {
  public class BLLTransferenciaListadoCuentaPropias {
    public List<MCuenta> _liCuentas { get; set; }
    public BLLTransferenciaListadoCuentaPropias() {
      _liCuentas = null;
    }
    public BLLTransferenciaListadoCuentaPropias(List<MCuenta> _liCuentas) {
      this._liCuentas = _liCuentas;
    }
    public int BuscarInformacionCuentas(int _inIdUsuario) {
      try {
        DExecute _obExecute = new DExecute();
        DProcedimiento _obProcedimiento = new DProcedimiento {
          NombreProcedimiento = "PROC_LISTA_CUENTAS_USUARIO",
          Parametros = new List<DParametro> {
            new DParametro {
              Nombre = "@IdUsuario",
              Valor = _inIdUsuario,
              Tipo = DbType.Int16
            }
          }
        };
        _obExecute.abrirConexion();
        DataTable _dtCuentas = _obExecute.Consultar(_obProcedimiento);
        _obExecute.cerrarConexion();
        if(_dtCuentas.Rows.Count > 0) {
          _liCuentas = new List<MCuenta>();
          foreach (DataRow _drCuenta in _dtCuentas.Rows) {
            _liCuentas.Add(new MCuenta {
              NumeroCuenta = _drCuenta["NumeroCuenta"].ToString(),
              Propietario = _drCuenta["Propietario"].ToString(),
              TipoCuenta = _drCuenta["TipoCuenta"].ToString(),
              TipoMoneda = _drCuenta["TipoMoneda"].ToString()
            });
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
  }
}
