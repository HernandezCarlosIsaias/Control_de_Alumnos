namespace WindowsFormsApp1
{
    partial class frmAlumnos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlumnos));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarAlumno = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAlumno = new System.Windows.Forms.DataGridView();
            this.pbxAlumnos = new System.Windows.Forms.PictureBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDanza = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDanza = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.btnBuscar2 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1126, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.HotPink;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAlumno,
            this.eliminarAlumno,
            this.modificarAlumno});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.menuToolStripMenuItem.Text = "Menú";
            // 
            // agregarAlumno
            // 
            this.agregarAlumno.BackColor = System.Drawing.Color.HotPink;
            this.agregarAlumno.ForeColor = System.Drawing.Color.Black;
            this.agregarAlumno.Name = "agregarAlumno";
            this.agregarAlumno.Size = new System.Drawing.Size(237, 26);
            this.agregarAlumno.Text = "Agregar un Alumno";
            this.agregarAlumno.Click += new System.EventHandler(this.agregarAlumno_Click);
            // 
            // eliminarAlumno
            // 
            this.eliminarAlumno.BackColor = System.Drawing.Color.HotPink;
            this.eliminarAlumno.ForeColor = System.Drawing.Color.Black;
            this.eliminarAlumno.Name = "eliminarAlumno";
            this.eliminarAlumno.Size = new System.Drawing.Size(237, 26);
            this.eliminarAlumno.Text = "Eliminar un Alumno";
            this.eliminarAlumno.Click += new System.EventHandler(this.eliminarAlumno_Click);
            // 
            // modificarAlumno
            // 
            this.modificarAlumno.BackColor = System.Drawing.Color.HotPink;
            this.modificarAlumno.ForeColor = System.Drawing.Color.Black;
            this.modificarAlumno.Name = "modificarAlumno";
            this.modificarAlumno.Size = new System.Drawing.Size(237, 26);
            this.modificarAlumno.Text = "Modificar un Alumno";
            this.modificarAlumno.Click += new System.EventHandler(this.modificarAlumno_Click);
            // 
            // dgvAlumno
            // 
            this.dgvAlumno.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumno.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumno.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlumno.GridColor = System.Drawing.Color.LightPink;
            this.dgvAlumno.Location = new System.Drawing.Point(9, 79);
            this.dgvAlumno.MultiSelect = false;
            this.dgvAlumno.Name = "dgvAlumno";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.HotPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumno.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlumno.RowHeadersWidth = 62;
            this.dgvAlumno.RowTemplate.Height = 28;
            this.dgvAlumno.Size = new System.Drawing.Size(835, 313);
            this.dgvAlumno.TabIndex = 2;
            this.dgvAlumno.SelectionChanged += new System.EventHandler(this.DgvAlumno_SelectionChanged);
            // 
            // pbxAlumnos
            // 
            this.pbxAlumnos.Location = new System.Drawing.Point(860, 79);
            this.pbxAlumnos.Name = "pbxAlumnos";
            this.pbxAlumnos.Size = new System.Drawing.Size(254, 280);
            this.pbxAlumnos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxAlumnos.TabIndex = 2;
            this.pbxAlumnos.TabStop = false;
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.BackColor = System.Drawing.Color.Transparent;
            this.lblFiltro.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.Black;
            this.lblFiltro.Location = new System.Drawing.Point(38, 43);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(135, 21);
            this.lblFiltro.TabIndex = 0;
            this.lblFiltro.Text = "Búsqueda Rápida";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(194, 43);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(193, 28);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(38, 412);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(155, 21);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Busqueda Avanzada";
            // 
            // lblDanza
            // 
            this.lblDanza.AutoSize = true;
            this.lblDanza.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanza.Location = new System.Drawing.Point(39, 460);
            this.lblDanza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDanza.Name = "lblDanza";
            this.lblDanza.Size = new System.Drawing.Size(43, 17);
            this.lblDanza.TabIndex = 4;
            this.lblDanza.Text = "Danza";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 460);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Categoria";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cboDanza
            // 
            this.cboDanza.BackColor = System.Drawing.Color.HotPink;
            this.cboDanza.FormattingEnabled = true;
            this.cboDanza.Location = new System.Drawing.Point(105, 460);
            this.cboDanza.Margin = new System.Windows.Forms.Padding(4);
            this.cboDanza.Name = "cboDanza";
            this.cboDanza.Size = new System.Drawing.Size(118, 25);
            this.cboDanza.TabIndex = 6;
            // 
            // cboCategoria
            // 
            this.cboCategoria.BackColor = System.Drawing.Color.HotPink;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(350, 460);
            this.cboCategoria.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(128, 25);
            this.cboCategoria.TabIndex = 7;
            // 
            // btnBuscar2
            // 
            this.btnBuscar2.BackColor = System.Drawing.Color.HotPink;
            this.btnBuscar2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar2.Location = new System.Drawing.Point(506, 451);
            this.btnBuscar2.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar2.Name = "btnBuscar2";
            this.btnBuscar2.Size = new System.Drawing.Size(62, 35);
            this.btnBuscar2.TabIndex = 8;
            this.btnBuscar2.Text = "Buscar";
            this.btnBuscar2.UseVisualStyleBackColor = false;
            this.btnBuscar2.Click += new System.EventHandler(this.btnBuscar2_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.HotPink;
            this.btnRefresh.Location = new System.Drawing.Point(506, 493);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(62, 37);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1126, 547);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBuscar2);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.cboDanza);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDanza);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.pbxAlumnos);
            this.Controls.Add(this.dgvAlumno);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dirty Dancing";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAlumnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarAlumno;
        private System.Windows.Forms.ToolStripMenuItem eliminarAlumno;
        private System.Windows.Forms.DataGridView dgvAlumno;
        private System.Windows.Forms.PictureBox pbxAlumnos;
        private System.Windows.Forms.ToolStripMenuItem modificarAlumno;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDanza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDanza;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Button btnBuscar2;
        private System.Windows.Forms.Button btnRefresh;
    }
}

