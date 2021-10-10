namespace Programa01_04
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
            this.chkmonitor = new System.Windows.Forms.CheckBox();
            this.chkmouses = new System.Windows.Forms.CheckBox();
            this.chkteclado = new System.Windows.Forms.CheckBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblinformacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkmonitor
            // 
            this.chkmonitor.AutoSize = true;
            this.chkmonitor.Location = new System.Drawing.Point(28, 50);
            this.chkmonitor.Name = "chkmonitor";
            this.chkmonitor.Size = new System.Drawing.Size(91, 17);
            this.chkmonitor.TabIndex = 0;
            this.chkmonitor.Text = "Monitor $150.";
            this.chkmonitor.UseVisualStyleBackColor = true;
            this.chkmonitor.CheckedChanged += new System.EventHandler(this.chkmonitor_CheckedChanged);
            // 
            // chkmouses
            // 
            this.chkmouses.AutoSize = true;
            this.chkmouses.Location = new System.Drawing.Point(28, 90);
            this.chkmouses.Name = "chkmouses";
            this.chkmouses.Size = new System.Drawing.Size(87, 17);
            this.chkmouses.TabIndex = 1;
            this.chkmouses.Text = "Mouses $10.";
            this.chkmouses.UseVisualStyleBackColor = true;
            this.chkmouses.CheckedChanged += new System.EventHandler(this.chkmouses_CheckedChanged);
            // 
            // chkteclado
            // 
            this.chkteclado.AutoSize = true;
            this.chkteclado.Location = new System.Drawing.Point(28, 130);
            this.chkteclado.Name = "chkteclado";
            this.chkteclado.Size = new System.Drawing.Size(89, 17);
            this.chkteclado.TabIndex = 2;
            this.chkteclado.Text = "Teclado $30.";
            this.chkteclado.UseVisualStyleBackColor = true;
            this.chkteclado.CheckedChanged += new System.EventHandler(this.chkteclado_CheckedChanged);
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(153, 90);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = " Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblinformacion
            // 
            this.lblinformacion.AutoSize = true;
            this.lblinformacion.Location = new System.Drawing.Point(110, 185);
            this.lblinformacion.Name = "lblinformacion";
            this.lblinformacion.Size = new System.Drawing.Size(35, 13);
            this.lblinformacion.TabIndex = 4;
            this.lblinformacion.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 236);
            this.Controls.Add(this.lblinformacion);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.chkteclado);
            this.Controls.Add(this.chkmouses);
            this.Controls.Add(this.chkmonitor);
            this.Name = "Form1";
            this.Text = "Uso de los Checks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkmonitor;
        private System.Windows.Forms.CheckBox chkmouses;
        private System.Windows.Forms.CheckBox chkteclado;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblinformacion;
    }
}

