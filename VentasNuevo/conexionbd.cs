using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasNuevo
{
    class conexionbd
    {
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-74BBU83\\SQLEXPRESS ; Initial Catalog=VENTAS ; integrated security = true");
        /*string cadena = "Data Source=DESKTOP-74BBU83\\SQLEXPRESS;Initial Catalog=VENTAS; Integrated Security=True";
        SqlConnection conectarbd = new SqlConnection();*/

        public void abrir()
        {
            try
            {
                conexion.Open();
                Console.WriteLine("Conexion Abierta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public void cerrar()
        {
            conexion.Close();
        }
    }
}
