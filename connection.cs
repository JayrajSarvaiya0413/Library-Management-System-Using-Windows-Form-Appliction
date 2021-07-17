using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace JAYRAJ_RUBRIC_TASK_2
{
    class connection
    {
        public string sj = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Dell\OneDrive\Desktop\sem 6\DOT NET TECHNOLOGY\ADO_NET_APPLICTION\JAYRAJ_RUBRIC_TASK_2\JAYRAJ_RUBRIC_TASK_2\honestyLibrary.mdf;Integrated Security=True";

        public void dml(string q) //insert update delete queries
        {
            //string q  =  Queries to be executed
            SqlConnection con = new SqlConnection(sj);  //Connecting Database to my program
            SqlCommand cmd = new SqlCommand(q, con);   // to execute queries.
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("!!!!....OPERATION PERFORMED SUCESSFULLY....!!!!!");
            }
            catch
            {
                con.Close();
                MessageBox.Show("!!!!....OOPS OPERATION FAILED....!!!!!");
            }
        }

        public void fetch(string q, ref DataTable dt) //Select queries
        {
            SqlDataAdapter da = new SqlDataAdapter(q, sj); // fetches data in xml format
            da.Fill(dt);

        }
    }
}
