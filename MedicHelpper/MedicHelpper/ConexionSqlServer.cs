using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace MedicHelpper
{
    class ConexionSqlServer
    {
        public SqlConnection conexion = new SqlConnection("server=localhost;database=MedicHelpperBDD;Trusted_Connection=True;");
        public void abrir()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de conexion" + ex.Message);
            }
        }
        public void cerrar()
        {
            conexion.Close();
        }
    }
}

