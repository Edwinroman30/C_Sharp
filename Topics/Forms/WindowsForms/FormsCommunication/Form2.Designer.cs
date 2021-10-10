namespace Programa02_02
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
            this.lblrecibe1 = new System.Windows.Forms.Label();
            this.lblrecibe2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblrecibe1
            // 
            this.lblrecibe1.AutoSize = true;
            this.lblrecibe1.Location = new System.Drawing.Point(29, 42);
            this.lblrecibe1.Name = "lblrecibe1";
            this.lblrecibe1.Size = new System.Drawing.Size(35, 13);
            this.lblrecibe1.TabIndex = 0;
            this.lblrecibe1.Text = "label1";
            // 
            // lblrecibe2
            // 
            this.lblrecibe2.AutoSize = true;
            this.lblrecibe2.Location = new System.Drawing.Point(29, 82);
            this.lblrecibe2.Name = "lblrecibe2";
            this.lblrecibe2.Size = new System.Drawing.Size(35, 13);
            this.lblrecibe2.TabIndex = 0;
            this.lblrecibe2.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 270);
            this.Controls.Add(this.lblrecibe2);
            this.Controls.Add(this.lblrecibe1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrecibe1;
        private System.Windows.Forms.Label lblrecibe2;
    }
}