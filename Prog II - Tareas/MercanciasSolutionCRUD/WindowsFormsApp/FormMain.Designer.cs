
namespace WindowsFormsApp
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.dataGridMercaderia = new System.Windows.Forms.DataGridView();
            this.idMercanciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noEliminableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cMercaderiaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tboxSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMercaderia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMercaderiaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridMercaderia
            // 
            this.dataGridMercaderia.AutoGenerateColumns = false;
            this.dataGridMercaderia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridMercaderia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridMercaderia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMercaderia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMercanciaDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.existenciaDataGridViewTextBoxColumn,
            this.comentarioDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.noEliminableDataGridViewTextBoxColumn,
            this.btnEdit,
            this.btnDelete});
            this.dataGridMercaderia.DataSource = this.cMercaderiaBindingSource1;
            this.dataGridMercaderia.Location = new System.Drawing.Point(22, 129);
            this.dataGridMercaderia.Name = "dataGridMercaderia";
            this.dataGridMercaderia.Size = new System.Drawing.Size(830, 325);
            this.dataGridMercaderia.TabIndex = 0;
            this.dataGridMercaderia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMercaderia_CellContentClick);
            // 
            // idMercanciaDataGridViewTextBoxColumn
            // 
            this.idMercanciaDataGridViewTextBoxColumn.DataPropertyName = "IdMercancia";
            this.idMercanciaDataGridViewTextBoxColumn.HeaderText = "IdMercancia";
            this.idMercanciaDataGridViewTextBoxColumn.Name = "idMercanciaDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // existenciaDataGridViewTextBoxColumn
            // 
            this.existenciaDataGridViewTextBoxColumn.DataPropertyName = "Existencia";
            this.existenciaDataGridViewTextBoxColumn.HeaderText = "Existencia";
            this.existenciaDataGridViewTextBoxColumn.Name = "existenciaDataGridViewTextBoxColumn";
            // 
            // comentarioDataGridViewTextBoxColumn
            // 
            this.comentarioDataGridViewTextBoxColumn.DataPropertyName = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.HeaderText = "Comentario";
            this.comentarioDataGridViewTextBoxColumn.Name = "comentarioDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // noEliminableDataGridViewTextBoxColumn
            // 
            this.noEliminableDataGridViewTextBoxColumn.DataPropertyName = "NoEliminable";
            this.noEliminableDataGridViewTextBoxColumn.HeaderText = "NoEliminable";
            this.noEliminableDataGridViewTextBoxColumn.Name = "noEliminableDataGridViewTextBoxColumn";
            // 
            // btnEdit
            // 
            this.btnEdit.HeaderText = "Editar";
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ReadOnly = true;
            this.btnEdit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnEdit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseColumnTextForButtonValue = true;
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Eliminar";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ReadOnly = true;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseColumnTextForButtonValue = true;
            // 
            // cMercaderiaBindingSource1
            // 
            this.cMercaderiaBindingSource1.DataSource = typeof(ClassLibrary.Entities.CMercaderia);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos de Existencias:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(702, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tboxSearch
            // 
            this.tboxSearch.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxSearch.Location = new System.Drawing.Point(84, 79);
            this.tboxSearch.Multiline = true;
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.Size = new System.Drawing.Size(598, 21);
            this.tboxSearch.TabIndex = 5;
            this.tboxSearch.TextChanged += new System.EventHandler(this.tboxSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(18, 77);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(60, 21);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Buscar:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 520);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tboxSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridMercaderia);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMercaderia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMercaderiaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridMercaderia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tboxSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.BindingSource cMercaderiaBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMercanciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn comentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noEliminableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn btnEdit;
        private System.Windows.Forms.DataGridViewButtonColumn btnDelete;
    }
}

