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
    public partial class Form2 : Form
    {
        private string dato;

        public Form2()
        {
            InitializeComponent();
            
        }


        public string Dato
        {
            set { dato = value; }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tboxfacturar.Text = dato;
        }
    }
}
