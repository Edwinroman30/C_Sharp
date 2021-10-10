namespace Programa01_05
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
            this.lblinformacionprin = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.gboxoperaciones = new System.Windows.Forms.GroupBox();
            this.rbdividir = new System.Windows.Forms.RadioButton();
            this.rbmultiplicar = new System.Windows.Forms.RadioButton();
            this.rbrestar = new System.Windows.Forms.RadioButton();
            this.rbsumar = new System.Windows.Forms.RadioButton();
            this.gboxcolores = new System.Windows.Forms.GroupBox();
            this.rbblack = new System.Windows.Forms.RadioButton();
            this.rbyellow = new System.Windows.Forms.RadioButton();
            this.rbgreen = new System.Windows.Forms.RadioButton();
            this.rbred = new System.Windows.Forms.RadioButton();
            this.btnactivar = new System.Windows.Forms.Button();
            this.lblcopyright = new System.Windows.Forms.Label();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.gboxoperaciones.SuspendLayout();
            this.gboxcolores.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblinformacionprin
            // 
            this.lblinformacionprin.AutoSize = true;
            this.lblinformacionprin.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinformacionprin.Location = new System.Drawing.Point(102, 27);
            this.lblinformacionprin.Name = "lblinformacionprin";
            this.lblinformacionprin.Size = new System.Drawing.Size(115, 24);
            this.lblinformacionprin.TabIndex = 0;
            this.lblinformacionprin.Text = "Calculator:";
            // 
            // txbA
            // 
            this.txbA.Location = new System.Drawing.Point(21, 79);
            this.txbA.Name = "txbA";
            this.txbA.Size = new System.Drawing.Size(129, 20);
            this.txbA.TabIndex = 1;
            this.txbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbB
            // 
            this.txbB.Location = new System.Drawing.Point(172, 79);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(129, 20);
            this.txbB.TabIndex = 2;
            this.txbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(21, 117);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(94, 26);
            this.btncalcular.TabIndex = 3;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresultado.Location = new System.Drawing.Point(137, 161);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(45, 16);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Text = "label1";
            // 
            // gboxoperaciones
            // 
            this.gboxoperaciones.Controls.Add(this.rbdividir);
            this.gboxoperaciones.Controls.Add(this.rbmultiplicar);
            this.gboxoperaciones.Controls.Add(this.rbrestar);
            this.gboxoperaciones.Controls.Add(this.rbsumar);
            this.gboxoperaciones.Location = new System.Drawing.Point(22, 211);
            this.gboxoperaciones.Name = "gboxoperaciones";
            this.gboxoperaciones.Size = new System.Drawing.Size(131, 140);
            this.gboxoperaciones.TabIndex = 5;
            this.gboxoperaciones.TabStop = false;
            this.gboxoperaciones.Text = "Operaciones:";
            // 
            // rbdividir
            // 
            this.rbdividir.AutoSize = true;
            this.rbdividir.Location = new System.Drawing.Point(7, 98);
            this.rbdividir.Name = "rbdividir";
            this.rbdividir.Size = new System.Drawing.Size(54, 17);
            this.rbdividir.TabIndex = 3;
            this.rbdividir.TabStop = true;
            this.rbdividir.Text = "Dividir";
            this.rbdividir.UseVisualStyleBackColor = true;
            // 
            // rbmultiplicar
            // 
            this.rbmultiplicar.AutoSize = true;
            this.rbmultiplicar.Location = new System.Drawing.Point(7, 74);
            this.rbmultiplicar.Name = "rbmultiplicar";
            this.rbmultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rbmultiplicar.TabIndex = 2;
            this.rbmultiplicar.TabStop = true;
            this.rbmultiplicar.Text = "Multiplicar";
            this.rbmultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbrestar
            // 
            this.rbrestar.AutoSize = true;
            this.rbrestar.Location = new System.Drawing.Point(7, 50);
            this.rbrestar.Name = "rbrestar";
            this.rbrestar.Size = new System.Drawing.Size(56, 17);
            this.rbrestar.TabIndex = 1;
            this.rbrestar.TabStop = true;
            this.rbrestar.Text = "Restar";
            this.rbrestar.UseVisualStyleBackColor = true;
            // 
            // rbsumar
            // 
            this.rbsumar.AutoSize = true;
            this.rbsumar.Location = new System.Drawing.Point(7, 26);
            this.rbsumar.Name = "rbsumar";
            this.rbsumar.Size = new System.Drawing.Size(55, 17);
            this.rbsumar.TabIndex = 0;
            this.rbsumar.TabStop = true;
            this.rbsumar.Text = "Sumar";
            this.rbsumar.UseVisualStyleBackColor = true;
            // 
            // gboxcolores
            // 
            this.gboxcolores.Controls.Add(this.rbblack);
            this.gboxcolores.Controls.Add(this.rbyellow);
            this.gboxcolores.Controls.Add(this.rbgreen);
            this.gboxcolores.Controls.Add(this.rbred);
            this.gboxcolores.Location = new System.Drawing.Point(166, 211);
            this.gboxcolores.Name = "gboxcolores";
            this.gboxcolores.Size = new System.Drawing.Size(131, 140);
            this.gboxcolores.TabIndex = 6;
            this.gboxcolores.TabStop = false;
            this.gboxcolores.Text = "Color del Resultado:";
            // 
            // rbblack
            // 
            this.rbblack.AutoSize = true;
            this.rbblack.Location = new System.Drawing.Point(7, 98);
            this.rbblack.Name = "rbblack";
            this.rbblack.Size = new System.Drawing.Size(57, 17);
            this.rbblack.TabIndex = 3;
            this.rbblack.TabStop = true;
            this.rbblack.Text = "Negro.";
            this.rbblack.UseVisualStyleBackColor = true;
            // 
            // rbyellow
            // 
            this.rbyellow.AutoSize = true;
            this.rbyellow.Location = new System.Drawing.Point(7, 74);
            this.rbyellow.Name = "rbyellow";
            this.rbyellow.Size = new System.Drawing.Size(64, 17);
            this.rbyellow.TabIndex = 2;
            this.rbyellow.TabStop = true;
            this.rbyellow.Text = "Amarillo.";
            this.rbyellow.UseVisualStyleBackColor = true;
            // 
            // rbgreen
            // 
            this.rbgreen.AutoSize = true;
            this.rbgreen.Location = new System.Drawing.Point(7, 50);
            this.rbgreen.Name = "rbgreen";
            this.rbgreen.Size = new System.Drawing.Size(56, 17);
            this.rbgreen.TabIndex = 1;
            this.rbgreen.TabStop = true;
            this.rbgreen.Text = "Verde.";
            this.rbgreen.UseVisualStyleBackColor = true;
            // 
            // rbred
            // 
            this.rbred.AutoSize = true;
            this.rbred.Location = new System.Drawing.Point(7, 26);
            this.rbred.Name = "rbred";
            this.rbred.Size = new System.Drawing.Size(50, 17);
            this.rbred.TabIndex = 0;
            this.rbred.TabStop = true;
            this.rbred.Text = "Rojo.";
            this.rbred.UseVisualStyleBackColor = true;
            // 
            // btnactivar
            // 
            this.btnactivar.Location = new System.Drawing.Point(202, 117);
            this.btnactivar.Name = "btnactivar";
            this.btnactivar.Size = new System.Drawing.Size(94, 26);
            this.btnactivar.TabIndex = 3;
            this.btnactivar.Text = "Activar";
            this.btnactivar.UseVisualStyleBackColor = true;
            this.btnactivar.Click += new System.EventHandler(this.btnactivar_Click);
            // 
            // lblcopyright
            // 
            this.lblcopyright.AutoSize = true;
            this.lblcopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcopyright.Location = new System.Drawing.Point(7, 377);
            this.lblcopyright.Name = "lblcopyright";
            this.lblcopyright.Size = new System.Drawing.Size(76, 7);
            this.lblcopyright.TabIndex = 11;
            this.lblcopyright.Text = "© Edwin Roman 2019.";
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(131, 117);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(57, 26);
            this.btnrefresh.TabIndex = 12;
            this.btnrefresh.Text = "R";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 393);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.lblcopyright);
            this.Controls.Add(this.gboxcolores);
            this.Controls.Add(this.gboxoperaciones);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnactivar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txbA);
            this.Controls.Add(this.lblinformacionprin);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxoperaciones.ResumeLayout(false);
            this.gboxoperaciones.PerformLayout();
            this.gboxcolores.ResumeLayout(false);
            this.gboxcolores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinformacionprin;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.GroupBox gboxoperaciones;
        private System.Windows.Forms.RadioButton rbdividir;
        private System.Windows.Forms.RadioButton rbmultiplicar;
        private System.Windows.Forms.RadioButton rbrestar;
        private System.Windows.Forms.RadioButton rbsumar;
        private System.Windows.Forms.GroupBox gboxcolores;
        private System.Windows.Forms.RadioButton rbblack;
        private System.Windows.Forms.RadioButton rbyellow;
        private System.Windows.Forms.RadioButton rbgreen;
        private System.Windows.Forms.RadioButton rbred;
        private System.Windows.Forms.Button btnactivar;
        private System.Windows.Forms.Label lblcopyright;
        private System.Windows.Forms.Button btnrefresh;
    }
}

