using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncotizar_Click(object sender, EventArgs e)
        {

            double costo;
            string cotizacion;

            costo = Convert.ToDouble(tboxcosto.Text);

            cotizacion = "Sr." +tboxnombre.Text + " esta llevando la cotizacion \r\n";

            if(rbbasico.Checked == true)
            {
                costo += 500;
                cotizacion += "Se agrego un seguro basico de $500. \r\n";
            }

            if(rbterceros.Checked == true)
            {
                costo += 1000;
                cotizacion += "Se agrego un seguro para terceros de $1000. \r\n";
            }

            if (rbtotal.Checked == true)
            {
                costo += 1500;
                cotizacion += "Se agrego un seguro total de $1500. \r\n";
            }

            
            if(ckaire.Checked == true)
            {
                costo +=  500;
                cotizacion += "Se equipo un sistema de aire. \r\n";
            }

            if (cksonido.Checked == true)
            {
                costo += 800;
                cotizacion += "Se equipo un sistema de sonido.  \r\n";
            }

            cotizacion += "Un total de: " + costo.ToString();
            tboxpresentacion.Text = cotizacion;


        }
    }
}
