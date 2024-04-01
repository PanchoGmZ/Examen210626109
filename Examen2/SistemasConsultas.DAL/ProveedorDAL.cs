using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasConsultas.DAL
{
    public class ProveedorDAL
    {
        public DataTable TotalIngresosDAL()
        {
            string consulta = "SELECT p.NOMBRE, SUM(i.TOTAL) AS TOTAL_INGRESOS\r\nFROM PROVEEDOR p\r\nJOIN INGRESO i ON p.IDPROVEEDOR = i.IDPROVEEDOR\r\nGROUP BY p.NOMBRE;";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
