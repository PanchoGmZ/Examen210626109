using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasConsultas.DAL
{
    public class ProdVendidosPorTipoProdDAL
    {
        public DataTable ListarProductosVendidosTipoProdDal()
        {
            string consulta = "SELECT TP.NOMBRE AS TIPO_PROD, SUM(DV.CANTIDAD) AS TOTAL_VENDIDO\r\nFROM PRODUCTO P\r\nJOIN DETALLEVENTA DV ON P.IDPRODUCTO = DV.IDPRODUCTO\r\nJOIN TIPOPROD TP ON P.IDTIPOPROD = TP.IDTIPOPROD\r\nGROUP BY TP.NOMBRE;";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
