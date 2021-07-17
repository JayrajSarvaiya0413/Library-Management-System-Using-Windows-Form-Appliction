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
    public partial class MANU : Form
    {
        public MANU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            STUDENT j2 = new JAYRAJ_RUBRIC_TASK_2.STUDENT();
            MANU j1 = new MANU();
            j1.Close();
            j2.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            BOOK j2 = new JAYRAJ_RUBRIC_TASK_2.BOOK();
            MANU j1 = new MANU();
            j1.Close();
            j2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ISSUEBOOK j2 = new JAYRAJ_RUBRIC_TASK_2.ISSUEBOOK();
            MANU j1 = new MANU();
            j1.Close();
            j2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RETURNBOOK j2 = new JAYRAJ_RUBRIC_TASK_2.RETURNBOOK();
            MANU j1 = new MANU();
            j1.Close();
            j2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ISSUEBOOKINFO j2 = new JAYRAJ_RUBRIC_TASK_2.ISSUEBOOKINFO();
            MANU j1 = new MANU();
            j1.Close();
            j2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
