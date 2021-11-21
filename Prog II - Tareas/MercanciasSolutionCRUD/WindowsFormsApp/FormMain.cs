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
using ClassLibrary.Entities;
using ClassLibrary.Bussines;

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

        #region Metodos Handlers
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormRegistroMercancias formRegistro = new FormRegistroMercancias();
            formRegistro.ShowDialog(this);
        }

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {
            PopulateMercancias(tboxSearch.Text);
        }


        private void dataGridMercaderia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Salvaguardandome de que haya un valor row pretederminado, cuando solo el usuario elija un column value.
            int rowIndexSolutionError = e.RowIndex < 0 ? 0 : e.RowIndex;

            var cell = dataGridMercaderia.Rows[rowIndexSolutionError].Cells[e.ColumnIndex];

            if (cell.Value.ToString() == "Editar")
            {
                FormRegistroMercancias formRegistro = new FormRegistroMercancias();

                CMercaderia cMercaderia = new CMercaderia()
                {
                    //CAPTURA DEL ID
                    IdMercancia = Convert.ToInt32(dataGridMercaderia.Rows[rowIndexSolutionError].Cells[0].Value),

                    Descripcion = dataGridMercaderia.Rows[rowIndexSolutionError].Cells[1].Value.ToString(),
                    Existencia = Convert.ToInt32(dataGridMercaderia.Rows[rowIndexSolutionError].Cells[2].Value),
                    Comentario = dataGridMercaderia.Rows[rowIndexSolutionError].Cells[3].Value.ToString(),
                    Status = dataGridMercaderia.Rows[rowIndexSolutionError].Cells[4].Value.ToString(),
                    NoEliminable = Convert.ToByte(dataGridMercaderia.Rows[rowIndexSolutionError].Cells[5].Value)
                };

                //Paso los datos:
                formRegistro.LoadMercaderiaForUpdated(cMercaderia);
                formRegistro.ShowDialog(this);

            }
            else if (cell.Value.ToString() == "Eliminar")
            {
                DialogResult result = MessageBox.Show
                    (
                        this,
                        "¿Esta seguro de querer eliminar este registro?",
                        "Confirmar eliminación:",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );


                if (result == DialogResult.Yes)
                {
                    bool confirmacionEliminacion = businessLogicLayer.DeleteMercancia(Convert.ToInt32(dataGridMercaderia.Rows[rowIndexSolutionError].Cells[0].Value));

                    if (confirmacionEliminacion == true)
                    {
                        MessageBox.Show("Se elimino con exito!");
                    }

                    PopulateMercancias();
                }


            }

        }



        #endregion

        #region Funciones Intermediarias
        
        //Agregamos un parametro opcional.
        public void PopulateMercancias(string toSearch = null)
        {
            //Esto retornaria una lista.
            List<CMercaderia> listMercancia = businessLogicLayer.GetMercaderia(toSearch);

            //Pasamos esos datos como fuentes de datos.
            dataGridMercaderia.DataSource = listMercancia;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PopulateMercancias();
        }


        #endregion

    }
    
}


