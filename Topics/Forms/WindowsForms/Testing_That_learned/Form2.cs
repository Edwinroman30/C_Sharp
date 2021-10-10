using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testing_That_learned
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        string nombre;
        
        public string Accesor
        {
            get
            {
                return nombre;
            }
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
            nombre = tboxname.Text;
            this.Close();
        }
    }
}
