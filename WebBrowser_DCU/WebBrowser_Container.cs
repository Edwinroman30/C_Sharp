using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser_DCU
{
    public partial class WebBrowser_Container : Form
    {
        public WebBrowser_Container()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(tboxSearch.TextLength <= 0)
            {
                MessageBox.Show(this, "Debe introducir una URL en la barra de busqueda...", "Error al buscar...", MessageBoxButtons.OK ,MessageBoxIcon.Error);

            }
            else
            {
                webBrowser1.Navigate(tboxSearch.Text);
                MessageBox.Show(this, "Cargando su busqueda...", "Espera...", MessageBoxButtons.OK);
                tboxSearch.Text = "";
            }
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Something to show");
            

            //DARK MODE
            if((btnDarkMode.BackColor == Color.Black))
            {
                btnDarkMode.Text = "🌕";
                btnDarkMode.BackColor = Color.White;
                btnDarkMode.ForeColor = Color.DeepSkyBlue;
                panelMenu.BackColor = Color.Black;
            }
            else
            {
                btnDarkMode.Text = "🌙";
                btnDarkMode.BackColor = Color.Black;
                btnDarkMode.ForeColor = Color.Yellow;
                panelMenu.BackColor = Color.DeepSkyBlue;
            }

           
        }

        private void WebBrowser_Container_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void WebBrowser_Container_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control && e.KeyCode == Keys.B)
            {
                MessageBox.Show("Quieres buscar perr0!");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            helpForm = new HelpForm();
            helpForm.Show();
        }

        private HelpForm helpForm;
    }
}
