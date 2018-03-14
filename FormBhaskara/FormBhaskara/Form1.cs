using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBhaskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            int a, b, c = 0;
            double x1, x2 = 0;

            a = Convert.ToInt16(textBoxA.Text);
            b = Convert.ToInt16(textBoxB.Text);
            c = Convert.ToInt16(textBoxC.Text);

            if ((b * b - 4 * a * c) >= 0)
            {
                x1 = Convert.ToDouble((-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
                x2 = Convert.ToDouble((-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));

                textBoxR1.Text = x1.ToString();
                textBoxR2.Text = x2.ToString();
            }
            else
            {
                MessageBox.Show("Essa equação não possui raízes reais.");
            }
        }
    }
}
