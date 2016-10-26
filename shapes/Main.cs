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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        static int triangles, squares, rectangles, circles;

        private void rbtnRightTriange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRightTriangle.Checked)
            {
                AddRightTriangle frmTriangle = new AddRightTriangle();
                frmTriangle.ShowDialog();
                rbtnRightTriangle.Checked = false;

                triangles = frmTriangle.countTriangles;
                lblCountRightTriangles.Text = triangles.ToString();
                
            }
        }

        private void rbtnSquare_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnSquare.Checked)
            {
                AddSquare frmSquare = new AddSquare();
                frmSquare.ShowDialog();
                rbtnSquare.Checked = false;

                squares = frmSquare.countSquares;
                lblCountSquares.Text = squares.ToString();
            }
        }

        private void rbtnRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRectangle.Checked)
            {
                AddRectangle frmRectangle = new AddRectangle();
                frmRectangle.ShowDialog();
                rbtnRectangle.Checked = false;

                rectangles = frmRectangle.countRectangles;
                lblCountRectangles.Text = rectangles.ToString();
            }

        }

        private void rbtnCircle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCircle.Checked)
            {
                AddCircle frmCircle = new AddCircle();
                frmCircle.ShowDialog();
                rbtnCircle.Checked = false;

                circles = frmCircle.countCircles;
                lblCountCircles.Text = circles.ToString();

            }
        }
    }
}
