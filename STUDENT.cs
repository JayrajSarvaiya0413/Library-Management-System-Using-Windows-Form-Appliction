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
    public partial class STUDENT : Form
    {
        public STUDENT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text.ToString();
            string sem = comboBox1.SelectedItem.ToString();
            string branch = textBox3.Text.ToString();

            string query = "insert into Student values('" + name + "','" + sem + "','" + branch + "'," + 0 + ")";

            connection obj = new connection();
            obj.dml(query);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
