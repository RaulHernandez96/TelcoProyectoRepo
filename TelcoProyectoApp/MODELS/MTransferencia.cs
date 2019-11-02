using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS {
  public class MTransferencia {
    public string NumeroTransferencia { get; set; }
    public string CuentaOrigen { get; set; }
    public string CuentaDestino { get; set; }
    public double MontoTransferencia { get; set; }
    public string DescripcionTransferencia { get; set; }
    public bool Calendarizado { get; set; }
    public int PeriodoCalendarizacion { get; set; }
    public DateTime FechaInicioCalendarizacion { get; set; }
    public DateTime FechaFinalizacionCalendarizacion { get; set; }
    public bool Programado { get; set; }
    public DateTime FechaProgramacion { get; set; }
    public DateTime FechaTransferencia { get; set; }
    public string UsuarioTransferencia { get; set; }
    public int EstadoTransferencia { get; set; }
    public MTransferencia() {
      NumeroTransferencia = "";
      CuentaOrigen = "";
      CuentaDestino = "";
      MontoTransferencia = 0.00;
      DescripcionTransferencia = "";
      Calendarizado = false;
      PeriodoCalendarizacion = 0;
      FechaInicioCalendarizacion = DateTime.Now;
      FechaFinalizacionCalendarizacion = DateTime.Now;
      Programado = false;
      FechaProgramacion = DateTime.Now;
      FechaTransferencia = DateTime.Now;
      UsuarioTransferencia = "";
      EstadoTransferencia = 0;
    }
    public MTransferencia(string _stNumeroTrasnferencia, string _stCuentaOrigen, string _stCuentaDestino
      , double _doMontoTransferencia, string _stDescripcionTransferencia, bool _boCalendarizado, int _inPeriodoCalendarizacion
      , DateTime _dtFechaInicioCalendarizacion, DateTime _dtFechaFinalizacionCalendarizacion, bool _boProgramado
      , DateTime _dtFechaProgramacion, DateTime _dtFechaTrasferencia, string _stUsuarioTrasnferencia
      , int _inEstadoTransferencia) {
      NumeroTransferencia = _stNumeroTrasnferencia;
      CuentaOrigen = _stCuentaOrigen;
      CuentaDestino = _stCuentaDestino;
      MontoTransferencia = _doMontoTransferencia;
      DescripcionTransferencia = _stDescripcionTransferencia;
      Calendarizado = _boCalendarizado;
      PeriodoCalendarizacion = _inPeriodoCalendarizacion;
      FechaInicioCalendarizacion = _dtFechaInicioCalendarizacion;
      FechaFinalizacionCalendarizacion = _dtFechaFinalizacionCalendarizacion;
      Programado = _boProgramado;
      FechaProgramacion = _dtFechaProgramacion;
      FechaTransferencia = _dtFechaTrasferencia;
      UsuarioTransferencia = _stUsuarioTrasnferencia;
      EstadoTransferencia = _inEstadoTransferencia;
    }
  }
}
