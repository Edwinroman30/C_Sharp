namespace Programa03_01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otraCosaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.divisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.habillitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ModooscuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tboxA = new System.Windows.Forms.TextBox();
            this.cmenutbox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.limpiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numeroAzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tboxB = new System.Windows.Forms.TextBox();
            this.cmenubox2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblresult = new System.Windows.Forms.Label();
            this.tlsoperaciones = new System.Windows.Forms.ToolStrip();
            this.tlsbSuma = new System.Windows.Forms.ToolStripButton();
            this.tlsbResta = new System.Windows.Forms.ToolStripButton();
            this.tlsbMulti = new System.Windows.Forms.ToolStripButton();
            this.tlsbDivision = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlsbrdn = new System.Windows.Forms.ToolStripButton();
            this.stsInformacion = new System.Windows.Forms.StatusStrip();
            this.stslblcantidad = new System.Windows.Forms.ToolStripStatusLabel();
            this.stslbloperacion = new System.Windows.Forms.ToolStripStatusLabel();
            this.stslblresultado = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.cmenutbox.SuspendLayout();
            this.cmenubox2.SuspendLayout();
            this.tlsoperaciones.SuspendLayout();
            this.stsInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operacionesToolStripMenuItem,
            this.ayudaToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(339, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // operacionesToolStripMenuItem
            // 
            this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumaToolStripMenuItem,
            this.restaToolStripMenuItem,
            this.multiplicacionToolStripMenuItem,
            this.divisionToolStripMenuItem});
            this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
            this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.operacionesToolStripMenuItem.Text = "Operaciones";
            // 
            // sumaToolStripMenuItem
            // 
            this.sumaToolStripMenuItem.Name = "sumaToolStripMenuItem";
            this.sumaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.sumaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.sumaToolStripMenuItem.Text = "Suma";
            this.sumaToolStripMenuItem.ToolTipText = "Este opera como incrementador.";
            this.sumaToolStripMenuItem.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // restaToolStripMenuItem
            // 
            this.restaToolStripMenuItem.Name = "restaToolStripMenuItem";
            this.restaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.restaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.restaToolStripMenuItem.Text = "Resta";
            this.restaToolStripMenuItem.ToolTipText = "Este opera como disminuidor.";
            this.restaToolStripMenuItem.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // multiplicacionToolStripMenuItem
            // 
            this.multiplicacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.otraCosaToolStripMenuItem});
            this.multiplicacionToolStripMenuItem.Name = "multiplicacionToolStripMenuItem";
            this.multiplicacionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.multiplicacionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.multiplicacionToolStripMenuItem.Text = "Multiplicacion";
            this.multiplicacionToolStripMenuItem.Click += new System.EventHandler(this.multiplicacionToolStripMenuItem_Click);
            // 
            // otraCosaToolStripMenuItem
            // 
            this.otraCosaToolStripMenuItem.Name = "otraCosaToolStripMenuItem";
            this.otraCosaToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.otraCosaToolStripMenuItem.Text = "Otra cosa";
            // 
            // divisionToolStripMenuItem
            // 
            this.divisionToolStripMenuItem.Name = "divisionToolStripMenuItem";
            this.divisionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.divisionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.divisionToolStripMenuItem.Text = "Division";
            this.divisionToolStripMenuItem.Click += new System.EventHandler(this.divisionToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem,
            this.toolStripSeparator1,
            this.habillitarToolStripMenuItem,
            this.toolStripSeparator2,
            this.ModooscuroToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // habillitarToolStripMenuItem
            // 
            this.habillitarToolStripMenuItem.Checked = true;
            this.habillitarToolStripMenuItem.CheckOnClick = true;
            this.habillitarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.habillitarToolStripMenuItem.Name = "habillitarToolStripMenuItem";
            this.habillitarToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.habillitarToolStripMenuItem.Text = "Habillitar";
            this.habillitarToolStripMenuItem.ToolTipText = "Sirve para habilitar los comboxs.";
            this.habillitarToolStripMenuItem.CheckedChanged += new System.EventHandler(this.habillitarToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(144, 6);
            // 
            // ModooscuroToolStripMenuItem
            // 
            this.ModooscuroToolStripMenuItem.CheckOnClick = true;
            this.ModooscuroToolStripMenuItem.Name = "ModooscuroToolStripMenuItem";
            this.ModooscuroToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.ModooscuroToolStripMenuItem.Text = "Modo Oscuro";
            this.ModooscuroToolStripMenuItem.ToolTipText = "Esta Propiedad se llama TooTipText";
            this.ModooscuroToolStripMenuItem.CheckedChanged += new System.EventHandler(this.ModooscuroToolStripMenuItem_CheckedChanged);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.ToolTipText = "Cierra la aplicacion completamente";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tboxA
            // 
            this.tboxA.ContextMenuStrip = this.cmenutbox;
            this.tboxA.Location = new System.Drawing.Point(39, 106);
            this.tboxA.Name = "tboxA";
            this.tboxA.Size = new System.Drawing.Size(100, 20);
            this.tboxA.TabIndex = 1;
            this.tboxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmenutbox
            // 
            this.cmenutbox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limpiarToolStripMenuItem,
            this.numeroAzarToolStripMenuItem});
            this.cmenutbox.Name = "cmenutbox";
            this.cmenutbox.Size = new System.Drawing.Size(145, 48);
            // 
            // limpiarToolStripMenuItem
            // 
            this.limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            this.limpiarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.limpiarToolStripMenuItem.Text = "Limpiar";
            this.limpiarToolStripMenuItem.Click += new System.EventHandler(this.limpiarToolStripMenuItem_Click);
            // 
            // numeroAzarToolStripMenuItem
            // 
            this.numeroAzarToolStripMenuItem.Name = "numeroAzarToolStripMenuItem";
            this.numeroAzarToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.numeroAzarToolStripMenuItem.Text = "Numero Azar";
            this.numeroAzarToolStripMenuItem.Click += new System.EventHandler(this.numeroAzarToolStripMenuItem_Click);
            // 
            // tboxB
            // 
            this.tboxB.ContextMenuStrip = this.cmenubox2;
            this.tboxB.Location = new System.Drawing.Point(195, 106);
            this.tboxB.Name = "tboxB";
            this.tboxB.Size = new System.Drawing.Size(100, 20);
            this.tboxB.TabIndex = 2;
            this.tboxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmenubox2
            // 
            this.cmenubox2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cleanToolStripMenuItem,
            this.randomToolStripMenuItem});
            this.cmenubox2.Name = "cmenubox2";
            this.cmenubox2.Size = new System.Drawing.Size(120, 48);
            // 
            // cleanToolStripMenuItem
            // 
            this.cleanToolStripMenuItem.Name = "cleanToolStripMenuItem";
            this.cleanToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.cleanToolStripMenuItem.Text = "Clean";
            this.cleanToolStripMenuItem.Click += new System.EventHandler(this.cleanToolStripMenuItem_Click);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.randomToolStripMenuItem.Text = "Random";
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.randomToolStripMenuItem_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(147, 189);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(40, 13);
            this.lblresult.TabIndex = 3;
            this.lblresult.Text = "-----------";
            // 
            // tlsoperaciones
            // 
            this.tlsoperaciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsbSuma,
            this.tlsbResta,
            this.tlsbMulti,
            this.tlsbDivision,
            this.toolStripSeparator3,
            this.tlsbrdn});
            this.tlsoperaciones.Location = new System.Drawing.Point(0, 24);
            this.tlsoperaciones.Name = "tlsoperaciones";
            this.tlsoperaciones.Size = new System.Drawing.Size(339, 25);
            this.tlsoperaciones.TabIndex = 4;
            this.tlsoperaciones.Text = "toolStrip1";
            // 
            // tlsbSuma
            // 
            this.tlsbSuma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbSuma.Image = ((System.Drawing.Image)(resources.GetObject("tlsbSuma.Image")));
            this.tlsbSuma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbSuma.Name = "tlsbSuma";
            this.tlsbSuma.Size = new System.Drawing.Size(23, 22);
            this.tlsbSuma.Text = "Suma";
            this.tlsbSuma.Click += new System.EventHandler(this.sumaToolStripMenuItem_Click);
            // 
            // tlsbResta
            // 
            this.tlsbResta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbResta.Image = ((System.Drawing.Image)(resources.GetObject("tlsbResta.Image")));
            this.tlsbResta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbResta.Name = "tlsbResta";
            this.tlsbResta.Size = new System.Drawing.Size(23, 22);
            this.tlsbResta.Text = "Resta";
            this.tlsbResta.Click += new System.EventHandler(this.restaToolStripMenuItem_Click);
            // 
            // tlsbMulti
            // 
            this.tlsbMulti.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbMulti.Image = ((System.Drawing.Image)(resources.GetObject("tlsbMulti.Image")));
            this.tlsbMulti.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbMulti.Name = "tlsbMulti";
            this.tlsbMulti.Size = new System.Drawing.Size(23, 22);
            this.tlsbMulti.Text = "Multiplicación";
            this.tlsbMulti.Click += new System.EventHandler(this.multiplicacionToolStripMenuItem_Click);
            // 
            // tlsbDivision
            // 
            this.tlsbDivision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbDivision.Image = ((System.Drawing.Image)(resources.GetObject("tlsbDivision.Image")));
            this.tlsbDivision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbDivision.Name = "tlsbDivision";
            this.tlsbDivision.Size = new System.Drawing.Size(23, 22);
            this.tlsbDivision.Text = "División";
            this.tlsbDivision.Click += new System.EventHandler(this.divisionToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // tlsbrdn
            // 
            this.tlsbrdn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsbrdn.Image = ((System.Drawing.Image)(resources.GetObject("tlsbrdn.Image")));
            this.tlsbrdn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsbrdn.Name = "tlsbrdn";
            this.tlsbrdn.Size = new System.Drawing.Size(23, 22);
            this.tlsbrdn.Text = "Ramdon";
            this.tlsbrdn.Click += new System.EventHandler(this.numeroAzarToolStripMenuItem_Click);
            // 
            // stsInformacion
            // 
            this.stsInformacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stslblcantidad,
            this.stslbloperacion,
            this.stslblresultado});
            this.stsInformacion.Location = new System.Drawing.Point(0, 246);
            this.stsInformacion.Name = "stsInformacion";
            this.stsInformacion.Size = new System.Drawing.Size(339, 24);
            this.stsInformacion.TabIndex = 5;
            this.stsInformacion.Text = "statusStrip1";
            // 
            // stslblcantidad
            // 
            this.stslblcantidad.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stslblcantidad.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
            this.stslblcantidad.Name = "stslblcantidad";
            this.stslblcantidad.Size = new System.Drawing.Size(63, 19);
            this.stslblcantidad.Text = "A=0 , B=0";
            // 
            // stslbloperacion
            // 
            this.stslbloperacion.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.stslbloperacion.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.stslbloperacion.Name = "stslbloperacion";
            this.stslbloperacion.Size = new System.Drawing.Size(92, 19);
            this.stslbloperacion.Text = "No identificada";
            // 
            // stslblresultado
            // 
            this.stslblresultado.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.stslblresultado.Name = "stslblresultado";
            this.stslblresultado.Size = new System.Drawing.Size(32, 19);
            this.stslblresultado.Text = "R=0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(339, 270);
            this.Controls.Add(this.stsInformacion);
            this.Controls.Add(this.tlsoperaciones);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.tboxB);
            this.Controls.Add(this.tboxA);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Strips";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.cmenutbox.ResumeLayout(false);
            this.cmenubox2.ResumeLayout(false);
            this.tlsoperaciones.ResumeLayout(false);
            this.tlsoperaciones.PerformLayout();
            this.stsInformacion.ResumeLayout(false);
            this.stsInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem divisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox tboxA;
        private System.Windows.Forms.TextBox tboxB;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem habillitarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ModooscuroToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmenutbox;
        private System.Windows.Forms.ToolStripMenuItem limpiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numeroAzarToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmenubox2;
        private System.Windows.Forms.ToolStripMenuItem cleanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otraCosaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tlsoperaciones;
        private System.Windows.Forms.ToolStripButton tlsbSuma;
        private System.Windows.Forms.ToolStripButton tlsbResta;
        private System.Windows.Forms.ToolStripButton tlsbMulti;
        private System.Windows.Forms.ToolStripButton tlsbDivision;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tlsbrdn;
        private System.Windows.Forms.StatusStrip stsInformacion;
        private System.Windows.Forms.ToolStripStatusLabel stslblcantidad;
        private System.Windows.Forms.ToolStripStatusLabel stslbloperacion;
        private System.Windows.Forms.ToolStripStatusLabel stslblresultado;
    }
}

