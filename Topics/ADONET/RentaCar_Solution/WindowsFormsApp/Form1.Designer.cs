
namespace WindowsFormsApp
{
    partial class Form1
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
            this.lblrentaCars = new System.Windows.Forms.Label();
            this.tboxCustomer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxTypeCar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtRented = new System.Windows.Forms.DateTimePicker();
            this.dtReturned = new System.Windows.Forms.DateTimePicker();
            this.tboxCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblrentaCars
            // 
            this.lblrentaCars.AutoSize = true;
            this.lblrentaCars.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrentaCars.Location = new System.Drawing.Point(226, 45);
            this.lblrentaCars.Name = "lblrentaCars";
            this.lblrentaCars.Size = new System.Drawing.Size(172, 25);
            this.lblrentaCars.TabIndex = 0;
            this.lblrentaCars.Text = "Renta Cars Systems";
            // 
            // tboxCustomer
            // 
            this.tboxCustomer.Location = new System.Drawing.Point(44, 130);
            this.tboxCustomer.Multiline = true;
            this.tboxCustomer.Name = "tboxCustomer";
            this.tboxCustomer.Size = new System.Drawing.Size(224, 23);
            this.tboxCustomer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name:";
            // 
            // cboxTypeCar
            // 
            this.cboxTypeCar.FormattingEnabled = true;
            this.cboxTypeCar.Location = new System.Drawing.Point(44, 275);
            this.cboxTypeCar.Name = "cboxTypeCar";
            this.cboxTypeCar.Size = new System.Drawing.Size(224, 21);
            this.cboxTypeCar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date Rented:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cost:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Date Returned:";
            // 
            // dtRented
            // 
            this.dtRented.Location = new System.Drawing.Point(44, 200);
            this.dtRented.Name = "dtRented";
            this.dtRented.Size = new System.Drawing.Size(224, 20);
            this.dtRented.TabIndex = 4;
            // 
            // dtReturned
            // 
            this.dtReturned.Location = new System.Drawing.Point(336, 200);
            this.dtReturned.Name = "dtReturned";
            this.dtReturned.Size = new System.Drawing.Size(224, 20);
            this.dtReturned.TabIndex = 4;
            // 
            // tboxCost
            // 
            this.tboxCost.Location = new System.Drawing.Point(336, 130);
            this.tboxCost.Multiline = true;
            this.tboxCost.Name = "tboxCost";
            this.tboxCost.Size = new System.Drawing.Size(224, 23);
            this.tboxCost.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Type of Car:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(336, 249);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(224, 47);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 359);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dtReturned);
            this.Controls.Add(this.dtRented);
            this.Controls.Add(this.cboxTypeCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tboxCost);
            this.Controls.Add(this.tboxCustomer);
            this.Controls.Add(this.lblrentaCars);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrentaCars;
        private System.Windows.Forms.TextBox tboxCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxTypeCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtRented;
        private System.Windows.Forms.DateTimePicker dtReturned;
        private System.Windows.Forms.TextBox tboxCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSubmit;
    }
}

