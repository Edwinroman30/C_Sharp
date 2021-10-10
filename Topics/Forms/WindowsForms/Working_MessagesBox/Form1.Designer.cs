namespace Programa01_06
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
            this.lblinformacion = new System.Windows.Forms.Label();
            this.btnmensaje = new System.Windows.Forms.Button();
            this.gboxgender = new System.Windows.Forms.GroupBox();
            this.rbmasculino = new System.Windows.Forms.RadioButton();
            this.rbfemenino = new System.Windows.Forms.RadioButton();
            this.btngenero = new System.Windows.Forms.Button();
            this.lblgenero = new System.Windows.Forms.Label();
            this.lblcopyright = new System.Windows.Forms.Label();
            this.gboxgender.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblinformacion
            // 
            this.lblinformacion.AutoSize = true;
            this.lblinformacion.Location = new System.Drawing.Point(68, 38);
            this.lblinformacion.Name = "lblinformacion";
            this.lblinformacion.Size = new System.Drawing.Size(35, 13);
            this.lblinformacion.TabIndex = 0;
            this.lblinformacion.Text = "label1";
            // 
            // btnmensaje
            // 
            this.btnmensaje.Location = new System.Drawing.Point(224, 28);
            this.btnmensaje.Name = "btnmensaje";
            this.btnmensaje.Size = new System.Drawing.Size(75, 23);
            this.btnmensaje.TabIndex = 1;
            this.btnmensaje.Text = "Mensaje !";
            this.btnmensaje.UseVisualStyleBackColor = true;
            this.btnmensaje.Click += new System.EventHandler(this.btnmensaje_Click);
            // 
            // gboxgender
            // 
            this.gboxgender.Controls.Add(this.rbfemenino);
            this.gboxgender.Controls.Add(this.rbmasculino);
            this.gboxgender.Location = new System.Drawing.Point(71, 87);
            this.gboxgender.Name = "gboxgender";
            this.gboxgender.Size = new System.Drawing.Size(228, 51);
            this.gboxgender.TabIndex = 2;
            this.gboxgender.TabStop = false;
            this.gboxgender.Text = "Genero:";
            // 
            // rbmasculino
            // 
            this.rbmasculino.AutoSize = true;
            this.rbmasculino.Location = new System.Drawing.Point(21, 19);
            this.rbmasculino.Name = "rbmasculino";
            this.rbmasculino.Size = new System.Drawing.Size(73, 17);
            this.rbmasculino.TabIndex = 0;
            this.rbmasculino.TabStop = true;
            this.rbmasculino.Text = "Masculino";
            this.rbmasculino.UseVisualStyleBackColor = true;
            // 
            // rbfemenino
            // 
            this.rbfemenino.AutoSize = true;
            this.rbfemenino.Location = new System.Drawing.Point(136, 19);
            this.rbfemenino.Name = "rbfemenino";
            this.rbfemenino.Size = new System.Drawing.Size(71, 17);
            this.rbfemenino.TabIndex = 1;
            this.rbfemenino.TabStop = true;
            this.rbfemenino.Text = "Femenino";
            this.rbfemenino.UseVisualStyleBackColor = true;
            // 
            // btngenero
            // 
            this.btngenero.Location = new System.Drawing.Point(224, 58);
            this.btngenero.Name = "btngenero";
            this.btngenero.Size = new System.Drawing.Size(75, 23);
            this.btngenero.TabIndex = 3;
            this.btngenero.Text = "Confirmar";
            this.btngenero.UseVisualStyleBackColor = true;
            this.btngenero.Click += new System.EventHandler(this.btngenero_Click);
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.Location = new System.Drawing.Point(68, 58);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(35, 13);
            this.lblgenero.TabIndex = 4;
            this.lblgenero.Text = "label1";
            // 
            // lblcopyright
            // 
            this.lblcopyright.AutoSize = true;
            this.lblcopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcopyright.Location = new System.Drawing.Point(12, 9);
            this.lblcopyright.Name = "lblcopyright";
            this.lblcopyright.Size = new System.Drawing.Size(76, 7);
            this.lblcopyright.TabIndex = 12;
            this.lblcopyright.Text = "© Edwin Roman 2019.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 150);
            this.Controls.Add(this.lblcopyright);
            this.Controls.Add(this.lblgenero);
            this.Controls.Add(this.btngenero);
            this.Controls.Add(this.gboxgender);
            this.Controls.Add(this.btnmensaje);
            this.Controls.Add(this.lblinformacion);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxgender.ResumeLayout(false);
            this.gboxgender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinformacion;
        private System.Windows.Forms.Button btnmensaje;
        private System.Windows.Forms.GroupBox gboxgender;
        private System.Windows.Forms.RadioButton rbfemenino;
        private System.Windows.Forms.RadioButton rbmasculino;
        private System.Windows.Forms.Button btngenero;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.Label lblcopyright;
    }
}

