using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayTinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a =Double.Parse(txtSoA.Text);
            double b =Double.Parse(txtSoB.Text);
            double c = a + b;

            txtKQ.Text = c.ToString();
        }
    }
}
