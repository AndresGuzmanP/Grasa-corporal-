using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial777
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();





        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new DATOS();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form3();
            form.Show();

        }
    }
}
