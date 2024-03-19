using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Computadora.Modelos;

namespace Computadora.DAL
{
    public class ComputadoraDal
    {
        public DataTable ListarComputadoraDal()
        {
            string consulta = "select * from computadora";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }
        public void InsertarComputadoraDal(Computadoras computadora)
        {
            string consulta = "insert into computadora values(" + computadora.IdComputadora + "," +
                                                          "'" + computadora.Nombre + "'," +
                                                          "'" + computadora.Descripcion + "'," +
                                                          "" + computadora.Precio + "," +
                                                          "'" + computadora.FechaFabricacion + "')";
            conexion.Ejecutar(consulta);
        }
        public Computadoras ObtenerPersonaId(int id)
        {
            string consulta = "select * from computadora where idcomputadora=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Computadoras computadoras = new Computadoras();
            if (tabla.Rows.Count > 0)
            {
                computadoras.IdComputadora = Convert.ToInt32(tabla.Rows[0]["idcomputadora"]);
                computadoras.Nombre = tabla.Rows[0]["nombre"].ToString();
                computadoras.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                computadoras.Precio = Convert.ToDecimal(tabla.Rows[0]["precio"].ToString);
                computadoras.FechaFabricacion = Convert.ToDateTime(tabla.Rows[0]["fechadefabricacion"].ToString);
            }
            return computadoras;
        }
        public void EditarComputadoraDal(Computadoras computadoras)
        {
            string consulta = "update persona set nombre='" + computadoras.Nombre + "'," +
                                                         "descripcion='" + computadoras.Descripcion + "'," +
                                                          "precio=" + computadoras.Precio + "," +
                                                          "fechadefabricacion='" + computadoras.FechaFabricacion + "'," +
                                        "where idcomputadora=" + computadoras.IdComputadora;

            conexion.Ejecutar(consulta);
        }
    }
}
