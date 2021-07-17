using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAYRAJ_RUBRIC_TASK_2
{
    public partial class ISSUEBOOKINFO : Form
    {
        public ISSUEBOOKINFO()
        {
            InitializeComponent();
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        { 
         

        }

        private void ISSUEBOOKINFO_Load_1(object sender, EventArgs e)
        {
            string query = "select Name from Student";
            connection obj = new connection();
            DataTable dt = new DataTable();
            obj.fetch(query, ref dt);
            

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dt.Rows[i][0].ToString());
                }
            }
            else
            {
                MessageBox.Show("No student available");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string query = "select Book.Book_Title from (( IssueData INNER JOIN Student ON IssueData.S_id = Student.Student_Id )INNER JOIN Book ON IssueData.B_id = Book.Book_Id )where Student.Name = '" + comboBox1.SelectedItem + "'";
            connection obj1 = new connection();
            DataTable dt1 = new DataTable();
            obj1.fetch(query, ref dt1);

            if (dt1.Rows.Count > 0)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    listBox1.Items.Add(dt1.Rows[i][0].ToString());
                }
            }
            else
            {
                listBox1.Items.Add("No book currently issued by student");
            }
        }
    }
}
