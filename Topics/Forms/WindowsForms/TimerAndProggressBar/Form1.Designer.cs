namespace Programa04_00
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
            this.lblconteo = new System.Windows.Forms.Label();
            this.btnstart = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.pbrresult = new System.Windows.Forms.ProgressBar();
            this.tbrtimer = new System.Windows.Forms.TrackBar();
            this.tmrprogreso = new System.Windows.Forms.Timer(this.components);
            this.btnrepeat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbrtimer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblconteo
            // 
            this.lblconteo.AutoSize = true;
            this.lblconteo.Location = new System.Drawing.Point(233, 36);
            this.lblconteo.Name = "lblconteo";
            this.lblconteo.Size = new System.Drawing.Size(13, 13);
            this.lblconteo.TabIndex = 0;
            this.lblconteo.Text = "0";
            // 
            // btnstart
            // 
            this.btnstart.Location = new System.Drawing.Point(100, 104);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(110, 39);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // btnstop
            // 
            this.btnstop.Location = new System.Drawing.Point(255, 104);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(110, 39);
            this.btnstop.TabIndex = 1;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // pbrresult
            // 
            this.pbrresult.Location = new System.Drawing.Point(53, 192);
            this.pbrresult.Name = "pbrresult";
            this.pbrresult.Size = new System.Drawing.Size(370, 23);
            this.pbrresult.TabIndex = 2;
            // 
            // tbrtimer
            // 
            this.tbrtimer.Location = new System.Drawing.Point(53, 234);
            this.tbrtimer.Maximum = 1000;
            this.tbrtimer.Minimum = 1;
            this.tbrtimer.Name = "tbrtimer";
            this.tbrtimer.Size = new System.Drawing.Size(370, 45);
            this.tbrtimer.TabIndex = 3;
            this.tbrtimer.TickFrequency = 25;
            this.tbrtimer.Value = 1;
            // 
            // tmrprogreso
            // 
            this.tmrprogreso.Tick += new System.EventHandler(this.tmrprogreso_Tick);
            // 
            // btnrepeat
            // 
            this.btnrepeat.Location = new System.Drawing.Point(12, 10);
            this.btnrepeat.Name = "btnrepeat";
            this.btnrepeat.Size = new System.Drawing.Size(31, 24);
            this.btnrepeat.TabIndex = 1;
            this.btnrepeat.Text = "R";
            this.btnrepeat.UseVisualStyleBackColor = true;
            this.btnrepeat.Click += new System.EventHandler(this.btnrepeat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 315);
            this.Controls.Add(this.tbrtimer);
            this.Controls.Add(this.pbrresult);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnrepeat);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lblconteo);
            this.Name = "Form1";
            this.Text = "Usando ProgressBar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tbrtimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblconteo;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.ProgressBar pbrresult;
        private System.Windows.Forms.TrackBar tbrtimer;
        private System.Windows.Forms.Timer tmrprogreso;
        private System.Windows.Forms.Button btnrepeat;
    }
}

