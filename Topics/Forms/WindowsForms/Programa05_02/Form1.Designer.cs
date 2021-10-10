namespace Programa05_02
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
            this.cbmAlimentos = new System.Windows.Forms.ComboBox();
            this.lblindex = new System.Windows.Forms.Label();
            this.tboxinserted = new System.Windows.Forms.TextBox();
            this.btnenviar = new System.Windows.Forms.Button();
            this.lbltexto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbmAlimentos
            // 
            this.cbmAlimentos.FormattingEnabled = true;
            this.cbmAlimentos.Items.AddRange(new object[] {
            "Carne",
            "Leche",
            "Tomates"});
            this.cbmAlimentos.Location = new System.Drawing.Point(71, 67);
            this.cbmAlimentos.Name = "cbmAlimentos";
            this.cbmAlimentos.Size = new System.Drawing.Size(188, 21);
            this.cbmAlimentos.TabIndex = 0;
            this.cbmAlimentos.Text = "Alimentos";
            this.cbmAlimentos.SelectedIndexChanged += new System.EventHandler(this.cbmAlimentos_SelectedIndexChanged);
            // 
            // lblindex
            // 
            this.lblindex.AutoSize = true;
            this.lblindex.Location = new System.Drawing.Point(71, 119);
            this.lblindex.Name = "lblindex";
            this.lblindex.Size = new System.Drawing.Size(48, 13);
            this.lblindex.TabIndex = 1;
            this.lblindex.Text = "Indice > ";
            // 
            // tboxinserted
            // 
            this.tboxinserted.Location = new System.Drawing.Point(71, 174);
            this.tboxinserted.Name = "tboxinserted";
            this.tboxinserted.Size = new System.Drawing.Size(100, 20);
            this.tboxinserted.TabIndex = 2;
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(184, 171);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 3;
            this.btnenviar.Text = "Send";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // lbltexto
            // 
            this.lbltexto.AutoSize = true;
            this.lbltexto.Location = new System.Drawing.Point(68, 140);
            this.lbltexto.Name = "lbltexto";
            this.lbltexto.Size = new System.Drawing.Size(63, 13);
            this.lbltexto.TabIndex = 1;
            this.lbltexto.Text = "Elemento > ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 281);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.tboxinserted);
            this.Controls.Add(this.lbltexto);
            this.Controls.Add(this.lblindex);
            this.Controls.Add(this.cbmAlimentos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbmAlimentos;
        private System.Windows.Forms.Label lblindex;
        private System.Windows.Forms.TextBox tboxinserted;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.Label lbltexto;
    }
}

