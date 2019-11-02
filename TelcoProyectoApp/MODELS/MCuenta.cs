using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS {  
  public class MCuenta {
    public string NumeroCuenta { get; set; }
    public string Propietario { get; set; }
    public string TipoCuenta { get; set; }
    public string Estado { get; set; }
    public DateTime FechaCreacion { get; set; }
    public string TipoInteres { get; set; }
    public string TipoMoneda { get; set; }
    public double TotalDisponible { get; set; }
    public double SaldoEfectivo { get; set; }
    public double SaldoCheque { get; set; }
    public double SaldoReserva { get; set; }
    public double SaldoContable { get; set; }
    public double SaldoInicial { get; set; }
    public double InteresMes { get; set; }
    public double DepositoATM { get; set; }
    public double SaldoBloqueado { get; set; }
    public double Reserva24Horas { get; set; }
    public double Reserva48Horas { get; set; }
    public double Reserva72Horas { get; set; }
    public double ReservaGirosExterior { get; set; }
    public double InteresPorSobregiro { get; set; }
    public double SobregiroAutorizado { get; set; }
    public double TasaDeSobregiro { get; set; }
    public double InteresSobregiroAcumulado { get; set; }
    public DateTime ExpiracionSobregiro { get; set; }
    public double SobregiroDisponible { get; set; }
    public string NombrePublico { get; set; }
    public List<MMovimientoCuenta> MovimientosCuenta { get; set; }
    public MCuenta() {
      NumeroCuenta = "#N/A#";
      Propietario = "#N/A#";
      TipoCuenta = "#N/A#";
      Estado = "#N/A#";
      FechaCreacion = new DateTime();
      TipoInteres = "#N/A#";
      TipoMoneda = "#N/A#";
      TotalDisponible = 0.00;
      SaldoEfectivo = 0.00;
      SaldoCheque = 0.00;
      SaldoReserva = 0.00;
      SaldoContable = 0.00;
      SaldoInicial = 0.00;
      InteresMes = 0.00;
      DepositoATM = 0.00;
      SaldoBloqueado = 0.00;
      Reserva24Horas = 0.00;
      Reserva48Horas = 0.00;
      Reserva72Horas = 0.00;
      ReservaGirosExterior = 0.00;
      InteresPorSobregiro = 0.00;
      SobregiroAutorizado = 0.00;
      TasaDeSobregiro = 0.00;
      InteresSobregiroAcumulado = 0.00;
      ExpiracionSobregiro = new DateTime();
      SobregiroDisponible = 0.00;
      MovimientosCuenta = null;
    }
    public MCuenta(string _stNumeroCuenta, string _stPropietario, string _stTipoCuenta, string _stEstado
      , DateTime _dtFechaCreacion, string _stTipoInteres, string _stTipoMoneda, double _doTotalDisponible
      , double _doSaldoEfectivo, double _doSaldoCheque, double _doSaldoReserva, double _doSaldoContable
      , double _doSaldoInicial, double _doInteresMes, double _doDepositoATM, double _doSaldoBloqueado
      , double _doReserva24Horas, double _doReserva48Horas, double _doReserva72Horas, double _doReservaGirosExterior
      , double _doInteresPorSobregiro, double _doSobregiroAutorizado, double _doTasaDeSobregiro
      , double _doInteresSobregiroAcumulado, DateTime _dtExpiracionSobregiro, double _doSobregiroDisponible 
      , List<MMovimientoCuenta> _liMovimientosCuenta) {
      NumeroCuenta = _stNumeroCuenta;
      Propietario = _stPropietario;
      TipoCuenta = _stTipoCuenta;
      Estado = _stEstado;
      FechaCreacion = _dtFechaCreacion;
      TipoInteres = _stTipoInteres;
      TipoMoneda = _stTipoMoneda;
      TotalDisponible = _doTotalDisponible;
      SaldoEfectivo = _doSaldoEfectivo;
      SaldoCheque = _doSaldoCheque;
      SaldoReserva = _doSaldoReserva;
      SaldoContable = _doSaldoContable;
      SaldoInicial = _doSaldoInicial;
      InteresMes = _doInteresMes;
      DepositoATM = _doDepositoATM;
      SaldoBloqueado = _doSaldoBloqueado;
      Reserva24Horas = _doReserva24Horas;
      Reserva48Horas = _doReserva48Horas;
      Reserva72Horas = _doReserva72Horas;
      ReservaGirosExterior = _doReservaGirosExterior;
      InteresPorSobregiro = _doInteresPorSobregiro;
      SobregiroAutorizado = _doSobregiroAutorizado;
      TasaDeSobregiro = _doTasaDeSobregiro;
      InteresSobregiroAcumulado = _doInteresSobregiroAcumulado;
      ExpiracionSobregiro = _dtExpiracionSobregiro;
      SobregiroDisponible = _doSobregiroDisponible;
      MovimientosCuenta = _liMovimientosCuenta;
    }
    public void GenerarNombresPublicos() {
      NombrePublico = $"[{TipoCuenta}] {NumeroCuenta} [{TipoMoneda}] [{Propietario}]";
    }
  }
}
