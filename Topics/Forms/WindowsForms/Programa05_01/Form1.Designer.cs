namespace Programa05_01
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
            this.cklbarticulos = new System.Windows.Forms.CheckedListBox();
            this.tboxinsert = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            this.btnenviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cklbarticulos
            // 
            this.cklbarticulos.FormattingEnabled = true;
            this.cklbarticulos.Items.AddRange(new object[] {
            "Mouses",
            "Teclado",
            "Camara"});
            this.cklbarticulos.Location = new System.Drawing.Point(30, 25);
            this.cklbarticulos.Name = "cklbarticulos";
            this.cklbarticulos.Size = new System.Drawing.Size(300, 124);
            this.cklbarticulos.TabIndex = 0;
            this.cklbarticulos.SelectedIndexChanged += new System.EventHandler(this.cklbarticulos_SelectedIndexChanged);
            // 
            // tboxinsert
            // 
            this.tboxinsert.Location = new System.Drawing.Point(39, 194);
            this.tboxinsert.Name = "tboxinsert";
            this.tboxinsert.Size = new System.Drawing.Size(168, 20);
            this.tboxinsert.TabIndex = 1;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(36, 168);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(35, 13);
            this.lblresult.TabIndex = 2;
            this.lblresult.Text = "label1";
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(255, 191);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 3;
            this.btnenviar.Text = "Enviar";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 301);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.tboxinsert);
            this.Controls.Add(this.cklbarticulos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox cklbarticulos;
        private System.Windows.Forms.TextBox tboxinsert;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.Button btnenviar;
    }
}

