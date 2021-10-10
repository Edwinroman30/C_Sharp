namespace Testing_That_learned
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcabezera = new System.Windows.Forms.Label();
            this.gbitems = new System.Windows.Forms.GroupBox();
            this.ckbtv = new System.Windows.Forms.CheckBox();
            this.ckbhp = new System.Windows.Forms.CheckBox();
            this.ckbaire = new System.Windows.Forms.CheckBox();
            this.ckbabanico = new System.Windows.Forms.CheckBox();
            this.ckbusb = new System.Windows.Forms.CheckBox();
            this.ckbwatch = new System.Windows.Forms.CheckBox();
            this.stsinformation = new System.Windows.Forms.StatusStrip();
            this.stslbltotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.btncalcular = new System.Windows.Forms.Button();
            this.stslblname = new System.Windows.Forms.ToolStripStatusLabel();
            this.stslblcantidad = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmsgeneral = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.coloresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anotherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.gbitems.SuspendLayout();
            this.stsinformation.SuspendLayout();
            this.cmsgeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblcabezera);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 33);
            this.panel1.TabIndex = 0;
            // 
            // lblcabezera
            // 
            this.lblcabezera.AutoSize = true;
            this.lblcabezera.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcabezera.ForeColor = System.Drawing.Color.Gray;
            this.lblcabezera.Location = new System.Drawing.Point(130, 4);
            this.lblcabezera.Name = "lblcabezera";
            this.lblcabezera.Size = new System.Drawing.Size(165, 25);
            this.lblcabezera.TabIndex = 0;
            this.lblcabezera.Text = "Items Chances";
            // 
            // gbitems
            // 
            this.gbitems.Controls.Add(this.ckbwatch);
            this.gbitems.Controls.Add(this.ckbusb);
            this.gbitems.Controls.Add(this.ckbabanico);
            this.gbitems.Controls.Add(this.ckbaire);
            this.gbitems.Controls.Add(this.ckbhp);
            this.gbitems.Controls.Add(this.ckbtv);
            this.gbitems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbitems.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.gbitems.Location = new System.Drawing.Point(15, 64);
            this.gbitems.Name = "gbitems";
            this.gbitems.Size = new System.Drawing.Size(392, 135);
            this.gbitems.TabIndex = 1;
            this.gbitems.TabStop = false;
            this.gbitems.Text = "Productos Elegidos";
            // 
            // ckbtv
            // 
            this.ckbtv.AutoSize = true;
            this.ckbtv.Location = new System.Drawing.Point(24, 39);
            this.ckbtv.Name = "ckbtv";
            this.ckbtv.Size = new System.Drawing.Size(105, 17);
            this.ckbtv.TabIndex = 0;
            this.ckbtv.Text = "TV Samsung 32´";
            this.ckbtv.UseVisualStyleBackColor = true;
            // 
            // ckbhp
            // 
            this.ckbhp.AutoSize = true;
            this.ckbhp.Location = new System.Drawing.Point(24, 78);
            this.ckbhp.Name = "ckbhp";
            this.ckbhp.Size = new System.Drawing.Size(103, 17);
            this.ckbhp.TabIndex = 1;
            this.ckbhp.Text = "Hp Chromebook";
            this.ckbhp.UseVisualStyleBackColor = true;
            // 
            // ckbaire
            // 
            this.ckbaire.AutoSize = true;
            this.ckbaire.Location = new System.Drawing.Point(155, 39);
            this.ckbaire.Name = "ckbaire";
            this.ckbaire.Size = new System.Drawing.Size(64, 17);
            this.ckbaire.TabIndex = 2;
            this.ckbaire.Text = "Aire RM";
            this.ckbaire.UseVisualStyleBackColor = true;
            // 
            // ckbabanico
            // 
            this.ckbabanico.AutoSize = true;
            this.ckbabanico.Location = new System.Drawing.Point(155, 78);
            this.ckbabanico.Name = "ckbabanico";
            this.ckbabanico.Size = new System.Drawing.Size(76, 17);
            this.ckbabanico.TabIndex = 3;
            this.ckbabanico.Text = "Freezer Air";
            this.ckbabanico.UseVisualStyleBackColor = true;
            // 
            // ckbusb
            // 
            this.ckbusb.AutoSize = true;
            this.ckbusb.Location = new System.Drawing.Point(289, 39);
            this.ckbusb.Name = "ckbusb";
            this.ckbusb.Size = new System.Drawing.Size(84, 17);
            this.ckbusb.TabIndex = 4;
            this.ckbusb.Text = "Control USB";
            this.ckbusb.UseVisualStyleBackColor = true;
            // 
            // ckbwatch
            // 
            this.ckbwatch.AutoSize = true;
            this.ckbwatch.Location = new System.Drawing.Point(289, 78);
            this.ckbwatch.Name = "ckbwatch";
            this.ckbwatch.Size = new System.Drawing.Size(76, 17);
            this.ckbwatch.TabIndex = 5;
            this.ckbwatch.Text = "Watch 3.5";
            this.ckbwatch.UseVisualStyleBackColor = true;
            // 
            // stsinformation
            // 
            this.stsinformation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stslblname,
            this.stslblcantidad,
            this.stslbltotal});
            this.stsinformation.Location = new System.Drawing.Point(0, 294);
            this.stsinformation.Name = "stsinformation";
            this.stsinformation.Size = new System.Drawing.Size(423, 22);
            this.stsinformation.TabIndex = 2;
            this.stsinformation.Text = "statusStrip1";
            // 
            // stslbltotal
            // 
            this.stslbltotal.Name = "stslbltotal";
            this.stslbltotal.Size = new System.Drawing.Size(45, 17);
            this.stslbltotal.Text = "Total: 0";
            // 
            // btncalcular
            // 
            this.btncalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncalcular.ForeColor = System.Drawing.Color.White;
            this.btncalcular.Location = new System.Drawing.Point(174, 226);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // stslblname
            // 
            this.stslblname.AutoSize = false;
            this.stslblname.Name = "stslblname";
            this.stslblname.Size = new System.Drawing.Size(160, 17);
            this.stslblname.Text = "Name: ";
            this.stslblname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stslblcantidad
            // 
            this.stslblcantidad.Name = "stslblcantidad";
            this.stslblcantidad.Size = new System.Drawing.Size(89, 17);
            this.stslblcantidad.Text = "Candidad = 0/6";
            // 
            // cmsgeneral
            // 
            this.cmsgeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coloresToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.cmsgeneral.Name = "cmsgeneral";
            this.cmsgeneral.Size = new System.Drawing.Size(115, 48);
            // 
            // coloresToolStripMenuItem
            // 
            this.coloresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.anotherToolStripMenuItem});
            this.coloresToolStripMenuItem.Name = "coloresToolStripMenuItem";
            this.coloresToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.coloresToolStripMenuItem.Text = "Colores";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // anotherToolStripMenuItem
            // 
            this.anotherToolStripMenuItem.Name = "anotherToolStripMenuItem";
            this.anotherToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.anotherToolStripMenuItem.Text = "Another";
            this.anotherToolStripMenuItem.Click += new System.EventHandler(this.anotherToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(423, 316);
            this.ContextMenuStrip = this.cmsgeneral;
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.stsinformation);
            this.Controls.Add(this.gbitems);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testing";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbitems.ResumeLayout(false);
            this.gbitems.PerformLayout();
            this.stsinformation.ResumeLayout(false);
            this.stsinformation.PerformLayout();
            this.cmsgeneral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcabezera;
        private System.Windows.Forms.GroupBox gbitems;
        private System.Windows.Forms.CheckBox ckbwatch;
        private System.Windows.Forms.CheckBox ckbusb;
        private System.Windows.Forms.CheckBox ckbabanico;
        private System.Windows.Forms.CheckBox ckbaire;
        private System.Windows.Forms.CheckBox ckbhp;
        private System.Windows.Forms.CheckBox ckbtv;
        private System.Windows.Forms.StatusStrip stsinformation;
        private System.Windows.Forms.ToolStripStatusLabel stslbltotal;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.ToolStripStatusLabel stslblname;
        private System.Windows.Forms.ToolStripStatusLabel stslblcantidad;
        private System.Windows.Forms.ContextMenuStrip cmsgeneral;
        private System.Windows.Forms.ToolStripMenuItem coloresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anotherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

