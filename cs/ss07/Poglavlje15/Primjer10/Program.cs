using System;
using System.Data;
using System.Data.OleDb;

namespace Primjer10
{
    class Program
    {
        static void Main()
        {
            string database = "brodovi.accdb";
            string connection = "Provider = Microsoft.ACE.OLEDB.12.0; " +
                                "Data Source=" + database + ";Persist Security Info=False";

            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM Table1", connection);
            OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "Table1");
            DataTable table = ds.Tables["Table1"];

            foreach (DataRow row in table.Rows)
                row["NaDnu"] = !(bool)row["NaDnu"];

            adapter.Update(ds, "Table1");
            ds.AcceptChanges();
        }
    }
}
