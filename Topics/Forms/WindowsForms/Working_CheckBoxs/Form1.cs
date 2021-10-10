using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            double resultado = 0.0;

            if (chkmonitor.Checked == true)
            { resultado = resultado + 150; }
            if (chkmouses.Checked == true)
            { resultado = resultado + 10; }
            if (chkteclado.Checked == true)
            { resultado = resultado + 30; }

            MessageBox.Show("Mostrar el resultado final XD :" + resultado);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblinformacion.Text = "";
        }

        private void chkmonitor_CheckedChanged(object sender, EventArgs e)
        {
            if(chkmonitor.Checked == true)
            lblinformacion.Text = " Monitor,";
        }

        private void chkmouses_CheckedChanged(object sender, EventArgs e)
        {
            if(chkmouses.Checked == true)
            lblinformacion.Text +=  " Mouses,";
        }

        private void chkteclado_CheckedChanged(object sender, EventArgs e)
        {
            if(chkteclado.Checked == true)
            lblinformacion.Text += " Teclado.";
        }
    }
}
