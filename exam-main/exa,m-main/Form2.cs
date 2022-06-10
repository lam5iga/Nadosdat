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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(textBox1.Text);
            if(comboBox1.SelectedIndex==0)
            {
                int summa = 300 * k;
                textBox2.Text = Convert.ToString(summa);

            }
            if (comboBox1.SelectedIndex == 1)
            {
                int summa = 500 * k;
                textBox2.Text = Convert.ToString(summa);
            }
            if (comboBox1.SelectedIndex == 2)
            {
                int summa = 700 * k;
                textBox2.Text = Convert.ToString(summa);
            }
        }
    }
}
