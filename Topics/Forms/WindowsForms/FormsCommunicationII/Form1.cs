using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnforma2_Click(object sender, EventArgs e)
        {
            Form2 fmado = new Form2();
            fmado.ShowDialog();
            //Truco es esperar que se muestre la forma y que esta procese los datos a travez de usuario, luego, esos datos
            //quedan en la forma para poder utilizarlos por la forma externa.

            lblcontenido.Text = fmado.Contenido;
            lblmensaje.Text = fmado.Mensaje;
        }
    }
}
