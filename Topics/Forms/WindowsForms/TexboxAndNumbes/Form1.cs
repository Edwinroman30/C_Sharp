using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblresultado.Text = "";
            txbA.Text = "0";
            txbB.Text = "0";
        }

        private void btnsumar_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txbA.Text);
            double b = Convert.ToDouble(txbB.Text);
            double r = a + b;

            lblresultado.Text = r.ToString();
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txbA.Text);
            double b = Convert.ToDouble(txbB.Text);
            double r = a - b;

            lblresultado.Text = r.ToString();
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txbA.Text);
            double b = Convert.ToDouble(txbB.Text);
            double r = a * b;

            lblresultado.Text = r.ToString();
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txbA.Text);
            double b = Convert.ToDouble(txbB.Text);
           
            if (a != 0 && b != 0)
            {
                double r = a / b;
                lblresultado.Text = r.ToString();
            }
            else
            {
                MessageBox.Show("ERROR no es posible dividir entre 0");
                Application.Exit();
            }

        }
    }
}
