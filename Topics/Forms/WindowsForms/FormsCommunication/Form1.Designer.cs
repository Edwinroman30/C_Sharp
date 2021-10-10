namespace Programa02_02
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
            this.tboxenvia1 = new System.Windows.Forms.TextBox();
            this.btnenvia2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxenvia1
            // 
            this.tboxenvia1.Location = new System.Drawing.Point(28, 55);
            this.tboxenvia1.Name = "tboxenvia1";
            this.tboxenvia1.Size = new System.Drawing.Size(100, 20);
            this.tboxenvia1.TabIndex = 0;
            // 
            // btnenvia2
            // 
            this.btnenvia2.Location = new System.Drawing.Point(182, 55);
            this.btnenvia2.Name = "btnenvia2";
            this.btnenvia2.Size = new System.Drawing.Size(75, 20);
            this.btnenvia2.TabIndex = 2;
            this.btnenvia2.Text = "Envia 2";
            this.btnenvia2.UseVisualStyleBackColor = true;
            this.btnenvia2.Click += new System.EventHandler(this.btnenvia2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 152);
            this.Controls.Add(this.btnenvia2);
            this.Controls.Add(this.tboxenvia1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxenvia1;
        private System.Windows.Forms.Button btnenvia2;
    }
}

