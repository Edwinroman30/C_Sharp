using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa04_00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            conteo = 0;
        }

        private int conteo;

        private void tmrprogreso_Tick(object sender, EventArgs e)
        {
            conteo++;
            lblconteo.Text = conteo.ToString();
            tmrprogreso.Interval = tbrtimer.Value;

           //existe una funcion de ProgressBar hace avanzar la posicion 
           //actual de la barra en la cantidad del ProgressBar. PerformStep();
           

            if (conteo < 100)
                pbrresult.Value = conteo;
            else
                conteo = 0;

        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            tmrprogreso.Start();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            tmrprogreso.Stop();
        }

        private void btnrepeat_Click(object sender, EventArgs e)
        {
            conteo = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrprogreso.Enabled = false;
        }
    }
}
