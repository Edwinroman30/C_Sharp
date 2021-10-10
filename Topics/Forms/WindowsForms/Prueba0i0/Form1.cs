using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba0i0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime today =  DateTime.Now;
            lbltoday.Text = today.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor= 0.0;
            string recibir;
            Form2 factura = new Form2();
            recibir = "=============EDWIN IMPRESS============= \r\n";
            recibir += "Bienvenido Mr."+tboxcustumer.Text + "\r\n";

            if(rbtusb.Checked == true)
            {
                valor += 350;
                recibir += "USB Kingston \r\n";
      
            }
            if (rbtmouse.Checked == true)
            {
                valor += 300;
                recibir += "Mouses Logitech \r\n";
            }
            if (rbtaudifono.Checked == true)
            {
                valor += 475;
                recibir += "Audifonos Argom M3 \r\n";
            }
            if (rbtteclado.Checked == true)
            {
                valor += 450;
                recibir += "Teclado Gaming \r\n";
            }
            if (rbtbocina.Checked == true)
            {
                valor += 850;
                recibir += "Bocinas JBL \r\n";
            }
            if (rbtcable.Checked == true)
            {
                valor += 350;
                recibir += "Cables VGA/HDMI \r\n";
            }
            recibir += "Total: $" + valor.ToString();

            lblresult.Text = "$" + valor.ToString();
            lblresult.BackColor = Color.GreenYellow;
            factura.Dato = recibir;
            factura.ShowDialog();
        }
    }
}
