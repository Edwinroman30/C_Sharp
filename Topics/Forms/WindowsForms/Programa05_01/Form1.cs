using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa05_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cklbarticulos.Items.Add("Cable UTP");
            cklbarticulos.Items.Add("Cable USB");
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            cklbarticulos.Items.Add(tboxinsert.Text);
            
        }

        private void cklbarticulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = cklbarticulos.SelectedIndex;

            if (n != -1)
            {
                lblresult.Text = cklbarticulos.Items[n].ToString();
            }

            //existe lo que es el GetItemchecked/ cklbarticulos.GetItemchecked(indice)
        }
    }
}
