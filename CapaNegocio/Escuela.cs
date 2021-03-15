using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class Escuela : Interfaces.IEscuela
    {
        //llamar a la capa de datos 
        private Datos datos = new DatosSQL();
        //Propiedad de solo lectura para el mensaje del PAT
        string mensaje;
        public string Mensaje
        {
            get
            {
                return mensaje;
            }
        }
        public string[] Actualizar(string codEscuela, string Escuela)
        {
            DataRow fila = datos.TraerDataRow("spActualizarEscuela", codEscuela, Escuela);
            //traer el codigo de error y el mensaje
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] aea = { mensaje, codError.ToString() };
            return aea;
        }

        public string[] Agregar(string codEscuela, string escuela)
        {
            DataRow fila = datos.TraerDataRow("spAgregarEscuela", codEscuela, escuela);
            //traer el codigo de error y el mensaje
            byte codError = Convert.ToByte(fila["CodError"]);

            mensaje = fila["Mensaje"].ToString();
            string[] aea = { mensaje, codError.ToString() };
            return aea;
        }

        public DataSet buscar(string texto, string criterio)
        {
            return datos.TraerDataSet("spBuscarEscuela", texto, criterio);
        }

        public string[] Eliminar(string codEscuela)
        {
            DataRow fila = datos.TraerDataRow("spEliminarEscuela", codEscuela);
            //traer el codigo de error y el mensaje
            byte codError = Convert.ToByte(fila["CodError"]);
            mensaje = fila["Mensaje"].ToString();
            string[] aea = { mensaje, codError.ToString() };
            return aea;
        }




        public DataSet Listar()
        {
            return datos.TraerDataSet("spListarEscuela");
        }
    }
}