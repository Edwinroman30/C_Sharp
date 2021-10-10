namespace Programa02_01
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
            this.lblsaludo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblsaludo
            // 
            this.lblsaludo.AutoSize = true;
            this.lblsaludo.Location = new System.Drawing.Point(88, 106);
            this.lblsaludo.Name = "lblsaludo";
            this.lblsaludo.Size = new System.Drawing.Size(125, 13);
            this.lblsaludo.TabIndex = 0;
            this.lblsaludo.Text = "HOLA HIJO DE TU PTM";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 224);
            this.Controls.Add(this.lblsaludo);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsaludo;
    }
}