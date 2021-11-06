using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormLogin : FormPadreControlClose
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            //Claro esto es de prueba.
            Program.userAuthentication = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Claro esto es de prueba.
            Program.userAuthentication = false;
            this.Close();
        }
    }
}
