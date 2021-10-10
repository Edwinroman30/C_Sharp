using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblmensaje.Text = "";
        }

        private void btnsaludar_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = txbnombre.Text + ", es el estimado/a que vamos a saludar.";
            
        }
    }
}
