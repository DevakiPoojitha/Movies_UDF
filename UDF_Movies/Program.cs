using System.Data.SqlClient;

namespace UDF_Movies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string ConnectionStr = @"Data Source=INLPF1AVPDL;Initial Catalog=MyDb;trusted_connection=true";
                SqlConnection sqlconn = new SqlConnection(ConnectionStr);
                sqlconn.Open();

                Console.WriteLine("Enter The Choice");
                string choice = Console.ReadLine();

                string query = @"select horror_movies,kids_movies from udf_movies";
                SqlCommand cmd = new SqlCommand(query, sqlconn);

                SqlDataReader reader = cmd.ExecuteReader();
                int i = 0;
                while (reader.Read())
                {
                    if (i == 5) break;

                    switch (choice)
                    {
                        case "horror":
                            {

                                Console.Write(reader[0]);

                            }
                            break;
                        case "kids":
                            {

                                Console.WriteLine(reader[1]);
                            }
                            break;
                    }
                    i++;
                    Console.WriteLine();
                    Console.WriteLine("Data Pushed Successfully!!");
                }
                reader.Close();
                sqlconn.Close();

            }
            catch (SqlException sqlex)
            {
                Console.WriteLine(sqlex.Message);
                Console.WriteLine("error in sql");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("error");

            }
        }
    }
}