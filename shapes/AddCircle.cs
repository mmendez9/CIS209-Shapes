using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapes
{
    public partial class AddCircle : Form
    {
        public AddCircle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double radio;
            if (double.TryParse(tbxRadio.Text, out radio))
            {
                // Circumference
                double cir = 2 * (Math.PI * radio);
                lblCir.Text = cir.ToString("f2");

                // Area
                double ar = Math.PI * Math.Pow(radio, 2);
                lblAreaC.Text = ar.ToString("f2");
            }
            else
                MessageBox.Show("Missing or not numeric", "Diameter Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
