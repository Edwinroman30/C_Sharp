using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_DCU
{
    public partial class Form_Calculator : Form
    {
        public Form_Calculator()
        {
            InitializeComponent();
        }

        private double num1;
        private double num2;
        private int operation;
        private double result;

        private void tbox_contener_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbox_contener.Text += "6";
   
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbox_contener.Text += "9";

        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbox_contener.Text += "4";

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbox_contener.Text += "1";

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbox_contener.Text += "2";

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbox_contener.Text += "3";

        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbox_contener.Text += "5";

        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbox_contener.Text += "7";

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbox_contener.Text += "8";

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbox_contener.Text += "0";

        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            tbox_contener.Text += ".";

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            tbox_contener.Clear();
        }

        private void btn_sumar_Click(object sender, EventArgs e)
        {
            if(tbox_contener.Text.Length <= 0)
            {
                MessageBox.Show("Debe ingresar un número, no se debería dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                tbox_contener.Text = "0";
            }

            num1 = Convert.ToDouble(tbox_contener.Text);
            operation = 1;
            tbox_contener.Clear();
        }

        private void btn_igual_Click(object sender, EventArgs e)
        {

            if (tbox_contener.Text.Length <= 0)
            {
                MessageBox.Show("Debe ingresar un número, no se debería dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbox_contener.Text = "0";
            }


            num2 = Convert.ToDouble(tbox_contener.Text);


            switch (operation)
            {
                case 1:
                    result = num1 + num2;
                    tbox_contener.Text = result.ToString();
                    break;
                case 2:
                    result = num1 - num2;
                    tbox_contener.Text = result.ToString();
                    break;
                case 3:
                    
                    if (tbox_contener.Text == "0")
                    {
                        MessageBox.Show("No se debe dividir entre 'CERO', es una indeterminación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        tbox_contener.Text = "0";
                    }
                    else
                    {
                        result = num1 / num2;
                        tbox_contener.Text = result.ToString();
                    }

                     break;
                case 4:
                    result = num1 * num2;
                    tbox_contener.Text = result.ToString();
                    break;
            }


        }

        private void btn_restar_Click(object sender, EventArgs e)
        {

            if (tbox_contener.Text.Length <= 0)
            {
                MessageBox.Show("Debe ingresar un número, no se debería dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbox_contener.Text = "0";
            }

            num1 = Convert.ToDouble(tbox_contener.Text);
            operation = 2;
            tbox_contener.Clear();

        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {

            if (tbox_contener.Text.Length <= 0)
            {
                MessageBox.Show("Debe ingresar un número, no se debería dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbox_contener.Text = "0";
            }

            num1 = Convert.ToDouble(tbox_contener.Text);
            operation = 3;
            tbox_contener.Clear();
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            if (tbox_contener.Text.Length <= 0)
            {
                MessageBox.Show("Debe ingresar un número, no se debería dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                tbox_contener.Text = "0";
            }

            num1 = Convert.ToDouble(tbox_contener.Text);
            operation = 4;
            tbox_contener.Clear();
        }
    }
}