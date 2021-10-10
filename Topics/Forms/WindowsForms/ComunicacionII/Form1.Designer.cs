namespace ComunicacionII
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
            this.lblmensaje = new System.Windows.Forms.Label();
            this.lblrecibe = new System.Windows.Forms.Label();
            this.bntabrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(35, 61);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(112, 13);
            this.lblmensaje.TabIndex = 0;
            this.lblmensaje.Text = "###############";
            // 
            // lblrecibe
            // 
            this.lblrecibe.AutoSize = true;
            this.lblrecibe.Location = new System.Drawing.Point(35, 126);
            this.lblrecibe.Name = "lblrecibe";
            this.lblrecibe.Size = new System.Drawing.Size(97, 13);
            this.lblrecibe.TabIndex = 1;
            this.lblrecibe.Text = "$$$$$$$$$$$$$$$";
            // 
            // bntabrir
            // 
            this.bntabrir.Location = new System.Drawing.Point(251, 197);
            this.bntabrir.Name = "bntabrir";
            this.bntabrir.Size = new System.Drawing.Size(127, 35);
            this.bntabrir.TabIndex = 2;
            this.bntabrir.Text = "Abril Ventana";
            this.bntabrir.UseVisualStyleBackColor = true;
            this.bntabrir.Click += new System.EventHandler(this.bntabrir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 244);
            this.Controls.Add(this.bntabrir);
            this.Controls.Add(this.lblrecibe);
            this.Controls.Add(this.lblmensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Label lblrecibe;
        private System.Windows.Forms.Button bntabrir;
    }
}

