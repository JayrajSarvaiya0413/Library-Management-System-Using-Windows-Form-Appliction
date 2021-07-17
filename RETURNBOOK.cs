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
    public partial class RETURNBOOK : Form
    {
        public RETURNBOOK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int stud_id = int.Parse(textBox2.Text.ToString());
            string check_stud = "select * from IssueData where S_id = " + stud_id + "";
            connection obj = new connection();
            DataTable dt = new DataTable();
            obj.fetch(check_stud, ref dt);

            if (dt.Rows.Count > 0)
            {
                int book_id = int.Parse(textBox3.Text.ToString());
                string check_book = "select * from IssueData where S_id = " + stud_id + " and B_id = " + book_id + "";
                connection obj1 = new connection();
                DataTable dt1 = new DataTable();
                obj1.fetch(check_book, ref dt1);

                if (dt1.Rows.Count > 0)
                {
                    string[] query = new string[3];
                    query[0] = "delete from IssueData where S_id = " + stud_id + " and B_id = " + book_id + "";
                    query[1] = "update Student set Issue_Book_Quantity = Issue_Book_Quantity-1 where Student_Id = " + stud_id + "";
                    query[2] = "update Book set Book_Quantity = Book_Quantity+1 where Book_Id = " + book_id + "";

                    for (int i = 0; i < 3; i++)
                    {
                        connection obj2 = new connection();
                        obj2.dml(query[i]);
                    }

                }
                else
                {
                    MessageBox.Show("\nNo such book is issued by the student");
                }
            }
            else
            {
                MessageBox.Show("\nNo book is currently isuued by the student");
            }
        }
    }
    }

