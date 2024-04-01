using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasConsultas.DAL
{
    public class ProveedorMasSuministroDAL
    {
        public DataTable ListarProveedorMasSuministroDal()
        {
            string consulta = "SELECT P.NOMBRE AS PROVEEDOR, COUNT(PR.IDPRODUCTO) AS TOTAL_SUMINISTRADO\r\nFROM PROVEEDOR P\r\nJOIN PROVEE PR ON P.IDPROVEEDOR = PR.IDPROVEEDOR\r\nGROUP BY P.NOMBRE\r\nORDER BY COUNT(PR.IDPRODUCTO) DESC\r\n";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
