using System;
using System.Text;
using System.Data.SqlClient; // Requiered for SQL Connections

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
                builder.DataSource = "localhost\\instanceName";   // Name or IP of the server followed by the instance of SQL. Note that its separate with "\\"
                builder.UserID = "sa";              // in this case, we use user "sa" for authentication
                builder.Password = "myPassword";      // update me
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
            // If there is an error, print it
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            // End of process regardless of error
            Console.WriteLine("Proceso finalizado. Presione cualquier tecla para cerrar...");
            Console.ReadKey(true);
        }
    }
}