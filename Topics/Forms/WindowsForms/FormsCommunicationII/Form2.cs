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
    public partial class Form2 : Form
    {
        private string mensaje;
        private string contenido;

        public Form2()
        {
            InitializeComponent();
        }


        public string Mensaje
        {
            get { return mensaje; }
        }

        public string Contenido
        {
            get { return contenido; }
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            mensaje = tboxmensaje.Text;
            contenido = tboxcontenido.Text;
            this.Close();
        }
    }
}
