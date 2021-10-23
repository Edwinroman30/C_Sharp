using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaCheckAndBox
{
    public partial class Form1 : Form
    {
        private bool __isValid = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorCheck();
            MessageBox.Show(this,"Esta seguro de quiere continuar con el proceso:","Are u sure?",MessageBoxButtons.OKCancel);
        }

        private void ColorCheck()
        {
            if (radioButton8.Checked)
            {
                Form1.ActiveForm.BackColor = Color.AliceBlue;
            }
            if (radioButton6.Checked)
            {
                Form1.ActiveForm.BackColor = Color.DarkGray;
            }
            if (radioButton10.Checked)
            {
                Form1.ActiveForm.BackColor = Color.Yellow;
            }
            if (radioButton7.Checked)
            {
                Form1.ActiveForm.BackColor = Color.Green;
            }
            if (radioButton9.Checked)
            {
                Form1.ActiveForm.BackColor = Color.Orange;
            }
            if (radioButton11.Checked)
            {
                Form1.ActiveForm.BackColor = Color.Red;
            }
        }
    }
}
