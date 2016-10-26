using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shapes
{
    public partial class AddRightTriangle : Form
    {
        public AddRightTriangle()
        {
            InitializeComponent();
        }

        public int countTriangles;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double side1, side2;
            if (double.TryParse(tbxSide1.Text, out side1) && double.TryParse(tbxSide2.Text, out side2))
            {
                // Create the RightTriangle Object
                RightTriangle rt = new RightTriangle();
                rt.side1 = side1;
                rt.side2 = side2;

                // Hypotenuse
                double hy, a, b;
                a = Math.Pow(side1, 2);
                b = Math.Pow(side2, 2);
                hy = Math.Sqrt(a + b);
                rt.hypotenuse = hy;
                lblHypotenuse.Text = hy.ToString("f2");

                // Area
                double ar = (side1 * side2) / 2;
                lblArea.Text = ar.ToString("f2");
                rt.area = ar;

                // Perimeter
                double p = side1 + side2 + hy;
                rt.perimeter = p;
                lblPerimeter.Text = p.ToString("f2");

                /*Graphics g = CreateGraphics();
                Pen pen = new Pen(Color.Red, 3);

                // Draw the trinagle
                g.DrawLine(pen, 325, 100, 325, 175);
                g.DrawLine(pen, 325, 250, 400, 250);
                g.DrawLine(pen, 300, 250, 200, 200);*/
            }
            else
                MessageBox.Show("Sides missing or not numeric", " Sides Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
