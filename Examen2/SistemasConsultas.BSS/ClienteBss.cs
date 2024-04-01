using SistemasConsultas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemasConsultas.BSS
{
    public class ClienteBss
    {
        ClienteDAL DAL = new ClienteDAL();
        public DataTable ClienteDatosBss()
        {
            return DAL.ListarClientesDatosDal();
        }
    }
}
