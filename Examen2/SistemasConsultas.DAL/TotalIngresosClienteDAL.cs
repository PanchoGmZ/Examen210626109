using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasConsultas.DAL
{
    public class TotalIngresosClienteDAL
    {
        public DataTable ListarIngresosdeClientesDal()
        {
            string consulta = "SELECT p.NOMBRE, p.APELLIDO, SUM(i.TOTAL) AS INGRESOS_GENERADOS\r\nFROM PERSONA p\r\nJOIN CLIENTE c ON p.IDPERSONA = c.IDPERSONA\r\nJOIN INGRESO i ON c.IDCLIENTE = i.IDPROVEEDOR\r\nGROUP BY p.NOMBRE, p.APELLIDO;";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
