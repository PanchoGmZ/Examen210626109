using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasConsultas.DAL
{
    public class VentaPorVendedorDAL
    {
        public DataTable ListarVentasPorVendedorDal()
        {
            string consulta = "SELECT u.NOMBREUSER AS VENDEDOR, p.NOMBRE AS PRODUCTO, SUM(d.CANTIDAD) AS CANTIDAD\r\nFROM USUARIO u\r\nJOIN VENTA v ON u.IDUSUARIO = v.IDVENDEDOR\r\nJOIN DETALLEVENTA d ON v.IDVENTA = d.IDVENTA\r\nJOIN PRODUCTO p ON d.IDPRODUCTO = p.IDPRODUCTO\r\nGROUP BY u.NOMBREUSER, p.NOMBRE;";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
