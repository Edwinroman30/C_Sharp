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
    public partial class Form1 : Form
    {
        //Comunicacion entre formularios
        //Diferentes formas de comunicación con los formularios:

        //Forma desde el constructor del formulario a comunicar.

        Form2 formulario1 = new Form2("Level Junior - MENSAJE POR DEFECTO");

        public Form1()
        {
            InitializeComponent();
        }


        private void btnenvia2_Click(object sender, EventArgs e)
        {
            //Forma desde propiedades o metodos publicos definidos por este.
                formulario1.Propiedad = tboxenvia1.Text;
                formulario1.ShowDialog();
            //Comunicacion entre formularios
        }
    }
}
