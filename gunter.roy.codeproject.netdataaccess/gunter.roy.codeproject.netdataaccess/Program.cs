using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace gunter.roy.codeproject.netdataaccess
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = @"Data Source=dchildsw7p\sqlexpress;Initial Catalog=codeproject;Integrated Security=SSPI;Timeout=2";

                Console.WriteLine("About to open...");
                connection.Open();

                UseDataReader(connection, "select * from users");
                UseDataReader(connection, "select * from commands");

                UseDataAdapter(connection, "select * from users");
                UseDataAdapter(connection, "select * from commands");

                Console.WriteLine("About to close...");
                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        static void UseDataAdapter(SqlConnection connection, string query)
        {
            try
            {
                Console.WriteLine("About to run query...");

                SqlCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = query;

                SqlDataAdapter myAdapter = new SqlDataAdapter(myCommand);

                DataSet myDataset = new DataSet();
                myAdapter.Fill(myDataset);

                // For each table in the DataSet, print the row values.
                foreach (DataTable table in myDataset.Tables)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        foreach (DataColumn column in table.Columns)
                        {
                            Console.WriteLine(row[column]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void UseDataReader(SqlConnection connection, string query)
        {
            try {
                Console.WriteLine("About to run query...");

                SqlCommand myCommand = connection.CreateCommand();
                myCommand.CommandText = query;

                SqlDataReader myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    object[] fields = new object[myReader.FieldCount];
                    for (int i = 0; i < fields.Length; i++)
                    {
                        fields[i] = myReader[i];
                    }
                    Console.WriteLine("Database record: {0}", string.Join(",", fields));
                }
                myReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
