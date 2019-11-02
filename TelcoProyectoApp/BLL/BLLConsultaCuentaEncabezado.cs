using DAO;
using MODELS;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL {
  public class BLLConsultaCuentaEncabezado {
    public MCuenta Cuenta { get; set; }
    public BLLConsultaCuentaEncabezado() {
      Cuenta = null;
    }
    public BLLConsultaCuentaEncabezado(MCuenta _obCuenta) {
      Cuenta = _obCuenta;
    }

    public int BuscarInformacionCuenta(string _stNumeroCuenta) {
      try {
        DExecute _obExecute = new DExecute();
        DProcedimiento _obProcedimiento = new DProcedimiento {
          NombreProcedimiento = "dbo.PRC_LISTA_INFO_CUENTA_ENCABEZADO",
          Parametros = new List<DParametro> {
            new DParametro {
              Nombre = "@NumeroCuenta",
              Valor = _stNumeroCuenta,
              Tipo = DbType.String
            }
          }
        };

        _obExecute.abrirConexion();
        DataTable _dtInformacionCuetna = _obExecute.Consultar(_obProcedimiento);
        _obExecute.cerrarConexion();
        if (_dtInformacionCuetna.Rows.Count > 0) {
          foreach (DataRow _drInfoCuenta in _dtInformacionCuetna.Rows) {
            Cuenta = new MCuenta {
              NumeroCuenta = _drInfoCuenta["NumeroCuenta"].ToString(),
              Propietario = _drInfoCuenta["Propietario"].ToString(),
              TipoCuenta = _drInfoCuenta["TipoCuenta"].ToString(),
              Estado = _drInfoCuenta["Estado"].ToString(),
              FechaCreacion = DateTime.Parse(_drInfoCuenta["FechaCreacion"].ToString()),
              TipoInteres = _drInfoCuenta["TipoInteres"].ToString(),
              TipoMoneda = _drInfoCuenta["TipoMoneda"].ToString(),
              TotalDisponible = Convert.ToDouble(_drInfoCuenta["TotalDisponible"].ToString()),
              SaldoEfectivo = Convert.ToDouble(_drInfoCuenta["SaldoEfectivo"].ToString()),
              SaldoCheque = Convert.ToDouble(_drInfoCuenta["SaldoCheque"].ToString()),
              SaldoReserva = Convert.ToDouble(_drInfoCuenta["SaldoReserva"].ToString()),
              SaldoContable = Convert.ToDouble(_drInfoCuenta["SaldoContable"].ToString()),
              SaldoInicial = Convert.ToDouble(_drInfoCuenta["SaldoInicial"].ToString()),
              InteresMes = Convert.ToDouble(_drInfoCuenta["InteresMes"].ToString()),
              DepositoATM = Convert.ToDouble(_drInfoCuenta["DepositoATM"].ToString()),
              SaldoBloqueado = Convert.ToDouble(_drInfoCuenta["SaldoBloqueado"].ToString()),
              Reserva24Horas = Convert.ToDouble(_drInfoCuenta["Reserva24Horas"].ToString()),
              Reserva48Horas = Convert.ToDouble(_drInfoCuenta["Reserva48Horas"].ToString()),
              Reserva72Horas = Convert.ToDouble(_drInfoCuenta["Reserva72Horas"].ToString()),
              ReservaGirosExterior = Convert.ToDouble(_drInfoCuenta["ReservaGirosExterior"].ToString()),
              InteresPorSobregiro = Convert.ToDouble(_drInfoCuenta["InteresPorSobregiro"].ToString()),
              SobregiroAutorizado = Convert.ToDouble(_drInfoCuenta["SobregiroAutorizado"].ToString()),
              TasaDeSobregiro = Convert.ToDouble(_drInfoCuenta["TasaDeSobregiro"].ToString()),
              InteresSobregiroAcumulado = Convert.ToDouble(_drInfoCuenta["InteresSobregiroAcumulado"].ToString()),
              ExpiracionSobregiro = DateTime.Parse(_drInfoCuenta["ExpiracionSobregiro"].ToString()),
              SobregiroDisponible = Convert.ToDouble(_drInfoCuenta["SobregiroDisponible"].ToString()),
              MovimientosCuenta = null
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
  }
}
