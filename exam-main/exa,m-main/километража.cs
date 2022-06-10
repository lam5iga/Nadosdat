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
    public partial class километража : Form
        
    {


        public километража()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Km = Convert.ToInt32(textBox1.Text);
            int petrol = Convert.ToInt32(textBox2.Text);
            float p = (petrol*100/Km);
            textBox3.Text = p.ToString();
        }
    }
}
