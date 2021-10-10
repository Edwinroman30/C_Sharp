using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_02
{
    public partial class Form2 : Form
    {
        public Form2(string reci)
        {
            InitializeComponent();

            string dato;
            dato = reci;
            lblrecibe1.Text = dato;

        }

       private string propiedad;
        
        public string Propiedad
        {
            set
            {
                propiedad = value;
                lblrecibe2.Text = propiedad;
            }
     
        }


    }
}
