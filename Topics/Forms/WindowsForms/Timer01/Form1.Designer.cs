namespace Programa04_01
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
            this.tmrpresent = new System.Windows.Forms.Timer(this.components);
            this.lblrepresentation = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.lbldate = new System.Windows.Forms.Label();
            this.tmrclock = new System.Windows.Forms.Timer(this.components);
            this.trbconteo = new System.Windows.Forms.TrackBar();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tlslblestadobar = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.trbconteo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrpresent
            // 
            this.tmrpresent.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblrepresentation
            // 
            this.lblrepresentation.AutoSize = true;
            this.lblrepresentation.Location = new System.Drawing.Point(219, 67);
            this.lblrepresentation.Name = "lblrepresentation";
            this.lblrepresentation.Size = new System.Drawing.Size(13, 13);
            this.lblrepresentation.TabIndex = 0;
            this.lblrepresentation.Text = "0";
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(70, 131);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(132, 42);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(251, 131);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(132, 42);
            this.btnstop.TabIndex = 2;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(361, 18);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(43, 13);
            this.lbldate.TabIndex = 3;
            this.lbldate.Text = "00:00 ..";
            // 
            // tmrclock
            // 
            this.tmrclock.Interval = 1000;
            this.tmrclock.Tick += new System.EventHandler(this.tmrclock_Tick);
            // 
            // trbconteo
            // 
            this.trbconteo.Location = new System.Drawing.Point(22, 213);
            this.trbconteo.Maximum = 1000;
            this.trbconteo.Minimum = 100;
            this.trbconteo.Name = "trbconteo";
            this.trbconteo.Size = new System.Drawing.Size(406, 45);
            this.trbconteo.TabIndex = 4;
            this.trbconteo.TickFrequency = 10;
            this.trbconteo.Value = 100;
            this.trbconteo.Scroll += new System.EventHandler(this.trbconteo_Scroll);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlslblestadobar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 264);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(451, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tlslblestadobar
            // 
            this.tlslblestadobar.Name = "tlslblestadobar";
            this.tlslblestadobar.Size = new System.Drawing.Size(118, 17);
            this.tlslblestadobar.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 286);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.trbconteo);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lblrepresentation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trbconteo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrpresent;
        private System.Windows.Forms.Label lblrepresentation;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Timer tmrclock;
        private System.Windows.Forms.TrackBar trbconteo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tlslblestadobar;
    }
}

