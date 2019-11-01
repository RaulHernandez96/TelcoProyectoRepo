using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace MODELS
{
    public static class MLogin
    {       
        public static string nombreForma { get; set; }
        public static string codigoForma { get; set; }
        public static string descripcion { get; set; }
        public static string codigoMenu { get; set; }
        public static string descripcionMenu { get; set; }
        public static int idFinanciera { get; set; }
        public static DataTable permisos { get; set; }
    }
}
