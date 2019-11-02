using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELS
{
    public class MCliente
    {
        public int idCliente { get; set; }
        public int idEstadoCivil { get; set; }
        public string identificacion { get; set; }
        public string primerNombre { get; set; }
        public string segundoNombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string apellidoCasada { get; set; }
        public string fechaNacimiento { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string empresaLabora { get; set; }
        public string cargo { get; set; }
        public string nit { get; set; }
        public bool manejaCuentaBanco { get; set; }
        public bool negocioPropio { get; set; }
        public string tipoNegocio { get; set; }
        public string tiempoNegocio { get; set; }
        public int cantidadHijos { get; set; }
        public double cantidadAportesFamilia { get; set; }
        public bool casaPropia { get; set; }
        public string tiempoResidir { get; set; }
        public bool trabajaPareja { get; set; }
        public string trabajoPareja { get; set; }
        public string descripcion { get; set; }
        public double ingresosMensuales { get; set; }
        public double otrosIngresos { get; set; }
    }
}
