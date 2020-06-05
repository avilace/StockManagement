using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StockManagement
{
    class ConexionBD
    {
        string cadena = "Data Source= localhost\\SQLEXPRESS; Initial Catalog=proyecto; Integrated Security=True";
        public SqlConnection conectarbd = new SqlConnection();

        //Constructor de carga

        public ConexionBD()
        {
            conectarbd.ConnectionString = cadena;
        }

        //Metodo para abrir la conexion

        public void abrir()
        {
            try 
            {
                conectarbd.Open();
                Console.WriteLine("Conexion Abierta");
            }catch(Exception ex)
            {
                Console.WriteLine("Error al abrir la BD + " + ex.Message);
            }

        }

        //Metodo para cerrar la conexio a la BBDD

        public void cerrar()
        {
            conectarbd.Close();
        }
    }
}
