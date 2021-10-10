using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunicacionII
{
    public partial class Form2 : Form
    {

        private string mensaje;
        private string recibe;

        public Form2()
        {
            InitializeComponent();
        }

        public string Mensaje
        {
            get { return mensaje; }
        }

        public string Recibe
        {
            get { return recibe; }
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            mensaje = tboxmensaje.Text;
            recibe = tboxrecibe.Text;
            this.Close();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
