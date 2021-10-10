namespace Prueba0i0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblcopyright = new System.Windows.Forms.Label();
            this.tboxcustumer = new System.Windows.Forms.TextBox();
            this.lblcustumers = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtteclado = new System.Windows.Forms.CheckBox();
            this.rbtcable = new System.Windows.Forms.CheckBox();
            this.rbtusb = new System.Windows.Forms.CheckBox();
            this.rbtmouse = new System.Windows.Forms.CheckBox();
            this.rbtaudifono = new System.Windows.Forms.CheckBox();
            this.rbtbocina = new System.Windows.Forms.CheckBox();
            this.lbltoday = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.picxlogo = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcopyright
            // 
            this.lblcopyright.AutoSize = true;
            this.lblcopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcopyright.Location = new System.Drawing.Point(12, 266);
            this.lblcopyright.Name = "lblcopyright";
            this.lblcopyright.Size = new System.Drawing.Size(76, 7);
            this.lblcopyright.TabIndex = 13;
            this.lblcopyright.Text = "© Edwin Roman 2019.";
            // 
            // tboxcustumer
            // 
            this.tboxcustumer.Location = new System.Drawing.Point(106, 71);
            this.tboxcustumer.Name = "tboxcustumer";
            this.tboxcustumer.Size = new System.Drawing.Size(137, 20);
            this.tboxcustumer.TabIndex = 14;
            // 
            // lblcustumers
            // 
            this.lblcustumers.AutoSize = true;
            this.lblcustumers.Location = new System.Drawing.Point(41, 74);
            this.lblcustumers.Name = "lblcustumers";
            this.lblcustumers.Size = new System.Drawing.Size(59, 13);
            this.lblcustumers.TabIndex = 15;
            this.lblcustumers.Text = "Custumers:";
            // 
            // lblresult
            // 
            this.lblresult.Location = new System.Drawing.Point(381, 250);
            this.lblresult.Name = "lblresult";
            this.lblresult.ReadOnly = true;
            this.lblresult.Size = new System.Drawing.Size(100, 20);
            this.lblresult.TabIndex = 16;
            this.lblresult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtteclado);
            this.groupBox1.Controls.Add(this.rbtcable);
            this.groupBox1.Controls.Add(this.rbtusb);
            this.groupBox1.Controls.Add(this.rbtmouse);
            this.groupBox1.Controls.Add(this.rbtaudifono);
            this.groupBox1.Controls.Add(this.rbtbocina);
            this.groupBox1.Location = new System.Drawing.Point(40, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Productos";
            // 
            // rbtteclado
            // 
            this.rbtteclado.AutoSize = true;
            this.rbtteclado.Location = new System.Drawing.Point(169, 66);
            this.rbtteclado.Name = "rbtteclado";
            this.rbtteclado.Size = new System.Drawing.Size(115, 17);
            this.rbtteclado.TabIndex = 21;
            this.rbtteclado.Text = "Teclado USB/PS2";
            this.rbtteclado.UseVisualStyleBackColor = true;
            // 
            // rbtcable
            // 
            this.rbtcable.AutoSize = true;
            this.rbtcable.Location = new System.Drawing.Point(294, 66);
            this.rbtcable.Name = "rbtcable";
            this.rbtcable.Size = new System.Drawing.Size(78, 17);
            this.rbtcable.TabIndex = 21;
            this.rbtcable.Text = "Cable VGA";
            this.rbtcable.UseVisualStyleBackColor = true;
            // 
            // rbtusb
            // 
            this.rbtusb.AutoSize = true;
            this.rbtusb.Location = new System.Drawing.Point(19, 33);
            this.rbtusb.Name = "rbtusb";
            this.rbtusb.Size = new System.Drawing.Size(92, 17);
            this.rbtusb.TabIndex = 20;
            this.rbtusb.Text = "USB Kingston";
            this.rbtusb.UseVisualStyleBackColor = true;
            // 
            // rbtmouse
            // 
            this.rbtmouse.AutoSize = true;
            this.rbtmouse.Location = new System.Drawing.Point(19, 66);
            this.rbtmouse.Name = "rbtmouse";
            this.rbtmouse.Size = new System.Drawing.Size(107, 17);
            this.rbtmouse.TabIndex = 21;
            this.rbtmouse.Text = "Mouses Logitech";
            this.rbtmouse.UseVisualStyleBackColor = true;
            // 
            // rbtaudifono
            // 
            this.rbtaudifono.AutoSize = true;
            this.rbtaudifono.Location = new System.Drawing.Point(169, 33);
            this.rbtaudifono.Name = "rbtaudifono";
            this.rbtaudifono.Size = new System.Drawing.Size(76, 17);
            this.rbtaudifono.TabIndex = 21;
            this.rbtaudifono.Text = "Audifonos ";
            this.rbtaudifono.UseVisualStyleBackColor = true;
            // 
            // rbtbocina
            // 
            this.rbtbocina.AutoSize = true;
            this.rbtbocina.Location = new System.Drawing.Point(294, 33);
            this.rbtbocina.Name = "rbtbocina";
            this.rbtbocina.Size = new System.Drawing.Size(89, 17);
            this.rbtbocina.TabIndex = 21;
            this.rbtbocina.Text = "Bocinas USB";
            this.rbtbocina.UseVisualStyleBackColor = true;
            // 
            // lbltoday
            // 
            this.lbltoday.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltoday.AutoSize = true;
            this.lbltoday.Location = new System.Drawing.Point(417, 21);
            this.lbltoday.Name = "lbltoday";
            this.lbltoday.Size = new System.Drawing.Size(35, 13);
            this.lbltoday.TabIndex = 18;
            this.lbltoday.Text = "label1";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(377, 69);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 19;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // picxlogo
            // 
            this.picxlogo.Image = ((System.Drawing.Image)(resources.GetObject("picxlogo.Image")));
            this.picxlogo.Location = new System.Drawing.Point(0, -1);
            this.picxlogo.Name = "picxlogo";
            this.picxlogo.Size = new System.Drawing.Size(71, 59);
            this.picxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picxlogo.TabIndex = 20;
            this.picxlogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 282);
            this.Controls.Add(this.picxlogo);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lbltoday);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblcustumers);
            this.Controls.Add(this.tboxcustumer);
            this.Controls.Add(this.lblcopyright);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formularios Ventas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picxlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcopyright;
        private System.Windows.Forms.TextBox tboxcustumer;
        private System.Windows.Forms.Label lblcustumers;
        private System.Windows.Forms.TextBox lblresult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltoday;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.CheckBox rbtteclado;
        private System.Windows.Forms.CheckBox rbtcable;
        private System.Windows.Forms.CheckBox rbtusb;
        private System.Windows.Forms.CheckBox rbtmouse;
        private System.Windows.Forms.CheckBox rbtaudifono;
        private System.Windows.Forms.CheckBox rbtbocina;
        private System.Windows.Forms.PictureBox picxlogo;
    }
}

