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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBox1.Text);
            if (c > 100)
            {
                int b = c - 50;
                textBox1.Text = b.ToString();
                label1.Text = "$" + b.ToString();

            }
            else
            {
                label1.Text = "Минимальный взнос 50 $";
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBox1.Text);
            if (c >=50)
            {
                int b = c + 50;
                textBox1.Text = b.ToString();
                label1.Text = "$" + b.ToString();

            }
            else
            {
                label1.Text = "Минимальный взнос 50 $";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form1 = new Form1();
            Form1.Show();
        }
    }
}
