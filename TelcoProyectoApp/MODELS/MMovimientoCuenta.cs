using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS {
  public class MMovimientoCuenta {
    public DateTime Fecha { get; set; }
    public string Documento { get; set; }
    public string Descripcion { get; set; }
    public double DebitoCredito { get; set; }
    public double Saldo { get; set; }
    public string Agencia { get; set; }
    public MMovimientoCuenta() {
      Fecha = new DateTime();
      Documento = "#Sin datos#";
      DebitoCredito = 0.00;
      Saldo = 0.00;
      Agencia = "#Sin datos#";
    }
    public MMovimientoCuenta(DateTime _dtFecha, string _stDocumento, string _stDescripcion, double _doDebitoCredito
      , double _doSaldo, string _stAgencia) {
      Fecha = _dtFecha;
      Documento = _stDocumento;
      Descripcion = _stDescripcion;
      DebitoCredito = _doDebitoCredito;
      Saldo = _doSaldo;
      Agencia = _stAgencia;
    }
  }
}
