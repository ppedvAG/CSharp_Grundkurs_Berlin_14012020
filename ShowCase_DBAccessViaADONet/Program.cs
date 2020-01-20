using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace ShowCase_DBAccessViaADONet
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionStr = "localhost\\SQLExpress; .........";

            SqlConnection sqlConnection = new SqlConnection(connectionStr);
            sqlConnection.Open();

            string sqlCommandText = "SELECT * FROM Customers";
            SqlCommand command = new SqlCommand(sqlCommandText, sqlConnection);

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);

            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            DataSet ds = new DataSet();
            ds.Tables.Add(new DataTable("NeueErgebnissTabelle"));

            if (dt.Rows.Count > 0)
            {
            }

            if (dt.Columns.Count > 0)
            {
            }

            sqlConnection.Close();
        }
    }
}
