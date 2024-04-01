using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasConsultas.DAL
{
    public class ClienteDAL
    {
        public DataTable ListarClientesDatosDal()
        {
            string consulta = "SELECT PERSONA.NOMBRE, PERSONA.APELLIDO, CLIENTE.TIPOCLIENTE, CLIENTE.CODIGOCLIENTE\r\nFROM  CLIENTE INNER JOIN\r\n  PERSONA ON CLIENTE.IDPERSONA = PERSONA.IDPERSONA";
            return conexion.EjecutarDataTabla(consulta, "fsdf");
        }
    }
}
