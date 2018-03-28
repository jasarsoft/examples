using System;
using System.Data.OleDb;

namespace Primjer05
{
    class Program
    {
        static void Main()
        {
            string database = "brodovi.accdb";
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" +
                                                        "Data Source=" + database +
                                                        ";Persist Security Info=True");

            try
            {
                conn.Open();
                OleDbCommand command = new OleDbCommand("SELECT * FROM Table1", conn);
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    if ((bool)reader["NaDnu"])
                        Console.WriteLine(reader["Naziv"] + " - " + reader["Drzava"]);

                reader.Close();
            }
            catch (OleDbException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
