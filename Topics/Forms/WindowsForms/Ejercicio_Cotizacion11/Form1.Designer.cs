namespace Programa02_03
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
            this.lblnombre = new System.Windows.Forms.Label();
            this.tboxnombre = new System.Windows.Forms.TextBox();
            this.gboxselecionar = new System.Windows.Forms.GroupBox();
            this.gboxequipado = new System.Windows.Forms.GroupBox();
            this.rbbasico = new System.Windows.Forms.RadioButton();
            this.rbterceros = new System.Windows.Forms.RadioButton();
            this.rbtotal = new System.Windows.Forms.RadioButton();
            this.ckaire = new System.Windows.Forms.CheckBox();
            this.cksonido = new System.Windows.Forms.CheckBox();
            this.tboxcosto = new System.Windows.Forms.TextBox();
            this.lblcosto = new System.Windows.Forms.Label();
            this.tboxpresentacion = new System.Windows.Forms.TextBox();
            this.btncotizar = new System.Windows.Forms.Button();
            this.gboxselecionar.SuspendLayout();
            this.gboxequipado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.Location = new System.Drawing.Point(34, 37);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(55, 15);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre:";
            // 
            // tboxnombre
            // 
            this.tboxnombre.Location = new System.Drawing.Point(100, 36);
            this.tboxnombre.Name = "tboxnombre";
            this.tboxnombre.Size = new System.Drawing.Size(100, 20);
            this.tboxnombre.TabIndex = 1;
            // 
            // gboxselecionar
            // 
            this.gboxselecionar.Controls.Add(this.rbtotal);
            this.gboxselecionar.Controls.Add(this.rbterceros);
            this.gboxselecionar.Controls.Add(this.rbbasico);
            this.gboxselecionar.Location = new System.Drawing.Point(32, 88);
            this.gboxselecionar.Name = "gboxselecionar";
            this.gboxselecionar.Size = new System.Drawing.Size(205, 132);
            this.gboxselecionar.TabIndex = 2;
            this.gboxselecionar.TabStop = false;
            this.gboxselecionar.Text = "Seguro ha selecionar";
            // 
            // gboxequipado
            // 
            this.gboxequipado.Controls.Add(this.cksonido);
            this.gboxequipado.Controls.Add(this.ckaire);
            this.gboxequipado.Location = new System.Drawing.Point(299, 88);
            this.gboxequipado.Name = "gboxequipado";
            this.gboxequipado.Size = new System.Drawing.Size(205, 132);
            this.gboxequipado.TabIndex = 2;
            this.gboxequipado.TabStop = false;
            this.gboxequipado.Text = "Equipamiento";
            // 
            // rbbasico
            // 
            this.rbbasico.AutoSize = true;
            this.rbbasico.Checked = true;
            this.rbbasico.Location = new System.Drawing.Point(23, 32);
            this.rbbasico.Name = "rbbasico";
            this.rbbasico.Size = new System.Drawing.Size(57, 17);
            this.rbbasico.TabIndex = 0;
            this.rbbasico.TabStop = true;
            this.rbbasico.Text = "Basico";
            this.rbbasico.UseVisualStyleBackColor = true;
            // 
            // rbterceros
            // 
            this.rbterceros.AutoSize = true;
            this.rbterceros.Location = new System.Drawing.Point(23, 66);
            this.rbterceros.Name = "rbterceros";
            this.rbterceros.Size = new System.Drawing.Size(77, 17);
            this.rbterceros.TabIndex = 1;
            this.rbterceros.Text = "A Terceros";
            this.rbterceros.UseVisualStyleBackColor = true;
            // 
            // rbtotal
            // 
            this.rbtotal.AutoSize = true;
            this.rbtotal.Location = new System.Drawing.Point(23, 100);
            this.rbtotal.Name = "rbtotal";
            this.rbtotal.Size = new System.Drawing.Size(49, 17);
            this.rbtotal.TabIndex = 2;
            this.rbtotal.Text = "Total";
            this.rbtotal.UseVisualStyleBackColor = true;
            // 
            // ckaire
            // 
            this.ckaire.AutoSize = true;
            this.ckaire.Location = new System.Drawing.Point(16, 32);
            this.ckaire.Name = "ckaire";
            this.ckaire.Size = new System.Drawing.Size(118, 17);
            this.ckaire.TabIndex = 0;
            this.ckaire.Text = "Aire Acondicionado";
            this.ckaire.UseVisualStyleBackColor = true;
            // 
            // cksonido
            // 
            this.cksonido.AutoSize = true;
            this.cksonido.Location = new System.Drawing.Point(16, 66);
            this.cksonido.Name = "cksonido";
            this.cksonido.Size = new System.Drawing.Size(114, 17);
            this.cksonido.TabIndex = 1;
            this.cksonido.Text = "Sistema de Sonido";
            this.cksonido.UseVisualStyleBackColor = true;
            // 
            // tboxcosto
            // 
            this.tboxcosto.Location = new System.Drawing.Point(366, 37);
            this.tboxcosto.Name = "tboxcosto";
            this.tboxcosto.Size = new System.Drawing.Size(100, 20);
            this.tboxcosto.TabIndex = 3;
            this.tboxcosto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblcosto
            // 
            this.lblcosto.AutoSize = true;
            this.lblcosto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcosto.Location = new System.Drawing.Point(300, 37);
            this.lblcosto.Name = "lblcosto";
            this.lblcosto.Size = new System.Drawing.Size(41, 15);
            this.lblcosto.TabIndex = 4;
            this.lblcosto.Text = "Costo:";
            // 
            // tboxpresentacion
            // 
            this.tboxpresentacion.Location = new System.Drawing.Point(32, 284);
            this.tboxpresentacion.Multiline = true;
            this.tboxpresentacion.Name = "tboxpresentacion";
            this.tboxpresentacion.Size = new System.Drawing.Size(472, 178);
            this.tboxpresentacion.TabIndex = 5;
            // 
            // btncotizar
            // 
            this.btncotizar.Location = new System.Drawing.Point(229, 241);
            this.btncotizar.Name = "btncotizar";
            this.btncotizar.Size = new System.Drawing.Size(75, 23);
            this.btncotizar.TabIndex = 6;
            this.btncotizar.Text = "Cotizacion";
            this.btncotizar.UseVisualStyleBackColor = true;
            this.btncotizar.Click += new System.EventHandler(this.btncotizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 483);
            this.Controls.Add(this.btncotizar);
            this.Controls.Add(this.tboxpresentacion);
            this.Controls.Add(this.lblcosto);
            this.Controls.Add(this.tboxcosto);
            this.Controls.Add(this.gboxequipado);
            this.Controls.Add(this.gboxselecionar);
            this.Controls.Add(this.tboxnombre);
            this.Controls.Add(this.lblnombre);
            this.Name = "Form1";
            this.Text = "Forma de Cotizacion";
            this.gboxselecionar.ResumeLayout(false);
            this.gboxselecionar.PerformLayout();
            this.gboxequipado.ResumeLayout(false);
            this.gboxequipado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.TextBox tboxnombre;
        private System.Windows.Forms.GroupBox gboxselecionar;
        private System.Windows.Forms.RadioButton rbtotal;
        private System.Windows.Forms.RadioButton rbterceros;
        private System.Windows.Forms.RadioButton rbbasico;
        private System.Windows.Forms.GroupBox gboxequipado;
        private System.Windows.Forms.CheckBox cksonido;
        private System.Windows.Forms.CheckBox ckaire;
        private System.Windows.Forms.TextBox tboxcosto;
        private System.Windows.Forms.Label lblcosto;
        private System.Windows.Forms.TextBox tboxpresentacion;
        private System.Windows.Forms.Button btncotizar;
    }
}

