using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programa01_06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Propiedades de MessagesBox";
            lblgenero.Text = "";
            lblinformacion.Text = "";
        }

        private void btnmensaje_Click(object sender, EventArgs e)
        {
            ////only the message.
            //MessageBox.Show("First Message");

            ////The message and title for the window.
            //MessageBox.Show("Este si tienes titulo. ", "EDWIN ROMAN");

            //The message plus the button.
            //MessageBox.Show("Mensaje mas botones","titulo",MessageBoxButtons.AbortRetryIgnore);

            //The message, button and icon for the window.
            DialogResult r = MessageBox.Show("Seguro que quieres seguir?","Preguntando",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            //Tambien se encuentra un atributo para saber que boton eligio el usuario y llevar acabo operaciones, atraves.
            //se llama : DialogResult; ejemplo.

            if (r == DialogResult.Yes)
                lblinformacion.Text = "Seleciono la mejor opcion.";
            if (r == DialogResult.No)
                lblinformacion.Text = "Lastima escogio lo equivocado";
            
        }

        private void btngenero_Click(object sender, EventArgs e)
        {
            if(rbmasculino.Checked == true)
            {
               DialogResult r = MessageBox.Show("Seguro que quiere este genero","Genero",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(r== DialogResult.No)
                {
                    rbmasculino.Checked = false;
                    lblgenero.Text = "";
                }
                else
                {
                    lblgenero.Text = "Es Macho AHH!";
                }
            }


            if (rbfemenino.Checked == true)
            {
                DialogResult r = MessageBox.Show("Seguro/a que es de este genero?", "Genero", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.No)
                {
                    rbfemenino.Checked = false;
                    lblgenero.Text = "";
                }
                else
                {
                    lblgenero.Text = "Es una Hembra Uhy!";
                }
            }




        }
    }
}
