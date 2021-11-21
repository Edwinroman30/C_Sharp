using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using ClassLibrary.Bussines;
using ClassLibrary.Entities;

namespace WindowsFormsApp
{
    public partial class FormRegistroMercancias : Form
    {
        private BusinessLogicLayer _businessLogicLayer;
        private CMercaderia _cMercaderia; //me servira para actualizar y capturar data del GRIDVIEW
        private bool _isValid = false;

        public FormRegistroMercancias()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
            cboxStatus.SelectedIndex = 0;
            cboxElimanable.SelectedIndex = 0;
        }

        #region Metodos Handlers
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //SI TODO ESTA BIEN
            if (SaveMercaderia())
            {
                this.Close();
                //Limpieza de las cajas
                ClearBoxes();
                //Cargar la data actualizada del dataGridView, con un metodo de mi form padre.
                ((FormMain)this.Owner).PopulateMercancias();
            }

        }

        #endregion

        #region Validaciones y limpieza de cajas
        private void ClearBoxes()
        {
            tboxDescripcion.Clear();
            tboxExistencias.Clear();
            tboxComentario.Clear();
        }

        private void Validaciones()
        {
            if (string.IsNullOrWhiteSpace(tboxDescripcion.Text) || string.IsNullOrWhiteSpace(tboxDescripcion.Text))
            {
                MessageBox.Show("Debe de indicar una descripción...");
                _isValid = true;
            }
            else
            if (string.IsNullOrWhiteSpace(tboxExistencias.Text) || string.IsNullOrWhiteSpace(tboxExistencias.Text) || Convert.ToInt32(tboxExistencias.Text) < 0)
            {       
                MessageBox.Show("Debe de indicar la cantidad de existencia y esta debe de ser mayor que 0...");
                _isValid = true;
            }
            else
            if (string.IsNullOrWhiteSpace(tboxComentario.Text) || string.IsNullOrWhiteSpace(tboxComentario.Text))
            { 
                MessageBox.Show("Debe de indicar un comentario...");
                _isValid = true;
            }
            else
            {
                _isValid = false;
            }
        }

        #endregion


        #region Operaciones CRUD
        public bool SaveMercaderia()
        {
            CMercaderia mercaderia = new CMercaderia();
            
            Validaciones();

            if (_isValid != true)
            {
                mercaderia.Descripcion = tboxDescripcion.Text;
                mercaderia.Existencia = Convert.ToInt32(tboxExistencias.Text);
                mercaderia.Status = cboxStatus.Text;
                mercaderia.NoEliminable = Convert.ToByte(cboxElimanable.Text);
                mercaderia.Comentario = tboxComentario.Text;

                //PUNTO DE DETERMINANTE PARA SABER SI SERA UNA INSERCION O ACTUALIZACION
                mercaderia.IdMercancia = (this._cMercaderia != null) ? this._cMercaderia.IdMercancia : 0;


                //GUARDADO DEL CONTACTO...
                if (null != _businessLogicLayer.SaveMercaderia(mercaderia))
                {
                    MessageBox.Show("El registro se ha guardado de manera satisfactoria.");
                    return true;
                }
                else
                {
                    MessageBox.Show("Hubo algún error, nuestros desarrolladores están trabajando en eso...");
                    return false;
                }

            }
            else
            {
                MessageBox.Show("Asegurese de que todos los campos esten correctos.");
                return false;
            }

        }

        #endregion

        #region Ventanas de estrategias de comunicacion
        //Este es mi metodo estrategico para cargar la data, la recibe y la carga.
        public void LoadMercaderiaForUpdated(CMercaderia mercaderia)
        {
            if(mercaderia != null)
            {
                //Asignacion del ID y datos, al objeto global que me servira de UPDATE.
                this._cMercaderia = mercaderia;

                tboxDescripcion.Text = mercaderia.Descripcion;
                tboxExistencias.Text = (mercaderia.Existencia).ToString();
                cboxStatus.Text = mercaderia.Status;
                cboxElimanable.Text = mercaderia.NoEliminable.ToString();
                tboxComentario.Text = mercaderia.Comentario;
            }
            else{
                ClearBoxes();
                MessageBox.Show("No se pudo carga porque el objeto mercaderia viene nulo.");
            }
        }

        #endregion


    }


}
