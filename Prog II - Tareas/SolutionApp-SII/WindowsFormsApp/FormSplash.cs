using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class FormSplash : FormPadreSinControlBox
    {
        public FormSplash()
        {
            InitializeComponent();
        }

        private void FormSplash_Load(object sender, EventArgs e)
        {
            //Creando el hilo
            Thread myThread = new Thread(new ThreadStart(SplashStart));

            //Iniciar el hilo
            myThread.Start();
           
            
            //No olvidar cerrar/finalizar el hilo
            //myThread.Abort();
        }


        public void SplashStart()
        {
            // Dormir la forma principal por 5seg, solo fines de prueba, aqui iria lo que queremos cargar.
            Thread.Sleep(5000);

            this.Invoke((MethodInvoker)delegate{

                this.Close();

            });
          
        }

    }
}
