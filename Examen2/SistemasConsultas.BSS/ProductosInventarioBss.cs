using SistemasConsultas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasConsultas.BSS
{
    public class ProductosInventarioBss
    {
        ProductosInventariosDAL DAL = new ProductosInventariosDAL();
        public DataTable ListarProductosInventarioBss()
        {
            return DAL.ListarProductosInventarioDal();
        }
    }
}
