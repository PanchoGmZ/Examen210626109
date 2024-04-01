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
            string consulta = "SELECT U.NOMBREUSER AS VENDEDOR, COUNT(DV.IDPRODUCTO) AS CANTIDAD_PRODUCTOS_VENDIDOS\r\nFROM USUARIO U\r\nJOIN VENTA V ON U.IDUSUARIO = V.IDVENDEDOR\r\nJOIN DETALLEVENTA DV ON V.IDVENTA = DV.IDVENTA\r\nGROUP BY U.NOMBREUSER;";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
