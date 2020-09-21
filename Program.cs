using System;
using System.Text;
using System.Data.SqlClient; // necesario para conexiones SQL

namespace SqlServerSample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Build connection string
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "localhost\\COMPAC";   // update me
                builder.UserID = "sa";              // update me
                builder.Password = "Abcd1234*";      // update me
                builder.InitialCatalog = "Demo";

                // Connect to SQL
                Console.Write("Conectando a SQL server ...\n");
                Console.WriteLine("...\n");
                Console.WriteLine("...\n");
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine("Conexion exitosa.");
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.WriteLine("Proceso finalizado. Presione cualquier tecla para cerrar...");
            Console.ReadKey(true);
        }
    }
}