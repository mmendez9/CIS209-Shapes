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
    public partial class AddRectangle : Form
    {
        public AddRectangle()
        {
            InitializeComponent();
        }

        public int countRectangles;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            countRectangles++;

            double side1, side2;
            if (double.TryParse(tbxSide1.Text, out side1) && double.TryParse(tbxSide2.Text, out side2))
            {
                // Perimeter
                double p = (side1 * 2) + (side2 * 2);
                lblPerR.Text = p.ToString("f2");

                // Area
                double ar = side1 * side2;
                lblAreaR.Text = ar.ToString("f2");

                
            }
            else
                MessageBox.Show("Sides missing or not numeric", " Sides Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
