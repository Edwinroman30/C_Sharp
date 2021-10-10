using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa04_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            conteo = 0;
            lbldate.Text = DateTime.Now.ToLongTimeString();
            tlslblestadobar.Text = trbconteo.Value.ToString();
        }

        private int conteo;

        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo++;
            lblrepresentation.Text = conteo.ToString();
            //this show the count in the form.

            if (conteo == 50)
            {
                Form1.ActiveForm.BackColor = Color.BlueViolet;
            }
            if (conteo == 100)
            {
                Form1.ActiveForm.BackColor = Color.Beige;
            }

            tmrpresent.Interval = trbconteo.Value;
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            tmrpresent.Enabled = true; // that is the same than down.
            //tmrpresent.Start(); that is the same than up.
            tmrclock.Start();
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            tmrpresent.Stop();
            tmrclock.Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            tmrpresent.Enabled = false;
            tmrclock.Stop();
        }

        private void tmrclock_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongTimeString();
        }

        private void trbconteo_Scroll(object sender, EventArgs e)
        {
            tmrpresent.Interval = trbconteo.Value;
            //This is  ToolStripStatusLabel from statuStrip
            tlslblestadobar.Text = trbconteo.Value.ToString();
        }
    }
}
