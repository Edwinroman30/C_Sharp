using ClassLibrary;
using ClassLibrary.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp
{
    public partial class FormContactDetails : Form
    {

        private BusinessLogicLayer _businessLogicLayer;
        private CContact _contacto;

        public FormContactDetails()
        {
            InitializeComponent();
            _businessLogicLayer = new BusinessLogicLayer();
        }


        #region Handlers 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveData();
            this.Close();

            ((FormMain)this.Owner).PopulateContact();
        }

        #endregion


        #region Private Methods
        private void SaveData()
        {
            //Aqui habria que validar estos campos....

            CContact contacto = new CContact();
            contacto.FirstName = tboxFirstName.Text;
            contacto.LastName = tboxLastName.Text;
            contacto.Phone = tboxPhone.Text;
            contacto.Address = tboxAddress.Text;

            contacto.idContact = (this._contacto != null) ? this._contacto.idContact : 0; 

            //GUARDADO DEL CONTACTO...
            if (null != _businessLogicLayer.SaveContact(contacto))
            {
                MessageBox.Show("The contact was save sucefully!");
            }
            else
            {
                MessageBox.Show(":( it may be an error, our devs will be working on it.");
            }
        }


        public void LoadContact(CContact contact)
        {
            ClearBoxes();

            //Cargar datos en un objeto usuarios

            if (contact != null)
            {
                //Esta primera propiedad es para manejar el ID.

                this._contacto = contact;
                tboxFirstName.Text = contact.FirstName;
                tboxLastName.Text = contact.LastName;
                tboxPhone.Text = contact.Phone;
                tboxAddress.Text = contact.Address;
            }
            else
            {
                MessageBox.Show("El contacto es NULO, no se lleva acabo comuniniquese con en el DEV.");
            }

            
        }


        private void ClearBoxes()
        {
            tboxFirstName.Clear();
            tboxLastName.Clear();
            tboxPhone.Clear();
            tboxAddress.Clear();
        }
        #endregion



    }

}
