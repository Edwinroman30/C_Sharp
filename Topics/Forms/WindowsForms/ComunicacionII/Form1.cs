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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntabrir_Click(object sender, EventArgs e)
        {
            //Windows Forms C# 13
            Form2 Formulario2 = new Form2();

            DialogResult Result = Formulario2.ShowDialog();

            if (Result == DialogResult.OK)
            {
                lblmensaje.Text = Formulario2.Mensaje;
                lblrecibe.Text = Formulario2.Recibe;
            }
            if(Result == DialogResult.Cancel)
            {
                MessageBox.Show("Se cancelo la operación...");
            }
        }
    }
}
