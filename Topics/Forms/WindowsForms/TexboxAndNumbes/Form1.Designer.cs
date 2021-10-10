namespace Programa01_03
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.btnsumar = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btndividir = new System.Windows.Forms.Button();
            this.lblelige = new System.Windows.Forms.Label();
            this.lblcopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(25, 59);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(17, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A:";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(25, 93);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(17, 13);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.BackColor = System.Drawing.Color.Lime;
            this.lblresultado.Location = new System.Drawing.Point(136, 134);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(35, 13);
            this.lblresultado.TabIndex = 2;
            this.lblresultado.Text = "label3";
            // 
            // txbA
            // 
            this.txbA.Location = new System.Drawing.Point(68, 56);
            this.txbA.Name = "txbA";
            this.txbA.Size = new System.Drawing.Size(100, 20);
            this.txbA.TabIndex = 3;
            this.txbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbB
            // 
            this.txbB.Location = new System.Drawing.Point(68, 90);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(100, 20);
            this.txbB.TabIndex = 4;
            this.txbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnsumar
            // 
            this.btnsumar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnsumar.Location = new System.Drawing.Point(186, 54);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(45, 25);
            this.btnsumar.TabIndex = 5;
            this.btnsumar.Text = "+";
            this.btnsumar.UseVisualStyleBackColor = false;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // btnresta
            // 
            this.btnresta.BackColor = System.Drawing.Color.SkyBlue;
            this.btnresta.Location = new System.Drawing.Point(237, 54);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(45, 25);
            this.btnresta.TabIndex = 6;
            this.btnresta.Text = "-";
            this.btnresta.UseVisualStyleBackColor = false;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.BackColor = System.Drawing.Color.SkyBlue;
            this.btnmulti.Location = new System.Drawing.Point(186, 88);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(45, 23);
            this.btnmulti.TabIndex = 7;
            this.btnmulti.Text = "x";
            this.btnmulti.UseVisualStyleBackColor = false;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btndividir
            // 
            this.btndividir.BackColor = System.Drawing.Color.SkyBlue;
            this.btndividir.Location = new System.Drawing.Point(237, 88);
            this.btndividir.Name = "btndividir";
            this.btndividir.Size = new System.Drawing.Size(45, 23);
            this.btndividir.TabIndex = 8;
            this.btndividir.Text = "/";
            this.btndividir.UseVisualStyleBackColor = false;
            this.btndividir.Click += new System.EventHandler(this.btndividir_Click);
            // 
            // lblelige
            // 
            this.lblelige.AutoSize = true;
            this.lblelige.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblelige.Location = new System.Drawing.Point(98, 20);
            this.lblelige.Name = "lblelige";
            this.lblelige.Size = new System.Drawing.Size(110, 16);
            this.lblelige.TabIndex = 9;
            this.lblelige.Text = "Operaciones XD:";
            // 
            // lblcopyright
            // 
            this.lblcopyright.AutoSize = true;
            this.lblcopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcopyright.Location = new System.Drawing.Point(3, 156);
            this.lblcopyright.Name = "lblcopyright";
            this.lblcopyright.Size = new System.Drawing.Size(76, 7);
            this.lblcopyright.TabIndex = 10;
            this.lblcopyright.Text = "© Edwin Roman 2019.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(306, 172);
            this.Controls.Add(this.lblcopyright);
            this.Controls.Add(this.lblelige);
            this.Controls.Add(this.btndividir);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txbA);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Name = "Form1";
            this.Text = "Mini Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btndividir;
        private System.Windows.Forms.Label lblelige;
        private System.Windows.Forms.Label lblcopyright;
    }
}

