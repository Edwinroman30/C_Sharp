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
    public partial class FormMain : Form
    {
        private BusinessLogicLayer businessLogicLayer;
        public FormMain()
        {
            InitializeComponent();
            businessLogicLayer = new BusinessLogicLayer();
        }

        #region Handdlers

        private void Main_Load(object sender, EventArgs e)
        {
            PopulateContact();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenContactDetailsDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //PopulateContact(tboxSearch.Text);
            //tboxSearch.Clear();
        }


        //En el evento CellCOntentClick, tomar aceso a esa fila seleccionada.
        private void dataGridContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Salvaguardandome de que haya un valor row pretederminado, cuando solo el usuario elija un column value.
            int rowIndexSolutionError = e.RowIndex < 0 ? 0 : e.RowIndex;

            DataGridViewCell cell = dataGridContact.Rows[rowIndexSolutionError].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Edit")
            {
                FormContactDetails formContact = new FormContactDetails();

                formContact.LoadContact(new CContact()
                {
                    idContact = Convert.ToInt32((dataGridContact.Rows[rowIndexSolutionError].Cells[0]).Value),
                    FirstName = (dataGridContact.Rows[rowIndexSolutionError].Cells[1].Value).ToString(),
                    LastName = (dataGridContact.Rows[rowIndexSolutionError].Cells[2].Value).ToString(),
                    Address = (dataGridContact.Rows[rowIndexSolutionError].Cells[3].Value).ToString(),
                    Phone = (dataGridContact.Rows[rowIndexSolutionError].Cells[4].Value).ToString()
                });

                formContact.ShowDialog(this);

            }
            else if (cell.Value.ToString() == "Delete")
            {

                var result = MessageBox.Show(
                            this,
                            @"Are you sure you wanna delete this contact?",
                            @"Delete Contact",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteContact(Convert.ToInt32((dataGridContact.Rows[rowIndexSolutionError].Cells[0]).Value));
                    PopulateContact();
                }
            }
        }


        #endregion

        #region PrivateMethods
        private void OpenContactDetailsDialog()
        {
            FormContactDetails contactDetails = new FormContactDetails();
            
            //De la misma forma que se habre la ventana, enseguida se le notifica quien es su padre.
            contactDetails.ShowDialog(this);
        }

      
        //Agregamos un parametro opcional.
        public void PopulateContact(string toSearch = null)
        {
            //Esto retornaria una lista.
            List<CContact> listContacts = businessLogicLayer.GetContacts(toSearch);

            //Pasamos esos datos como fuentes de datos.
            dataGridContact.DataSource = listContacts;
        }

     

        private void DeleteContact(int idContact)
        {
            this.businessLogicLayer.DeleteContact(idContact);
        }

      

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateContact(tboxSearch.Text);
        }

        #endregion

    }
}
