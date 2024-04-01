using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasConsultas.DAL
{
    public class ProductosInventariosDAL
    {
        public DataTable ListarProductosInventarioDal()
        {
            string consulta = "SELECT SUM(UNIDAD) AS TOTAL_PRODUCTOS_STOCK\r\nFROM PRODUCTO;";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
