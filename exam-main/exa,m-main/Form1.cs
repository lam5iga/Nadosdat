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
    
    public partial class Form1 : Form
    {
        int price;
        int k;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            int price = 12;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            int price = 24;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int price = 60;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k = Convert.ToInt32(textBox2.Text);
            int summa = k * price;
            textBox1.Text = summa.ToString();
        }
    }
}
