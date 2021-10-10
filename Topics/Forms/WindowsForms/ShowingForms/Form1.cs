using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa02_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            Form2 forma2 = new Form2();
            forma2.ShowDialog();

            //Importacia: el ShowDialog() tienes que trabajar solo con esa ventana (Es modal).
            //que se muestra, al contrario el Show() normal puede trabajar con varias.


        }
    }
}
