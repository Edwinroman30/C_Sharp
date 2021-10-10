namespace First_App_Hello
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
            this.btnsaludar = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.btndespedida = new System.Windows.Forms.Button();
            this.btnchance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnsaludar
            // 
            this.btnsaludar.Location = new System.Drawing.Point(34, 159);
            this.btnsaludar.Name = "btnsaludar";
            this.btnsaludar.Size = new System.Drawing.Size(89, 31);
            this.btnsaludar.TabIndex = 0;
            this.btnsaludar.Text = "Saludar !";
            this.btnsaludar.UseVisualStyleBackColor = true;
            this.btnsaludar.Click += new System.EventHandler(this.btnsaludar_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(58, 93);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(135, 13);
            this.lblmensaje.TabIndex = 1;
            this.lblmensaje.Text = "\"AQUI VERAS LA MAGIA\"";
            // 
            // btndespedida
            // 
            this.btndespedida.Location = new System.Drawing.Point(129, 159);
            this.btndespedida.Name = "btndespedida";
            this.btndespedida.Size = new System.Drawing.Size(89, 31);
            this.btndespedida.TabIndex = 2;
            this.btndespedida.Text = "Despedida";
            this.btndespedida.UseVisualStyleBackColor = true;
            this.btndespedida.Click += new System.EventHandler(this.btndespedida_Click);
            // 
            // btnchance
            // 
            this.btnchance.Location = new System.Drawing.Point(34, 199);
            this.btnchance.Name = "btnchance";
            this.btnchance.Size = new System.Drawing.Size(184, 21);
            this.btnchance.TabIndex = 3;
            this.btnchance.Text = "Cambiar Titulo";
            this.btnchance.UseVisualStyleBackColor = true;
            this.btnchance.Click += new System.EventHandler(this.btnchance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 243);
            this.Controls.Add(this.btnchance);
            this.Controls.Add(this.btndespedida);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btnsaludar);
            this.Name = "Form1";
            this.Text = "FIRST APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsaludar;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btndespedida;
        private System.Windows.Forms.Button btnchance;
    }
}

