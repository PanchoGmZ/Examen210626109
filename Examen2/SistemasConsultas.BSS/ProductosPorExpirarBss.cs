using SistemasConsultas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasConsultas.BSS
{
     public class ProductosPorExpirarBss
    {
        ProductosAExpirarDAL DAL = new ProductosAExpirarDAL();
        public DataTable ListarProducotsPorExpirarBss()
        {
            return DAL.ListarProducotsPorExpirarDal();
        }
    }
}
