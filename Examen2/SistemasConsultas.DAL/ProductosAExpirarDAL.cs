using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasConsultas.DAL
{
    public class ProductosAExpirarDAL
    {
        public DataTable ListarProducotsPorExpirarDal()
        {
            string consulta = "SELECT P.NOMBRE, DI.FECHAVENC\r\nFROM PRODUCTO P\r\nJOIN DETALLEING DI ON P.IDPRODUCTO = DI.IDPRODUCTO\r\nWHERE DI.FECHAVENC BETWEEN GETDATE() AND DATEADD(DAY, 45, GETDATE());";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
