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
    public partial class BOOK : Form
    {
        public BOOK()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text.ToString();
            string author = textBox3.Text.ToString();
            double quantity = double.Parse(textBox4.Text.ToString());

            string query = "insert into Book values('" + name + "' , '" + author + "' , " + quantity + ")";

            connection obj = new connection();
            obj.dml(query);
        }
    }
}
