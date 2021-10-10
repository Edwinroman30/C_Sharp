using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbmAlimentos.Items.Add("Huevos");
            String [] elements = {"Queso","Jamon"};
            cbmAlimentos.Items.AddRange(elements); //Add una lista.

        }

        private void cbmAlimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = cbmAlimentos.SelectedIndex;

            lblindex.Text = "Indice > " + indice.ToString();

            lbltexto.Text = "Elementos > " + cbmAlimentos.Items[indice].ToString();

        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            cbmAlimentos.Items.Add(tboxinserted.Text);
            MessageBox.Show("Mensajes", "Titulo del mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
