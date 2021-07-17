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
    public partial class ISSUEBOOK : Form
    {
        public ISSUEBOOK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stud_id = int.Parse(textBox2.Text.ToString());
            String check_stud = "select * from Student where Student_Id = '" + stud_id + "'";
            connection obj = new connection();
            DataTable dt = new DataTable();
            obj.fetch(check_stud, ref dt);
            int issue_quant = int.Parse(dt.Rows[0][4].ToString());

            if (dt.Rows.Count > 0)
            {
                int book_id = int.Parse(textBox3.Text.ToString());
                String check_book = "select * from Book where Book_Id = '" + book_id + "' ";
                connection obj1 = new connection();
                DataTable dt1 = new DataTable();
                obj1.fetch(check_book, ref dt1);
                int book_quant = int.Parse(dt1.Rows[0][3].ToString());

                if (dt1.Rows.Count > 0)
                {
                    String check = "select * from IssueData where S_id = " + stud_id + " and B_id = " + book_id + "";
                    connection obj2 = new connection();
                    DataTable dt2 = new DataTable();
                    obj2.fetch(check, ref dt2);

                    if (dt2.Rows.Count < 1)
                    {

                        string[] query = new string[3];
                        query[0] = "insert into IssueData values(" + stud_id + " , " + book_id + ")";
                        query[1] = "update Student set Issue_Book_Quantity = Issue_Book_Quantity+1 where Student_Id = " + stud_id + "";
                        query[2] = "update Book set Book_Quantity = Book_Quantity-1 where Book_Id = " + book_id + "";

                        if (issue_quant < 3 && book_quant > 0)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                connection obj3 = new connection();
                                obj3.dml(query[i]);
                            }
                        }

                        else
                        {
                            MessageBox.Show("\nBook cannot be isuued currently by the student");
                        }

                    }

                    else
                    {
                        MessageBox.Show("Student can't issue same book twice");
                    }

                }
                else
                {
                    MessageBox.Show("No such book found ");
                }
            }
            else
            {
                MessageBox.Show("No such student found ");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
