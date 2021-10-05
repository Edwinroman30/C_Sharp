
namespace Calculator_DCU
{
    partial class Form_Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbox_contener = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn_punto = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_restar = new System.Windows.Forms.Button();
            this.btn_sumar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbox_contener);
            this.panel1.Location = new System.Drawing.Point(33, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 53);
            this.panel1.TabIndex = 0;
            // 
            // tbox_contener
            // 
            this.tbox_contener.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_contener.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tbox_contener.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbox_contener.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbox_contener.ForeColor = System.Drawing.Color.White;
            this.tbox_contener.Location = new System.Drawing.Point(0, 0);
            this.tbox_contener.Multiline = true;
            this.tbox_contener.Name = "tbox_contener";
            this.tbox_contener.ReadOnly = true;
            this.tbox_contener.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbox_contener.Size = new System.Drawing.Size(281, 53);
            this.tbox_contener.TabIndex = 0;
            this.tbox_contener.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbox_contener.TextChanged += new System.EventHandler(this.tbox_contener_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn_punto);
            this.panel2.Controls.Add(this.btn_limpiar);
            this.panel2.Controls.Add(this.btn0);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Location = new System.Drawing.Point(23, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 300);
            this.panel2.TabIndex = 1;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(165, 12);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(56, 50);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(88, 12);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(56, 50);
            this.btn8.TabIndex = 0;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(11, 145);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(56, 50);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn_punto
            // 
            this.btn_punto.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_punto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_punto.ForeColor = System.Drawing.Color.White;
            this.btn_punto.Location = new System.Drawing.Point(165, 205);
            this.btn_punto.Name = "btn_punto";
            this.btn_punto.Size = new System.Drawing.Size(56, 82);
            this.btn_punto.TabIndex = 0;
            this.btn_punto.Text = ".";
            this.btn_punto.UseVisualStyleBackColor = false;
            this.btn_punto.Click += new System.EventHandler(this.btn_punto_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(11, 205);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(56, 82);
            this.btn_limpiar.TabIndex = 0;
            this.btn_limpiar.Text = "C";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(88, 205);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(56, 82);
            this.btn0.TabIndex = 0;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(88, 144);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(56, 50);
            this.btn2.TabIndex = 0;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(165, 144);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(56, 50);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(165, 80);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(56, 50);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(88, 80);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(56, 50);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(11, 80);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(56, 50);
            this.btn6.TabIndex = 0;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(11, 12);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(56, 50);
            this.btn9.TabIndex = 0;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_multiplicar);
            this.panel3.Controls.Add(this.btn_igual);
            this.panel3.Controls.Add(this.btn_dividir);
            this.panel3.Controls.Add(this.btn_restar);
            this.panel3.Controls.Add(this.btn_sumar);
            this.panel3.Location = new System.Drawing.Point(252, 74);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(65, 300);
            this.panel3.TabIndex = 2;
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_multiplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_multiplicar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_multiplicar.ForeColor = System.Drawing.Color.White;
            this.btn_multiplicar.Location = new System.Drawing.Point(6, 181);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(56, 50);
            this.btn_multiplicar.TabIndex = 0;
            this.btn_multiplicar.Text = "X";
            this.btn_multiplicar.UseVisualStyleBackColor = false;
            this.btn_multiplicar.Click += new System.EventHandler(this.btn_multiplicar_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_igual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_igual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_igual.ForeColor = System.Drawing.Color.White;
            this.btn_igual.Location = new System.Drawing.Point(6, 237);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(56, 50);
            this.btn_igual.TabIndex = 0;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = false;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_dividir
            // 
            this.btn_dividir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_dividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dividir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_dividir.ForeColor = System.Drawing.Color.White;
            this.btn_dividir.Location = new System.Drawing.Point(6, 125);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(56, 50);
            this.btn_dividir.TabIndex = 0;
            this.btn_dividir.Text = "/";
            this.btn_dividir.UseVisualStyleBackColor = false;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // btn_restar
            // 
            this.btn_restar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_restar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_restar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_restar.ForeColor = System.Drawing.Color.White;
            this.btn_restar.Location = new System.Drawing.Point(6, 69);
            this.btn_restar.Name = "btn_restar";
            this.btn_restar.Size = new System.Drawing.Size(56, 50);
            this.btn_restar.TabIndex = 0;
            this.btn_restar.Text = "-";
            this.btn_restar.UseVisualStyleBackColor = false;
            this.btn_restar.Click += new System.EventHandler(this.btn_restar_Click);
            // 
            // btn_sumar
            // 
            this.btn_sumar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btn_sumar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sumar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_sumar.ForeColor = System.Drawing.Color.White;
            this.btn_sumar.Location = new System.Drawing.Point(6, 13);
            this.btn_sumar.Name = "btn_sumar";
            this.btn_sumar.Size = new System.Drawing.Size(56, 50);
            this.btn_sumar.TabIndex = 0;
            this.btn_sumar.Text = "+";
            this.btn_sumar.UseVisualStyleBackColor = false;
            this.btn_sumar.Click += new System.EventHandler(this.btn_sumar_Click);
            // 
            // Form_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 403);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DCU Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbox_contener;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn_punto;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        //private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btn_restar;
        private System.Windows.Forms.Button btn_sumar;
    }
}

