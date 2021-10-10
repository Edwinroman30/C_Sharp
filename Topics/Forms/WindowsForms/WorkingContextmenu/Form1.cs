using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este es un programa hecho por EDWIN ROMAN","Acerca de");
        }

        //Funcion util para rellenar los StatusStrip
        void StatusInformation(double valor1, double valor2, string operacion, double total)
        {
            stslblcantidad.Text = "A=" + valor1.ToString() + " ,B=" + valor2.ToString();
            stslbloperacion.Text = operacion;
            stslblresultado.Text = "R= " + total.ToString();
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tboxA.Text);
            double b = Convert.ToDouble(tboxB.Text);
            double r;

            r = a + b;
            lblresult.Text = r.ToString();

            StatusInformation(a, b, "SUMA", r);
           
        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tboxA.Text);
            double b = Convert.ToDouble(tboxB.Text);
            double r;

            r = a - b;
            lblresult.Text = r.ToString();
            StatusInformation(a, b, "RESTA", r);
        }

        private void multiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tboxA.Text);
            double b = Convert.ToDouble(tboxB.Text);
            double r;

            r = a * b;
            lblresult.Text = r.ToString();
            StatusInformation(a, b, "MULTIPLICACION", r);
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tboxA.Text);
            double b = Convert.ToDouble(tboxB.Text);
            double r;

            if (a <= 0 || b <= 0)
            {
                MessageBox.Show("ERRO no se puede dividir entre 0");

                if (a == 0)
                {
                    tboxA.BackColor = Color.Red;
                }
                if (b == 0)
                {
                    tboxB.BackColor = Color.Red;
                }

            }
            else
            {
                tboxA.BackColor = Color.White;
                tboxB.BackColor = Color.White;
                r = a / b;
                lblresult.Text = r.ToString();
                StatusInformation(a, b, "DIVISION", r);
            }

            
        }

        private void habillitarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            tboxA.Enabled = habillitarToolStripMenuItem.Checked;
            tboxB.Enabled = habillitarToolStripMenuItem.Checked;
        }

        private void ModooscuroToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (ModooscuroToolStripMenuItem.Checked == true)
                Form1.ActiveForm.BackColor = Color.BurlyWood;
            else
                Form.ActiveForm.BackColor = Color.White;
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tboxA.Clear();
        }

        private void numeroAzarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            double valor;

            valor = rdn.Next(0, 100);
            tboxA.Text = valor.ToString();
        }

        private void cleanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tboxB.Clear();
        }

        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            tboxB.Text = rdn.Next(0, 100).ToString();
        }
    }
}
