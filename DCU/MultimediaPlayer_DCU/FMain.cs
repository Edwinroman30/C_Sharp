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
        private bool __play = false;
        private List<string> nombreArchivos;
        private List<string> rutasArchivos;

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EN caso de que se seleccione algun archivo.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] selectedItemsNames;
                string[] selectedItemsURL;

                if (nombreArchivos is null)
                {
                    nombreArchivos = openFileDialog1.SafeFileNames.ToList();
                    rutasArchivos = openFileDialog1.FileNames.ToList();

                    foreach (var nombreArchivo in nombreArchivos)
                    {
                        tboxPlayList.Items.Add(nombreArchivo);
                    }


                }
                else
                {

                    selectedItemsNames = openFileDialog1.SafeFileNames;
                    selectedItemsURL = openFileDialog1.FileNames;


                    for (int i = 0; i < selectedItemsNames.Length; i++)
                    {
                        nombreArchivos.Append(selectedItemsNames[i]);
                        rutasArchivos.Append(selectedItemsURL[i]);
                        tboxPlayList.Items.Add(selectedItemsNames[i]);

                    }


                }

                Reproductor.URL = rutasArchivos[0];
                btnPlay.Image = Properties.Resources.pause;


            }
            else
            {
                MessageBox.Show(openFileDialog1.SafeFileName + ", usted debe de seleccionar un archivo");
                Console.Beep();
            }

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayStatus();
        }

        private void PlayStatus()
        {
            switch (__play)
            {
                case true:
                    Reproductor.Ctlcontrols.pause();
                    btnPlay.Image = Properties.Resources.play_button;
                    __play = false;
                    break;

                case false:
                    Reproductor.Ctlcontrols.play();
                    btnPlay.Image = Properties.Resources.pause;
                    __play = true;
                    break;
            }
        }

        private void tboxPlayList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Reproductor.URL = rutasArchivos[tboxPlayList.SelectedIndex];
        }

        private void macTrackBar1_ValueChanged(object sender, decimal value)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.stop();
            btnPlay.Image = Properties.Resources.play_button;
            __play = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            actualizarDatosTrack();
            macTrackBar1.Value = (int)Reproductor.Ctlcontrols.currentPosition;
            trackVolumen.Value = Reproductor.settings.volume;
        }

        public void actualizarDatosTrack()
        {
            if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                //Representa el tiempo de duracion
                macTrackBar1.Maximum = (int)Reproductor.Ctlcontrols.currentItem.duration;
                timer1.Start();
                lblDuration.Text = Math.Round(Reproductor.Ctlcontrols.currentPosition, 2).ToString();

            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (Reproductor.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                macTrackBar1.Value = 0;
            }
        }

        private void Reproductor_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            actualizarDatosTrack();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.next();
            __play = false;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Reproductor.Ctlcontrols.previous();
            __play = false;

        }
    }
}
