using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_App_Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsaludar_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = "HELLO WORLD";   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblmensaje.Text = "";
            //El evento form_load es default del form.
        }

        private void btnchance_Click(object sender, EventArgs e)
        {
            this.Text = "New Tittle";
        }

        private void btndespedida_Click(object sender, EventArgs e)
        {
            lblmensaje.Text = "GOOD BYE";
        }
    }
}
