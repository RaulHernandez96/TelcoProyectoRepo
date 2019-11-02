using DAO;
using MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL {
  public class BLLConsultaCuentaDetalle {
    public MCuenta Cuenta { get; set; }
    public BLLConsultaCuentaDetalle() {
      Cuenta = null;
    }
    public BLLConsultaCuentaDetalle(MCuenta _obCuenta) {
      Cuenta = _obCuenta;
    }
    public int BuscarInformacionMovimientos(string _stNumeroCuenta, string _stPeriodoBusqueda) {
      try {
        BLLConsultaCuentaEncabezado _obConsultaEncabezado = new BLLConsultaCuentaEncabezado();
        int _inEstadoEjecucion = _obConsultaEncabezado.BuscarInformacionCuenta(_stNumeroCuenta);
        if(_inEstadoEjecucion > 0) {
          return _inEstadoEjecucion;
        }
        Cuenta = _obConsultaEncabezado.Cuenta;
        Cuenta.MovimientosCuenta = new List<MMovimientoCuenta>();
        DExecute _obExecute = new DExecute();
        DProcedimiento _obProcedimiento = new DProcedimiento {
          NombreProcedimiento = "dbo.PRC_LISTA_INFO_CUENTA_DETALLE",
          Parametros = new List<DParametro> {
            new DParametro {
              Nombre = "@NumeroCuenta",
              Valor = _stNumeroCuenta,
              Tipo = DbType.String
            },
            new DParametro {
              Nombre = "@PeriodoBusqueda",
              Valor = _stPeriodoBusqueda,
              Tipo = DbType.Date
            }
          }
        };
        _obExecute.abrirConexion();
        DataTable _dtInformacionMovimientos = _obExecute.Consultar(_obProcedimiento);
        _obExecute.cerrarConexion();
        if(_dtInformacionMovimientos.Rows.Count > 0) {
          foreach(DataRow _drInfoMovimiento in _dtInformacionMovimientos.Rows) {
            Cuenta.MovimientosCuenta.Add(new MMovimientoCuenta {
              Fecha = DateTime.Parse(_drInfoMovimiento["FechaMovimiento"].ToString()),
              Documento = _drInfoMovimiento["DocumentoMovimiento"].ToString(),
              Descripcion = _drInfoMovimiento["DescripcionMovimiento"].ToString(),
              DebitoCredito = Convert.ToDouble(_drInfoMovimiento["DebitoCredito"].ToString()),
              Saldo = Convert.ToDouble(_drInfoMovimiento["SaldoCuenta"].ToString()),
              Agencia = _drInfoMovimiento["AgenciaMovimiento"].ToString()
            });
          }
          return 0;
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
