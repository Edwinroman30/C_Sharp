namespace Programa02_04
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
            this.btnenviar = new System.Windows.Forms.Button();
            this.tboxcontenido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxmensaje
            // 
            this.tboxmensaje.Location = new System.Drawing.Point(22, 58);
            this.tboxmensaje.Name = "tboxmensaje";
            this.tboxmensaje.Size = new System.Drawing.Size(213, 20);
            this.tboxmensaje.TabIndex = 0;
            // 
            // btnenviar
            // 
            this.btnenviar.Location = new System.Drawing.Point(91, 153);
            this.btnenviar.Name = "btnenviar";
            this.btnenviar.Size = new System.Drawing.Size(75, 23);
            this.btnenviar.TabIndex = 1;
            this.btnenviar.Text = "Salir";
            this.btnenviar.UseVisualStyleBackColor = true;
            this.btnenviar.Click += new System.EventHandler(this.btnenviar_Click);
            // 
            // tboxcontenido
            // 
            this.tboxcontenido.Location = new System.Drawing.Point(22, 103);
            this.tboxcontenido.Name = "tboxcontenido";
            this.tboxcontenido.Size = new System.Drawing.Size(213, 20);
            this.tboxcontenido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mensaje I";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mensaje II";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 227);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxcontenido);
            this.Controls.Add(this.btnenviar);
            this.Controls.Add(this.tboxmensaje);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxmensaje;
        private System.Windows.Forms.Button btnenviar;
        private System.Windows.Forms.TextBox tboxcontenido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}