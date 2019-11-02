using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using MODELS;
using System.Data;

namespace BLL
{
    public class BLLLogin : DExecute
    {
        int res = 0;
        public static DataTable permisos(int pIdFinanciera, string pUsuario, string pContrasenia)
        {
            DProcedimiento objProc = null;
            DExecute objExcute = null;

            objProc = new DProcedimiento();
            objExcute = new DExecute();
            objProc.NombreProcedimiento = "PRC_LOGIN_BANCO";

            objProc.Parametros.Add(new DParametro { Nombre = "pIdFinanciera", Valor = pIdFinanciera, Tipo = DbType.Int32, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "pUsuario", Valor = pUsuario, Tipo = DbType.String, Out = false });
            objProc.Parametros.Add(new DParametro { Nombre = "pContrasenia", Valor = pContrasenia, Tipo = DbType.String, Out = false });



            return objExcute.Consultar(objProc);


        }
        public MUsuario atributosUsuario(int pIdUsuario)
        {
            MUsuario objMUsuario = new MUsuario();
            DataTable dt = new DataTable();

            DProcedimiento objProc = null;
            DExecute objExcute = null;

            objProc = new DProcedimiento();
            objExcute = new DExecute();
            objProc.NombreProcedimiento = "PRC_ATRIBUTOS_USUARIO";

            objProc.Parametros.Add(new DParametro { Nombre = "pIdUsuario", Valor = pIdUsuario, Tipo = DbType.Int32, Out = false });

            dt = objExcute.Consultar(objProc);

            foreach (DataRow iRow in dt.Rows)
            {
                objMUsuario.idUsuario = Convert.ToInt32(iRow["id_usuario"].ToString());
                objMUsuario.idTipoUsuario = Convert.ToInt32(iRow["id_tipo_usuario"].ToString());
                objMUsuario.idCliente = Convert.ToInt32(iRow["id_cliente"].ToString());
                objMUsuario.idFinanciera = Convert.ToInt32(iRow["id_usuario"].ToString());
                objMUsuario.usuario = iRow["usuario"].ToString();
                objMUsuario.contrasenia = iRow["contrasenia"].ToString();
                objMUsuario.deBaja = iRow["deBaja"].ToString();
                objMUsuario.cliente = new MCliente();
                objMUsuario.cliente.idEstadoCivil = Convert.ToInt32(iRow["id_estado_civil"].ToString());
                objMUsuario.cliente.primerNombre = iRow["primer_nombre"].ToString();
                objMUsuario.cliente.segundoNombre = iRow["segundo_nombre"].ToString();
                objMUsuario.cliente.primerApellido = iRow["primer_apellido"].ToString();
                objMUsuario.cliente.segundoApellido = iRow["segundo_apellido"].ToString();
                objMUsuario.cliente.apellidoCasada = iRow["apellido_casada"].ToString();
                objMUsuario.cliente.fechaNacimiento = iRow["fecha_nacimiento"].ToString();
                objMUsuario.cliente.direccion = iRow["direccion"].ToString();
                objMUsuario.cliente.email = iRow["email"].ToString();
                objMUsuario.cliente.telefono = iRow["telefono"].ToString();
                objMUsuario.cliente.empresaLabora = iRow["empresa_labora"].ToString();
                objMUsuario.cliente.cargo = iRow["cargo"].ToString();
                objMUsuario.cliente.nit = iRow["nit"].ToString();
                objMUsuario.cliente.cantidadHijos = Convert.ToInt32(iRow["cantidad_hijos"].ToString());
                objMUsuario.cliente.cantidadAportesFamilia = Convert.ToDouble(iRow["cantidad_aportes_familia"].ToString());
                objMUsuario.cliente.casaPropia = Convert.ToBoolean(iRow["casa_propia"].ToString());
                objMUsuario.cliente.ingresosMensuales = Convert.ToDouble(iRow["ingresos_mensuales"].ToString());
                objMUsuario.cliente.otrosIngresos = Convert.ToDouble(iRow["otros_ingresos"].ToString());

            }

            return objMUsuario;
        }
    }
}
