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
    public partial class AddSquare : Form
    {
        public AddSquare()
        {
            InitializeComponent();
        }
        public int countSquares; 

        private void add_Click(object sender, EventArgs e)
        {
            countSquares++; 

            double side1;
            if (double.TryParse(tbxSide1S.Text, out side1))
            {
                // Perimeter
                double p = side1 * 4;
                
                lblPerS.Text = p.ToString("f2");

                // Area
                double ar = side1 * side1;
                lblAreaS.Text = ar.ToString("f2");
            }
            else
                MessageBox.Show("Sides missing or not numeric", " Sides Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
