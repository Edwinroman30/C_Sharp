namespace Programa02_04
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
            this.btnforma2 = new System.Windows.Forms.Button();
            this.lblcontenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(12, 39);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(139, 13);
            this.lblmensaje.TabIndex = 1;
            this.lblmensaje.Text = "======================";
            // 
            // btnforma2
            // 
            this.btnforma2.Location = new System.Drawing.Point(96, 147);
            this.btnforma2.Name = "btnforma2";
            this.btnforma2.Size = new System.Drawing.Size(75, 23);
            this.btnforma2.TabIndex = 2;
            this.btnforma2.Text = "Forma 2";
            this.btnforma2.UseVisualStyleBackColor = true;
            this.btnforma2.Click += new System.EventHandler(this.btnforma2_Click);
            // 
            // lblcontenido
            // 
            this.lblcontenido.AutoSize = true;
            this.lblcontenido.Location = new System.Drawing.Point(12, 87);
            this.lblcontenido.Name = "lblcontenido";
            this.lblcontenido.Size = new System.Drawing.Size(139, 13);
            this.lblcontenido.TabIndex = 1;
            this.lblcontenido.Text = "======================";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 206);
            this.Controls.Add(this.btnforma2);
            this.Controls.Add(this.lblcontenido);
            this.Controls.Add(this.lblmensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Button btnforma2;
        private System.Windows.Forms.Label lblcontenido;
    }
}

