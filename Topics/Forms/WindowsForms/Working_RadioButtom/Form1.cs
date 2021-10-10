using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_05
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
            rbblack.Checked = true;
            rbsumar.Checked = true;
            txbA.Text = "0";
            txbB.Text = "0";
            this.Text = "Radio Buttons";
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            double a, b;
            double r = 0.0;

            a = Convert.ToDouble(txbA.Text);
            b = Convert.ToDouble(txbB.Text);

            if (rbsumar.Checked == true)
                r = a + b;
            if(rbrestar.Checked == true)
                r = a - b;
            if(rbmultiplicar.Checked == true)
                r = a * b;
            if(rbdividir.Checked== true)
            {
                if(a!= 0 && b != 0)
                {
                    r = a / b;
                }
                else
                {
                    MessageBox.Show("Lo sentimos pero no podemos dividir a 0");
                    Application.Exit();
                }
            }

            lblresultado.Text = r.ToString();

        }

        private void btnactivar_Click(object sender, EventArgs e)
        {
            if (rbred.Checked == true)
                lblresultado.ForeColor = Color.Red;
            if (rbyellow.Checked == true)
                lblresultado.ForeColor = Color.Yellow;
            if (rbgreen.Checked == true)
                lblresultado.ForeColor = Color.Green;
            if (rbblack.Checked == true)
                lblresultado.ForeColor = Color.Black;
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            txbA.Clear();
            txbB.Clear();
            lblresultado.Text = "";
            rbblack.Checked = true;
            rbsumar.Checked = true;
        }
    }
}
