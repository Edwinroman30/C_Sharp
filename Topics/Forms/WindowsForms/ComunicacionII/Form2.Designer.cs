namespace ComunicacionII
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tboxmensaje = new System.Windows.Forms.TextBox();
            this.tboxrecibe = new System.Windows.Forms.TextBox();
            this.btnok = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxmensaje
            // 
            this.tboxmensaje.Location = new System.Drawing.Point(28, 41);
            this.tboxmensaje.Name = "tboxmensaje";
            this.tboxmensaje.Size = new System.Drawing.Size(219, 20);
            this.tboxmensaje.TabIndex = 0;
            // 
            // tboxrecibe
            // 
            this.tboxrecibe.Location = new System.Drawing.Point(28, 88);
            this.tboxrecibe.Name = "tboxrecibe";
            this.tboxrecibe.Size = new System.Drawing.Size(219, 20);
            this.tboxrecibe.TabIndex = 1;
            // 
            // btnok
            // 
            this.btnok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnok.Location = new System.Drawing.Point(172, 147);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(75, 23);
            this.btnok.TabIndex = 2;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancelar.Location = new System.Drawing.Point(38, 147);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 24);
            this.btncancelar.TabIndex = 3;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 205);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.tboxrecibe);
            this.Controls.Add(this.tboxmensaje);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxmensaje;
        private System.Windows.Forms.TextBox tboxrecibe;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancelar;
    }
}