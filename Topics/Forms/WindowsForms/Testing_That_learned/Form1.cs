using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_That_learned
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double total= 0;
            int cantidad = 0;

            Form2 Fml = new Form2();
            Fml.ShowDialog();
            stslblname.Text= "Name: "+ Fml.Accesor.ToUpperInvariant();

            if (ckbtv.Checked == true)
            {
                total += 25000;
                cantidad += 1;
            }
            if (ckbhp.Checked == true)
            {
                total += 5000;
                cantidad += 1;
            }
            if (ckbabanico.Checked == true)
            {
                total += 2000;
                cantidad += 1;
            }
            if (ckbaire.Checked == true)
            {
                total += 5000;
                cantidad += 1;
            }
            if (ckbwatch.Checked == true)
            {
                total += 3000;
                cantidad += 1;
            }
            if (ckbusb.Checked == true)
            {
                total += 200;
                cantidad += 1;
            }

            stslbltotal.Text= "Total = "+ total.ToString();
            stslblcantidad.Text = "Cantidad = " + cantidad.ToString() + "/6";
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.Blue;
        }

        private void anotherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.BackColor = Color.CornflowerBlue;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
