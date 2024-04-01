using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasConsultas.DAL
{
    public class MarcaMasVendidaDAL
    {
        public DataTable ListarMarcaMasVendidaDal()
        {
            string consulta = "SELECT m.NOMBRE AS MARCA_MAS_VENDIDA, SUM(dv.CANTIDAD) AS TOTAL_VENTAS\r\nFROM MARCA m\r\nJOIN PRODUCTO p ON m.IDMARCA = p.IDMARCA\r\nJOIN DETALLEVENTA dv ON p.IDPRODUCTO = dv.IDPRODUCTO\r\nGROUP BY m.NOMBRE\r\nORDER BY total_ventas DESC\r\n";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
