using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MultimediaPlayer_DCU
{
    public partial class FMain : Form
    {
        public FMain()
        {
            //Creando el hilo

            Thread myThread = new Thread(new ThreadStart(SplashStart));

            //Iniciar el hilo

            myThread.Start();

            // Dormir la forma principal por 5seg, solo fines de prueba, aqui iria lo que queremos cargar.
            Thread.Sleep(5000);

            //Luego se cargaran todos los componenetes de nuestra forma, ojo tomar esto encuenta si necesitamos ciertos componentes
            // de la forma.

            InitializeComponent();


            //No olvidar cerrar/finalizar el hilo
            myThread.Abort();

        }

        //My funcion para iniciar
        private void SplashStart()
        {
            //Para que corrar el Splash de manera iniciar como una app
            Application.Run(new SplashScreen());

        }

        private void FMain_Load(object sender, EventArgs e)
        {

        }
    }
}
