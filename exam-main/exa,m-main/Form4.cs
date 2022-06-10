using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace i_love
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form5 = new Form5();
            Form5.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form6 = new Form6();
            Form6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form7 = new Form7();
            Form7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form8 = new Form8();
            Form8.Show();
        }
    }
}
