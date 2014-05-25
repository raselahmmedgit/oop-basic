using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPBasics_01
{
    public partial class CircleUI : Form
    {
        public CircleUI()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            double radius = Convert.ToDouble(radiusTextBox.Text);
            Circle aCircle = new Circle(radius);

            Circle circle2 = new Circle(20);
            Circle circle3 = new Circle(30);

            Circle circle4 = circle2;
            circle4.SetRadius(40);

            circle2 = new Circle(200);

            double val = circle4.GetArea();

            areaTextBox.Text = aCircle.GetArea().ToString();
            perimeterTextBox.Text = aCircle.GetPerimeter().ToString();
            diameterTextBox.Text = aCircle.GetDiameter().ToString();
        }
    }
}
