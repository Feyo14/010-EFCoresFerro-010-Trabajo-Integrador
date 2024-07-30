namespace EFCoreFerro2.GUI
{
    partial class frmZapa
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
            components = new System.ComponentModel.Container();
            dgvDatos = new DataGridView();
            Zapatilla = new DataGridViewTextBoxColumn();
            Marca = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Deporte = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            toolStrip2 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripDropDownButton();
            porTipoDeEnvaseToolStripMenuItem = new ToolStripMenuItem();
            ComboMarca = new ToolStripComboBox();
            toolStripMenuItem1 = new ToolStripMenuItem();
            ComboGenero = new ToolStripComboBox();
            toolStripMenuItem2 = new ToolStripMenuItem();
            ComboDeporte = new ToolStripComboBox();
            toolStripTextBox1 = new ToolStripTextBox();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            tsbOrden = new ToolStripDropDownButton();
            menorPrecioToolStripMenuItem = new ToolStripMenuItem();
            txtmin = new ToolStripTextBox();
            mayorPrecioToolStripMenuItem = new ToolStripMenuItem();
            txtMax = new ToolStripTextBox();
            filtrarEntre2PreciosToolSt = new ToolStripMenuItem();
            TsbPrecios = new ToolStripTextBox();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbCerrar = new ToolStripButton();
            txtCantidadRegistros = new TextBox();
            cboPaginas = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            btnUltimo = new Button();
            btnSiguiente = new Button();
            btnAnterior = new Button();
            btnPrimero = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { Zapatilla, Marca, Genero, Deporte, Price });
            dgvDatos.Dock = DockStyle.Fill;
            dgvDatos.Location = new Point(0, 0);
            dgvDatos.MultiSelect = false;
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowHeadersVisible = false;
            dgvDatos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDatos.Size = new Size(800, 228);
            dgvDatos.TabIndex = 1;
            // 
            // Zapatilla
            // 
            Zapatilla.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Zapatilla.HeaderText = "zapatilla";
            Zapatilla.Name = "Zapatilla";
            Zapatilla.ReadOnly = true;
            // 
            // Marca
            // 
            Marca.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Marca.HeaderText = "Marca";
            Marca.Name = "Marca";
            Marca.ReadOnly = true;
            // 
            // Genero
            // 
            Genero.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Genero.HeaderText = "Genero";
            Genero.Name = "Genero";
            Genero.ReadOnly = true;
            // 
            // Deporte
            // 
            Deporte.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Deporte.HeaderText = "Deporte";
            Deporte.Name = "Deporte";
            Deporte.ReadOnly = true;
            // 
            // Price
            // 
            Price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Price.HeaderText = "Price";
            Price.Name = "Price";
            Price.ReadOnly = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtCantidadRegistros);
            splitContainer1.Panel2.Controls.Add(cboPaginas);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(btnUltimo);
            splitContainer1.Panel2.Controls.Add(btnSiguiente);
            splitContainer1.Panel2.Controls.Add(btnAnterior);
            splitContainer1.Panel2.Controls.Add(btnPrimero);
            splitContainer1.Size = new Size(800, 311);
            splitContainer1.SplitterDistance = 257;
            splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(toolStrip2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(dgvDatos);
            splitContainer2.Size = new Size(800, 257);
            splitContainer2.SplitterDistance = 25;
            splitContainer2.TabIndex = 2;
            // 
            // toolStrip2
            // 
            toolStrip2.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator2, toolStripSeparator4, tsbOrden, toolStripSeparator3, tsbCerrar });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(800, 25);
            toolStrip2.TabIndex = 1;
            toolStrip2.Text = "toolStrip2";
            // 
            // tsbNuevo
            // 
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 22);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(43, 22);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBorrar.Click += tsbBorrar_Click;
            // 
            // tsbEditar
            // 
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(41, 22);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbEditar.Click += tsbEditar_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.DropDownItems.AddRange(new ToolStripItem[] { porTipoDeEnvaseToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, toolStripTextBox1 });
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(50, 22);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // porTipoDeEnvaseToolStripMenuItem
            // 
            porTipoDeEnvaseToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ComboMarca });
            porTipoDeEnvaseToolStripMenuItem.Name = "porTipoDeEnvaseToolStripMenuItem";
            porTipoDeEnvaseToolStripMenuItem.Size = new Size(160, 22);
            porTipoDeEnvaseToolStripMenuItem.Text = "Por Marca";
            // 
            // ComboMarca
            // 
            ComboMarca.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboMarca.Name = "ComboMarca";
            ComboMarca.Size = new Size(121, 23);
            ComboMarca.SelectedIndexChanged += ComboMarca_SelectedIndexChanged;
            ComboMarca.Click += tcboTiposDeEnvases_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { ComboGenero });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(160, 22);
            toolStripMenuItem1.Text = "Por Genero";
            // 
            // ComboGenero
            // 
            ComboGenero.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboGenero.Name = "ComboGenero";
            ComboGenero.Size = new Size(121, 23);
            ComboGenero.SelectedIndexChanged += ComboGenero_SelectedIndexChanged;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { ComboDeporte });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(160, 22);
            toolStripMenuItem2.Text = "Por Deporte";
            // 
            // ComboDeporte
            // 
            ComboDeporte.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboDeporte.Name = "ComboDeporte";
            ComboDeporte.Size = new Size(121, 23);
            ComboDeporte.SelectedIndexChanged += ComboDeporte_SelectedIndexChanged;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.BackColor = Color.Bisque;
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.ReadOnly = true;
            toolStripTextBox1.ShortcutsEnabled = false;
            toolStripTextBox1.Size = new Size(100, 23);
            toolStripTextBox1.Text = "ReiniciarFiltro";
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // tsbActualizar
            // 
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 22);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbActualizar.Click += tsbActualizar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 25);
            // 
            // tsbOrden
            // 
            tsbOrden.DropDownItems.AddRange(new ToolStripItem[] { menorPrecioToolStripMenuItem, mayorPrecioToolStripMenuItem, filtrarEntre2PreciosToolSt, TsbPrecios });
            tsbOrden.ImageScaling = ToolStripItemImageScaling.None;
            tsbOrden.ImageTransparentColor = Color.Magenta;
            tsbOrden.Name = "tsbOrden";
            tsbOrden.Size = new Size(143, 22);
            tsbOrden.Text = "Ordenar entre 2 Precios";
            tsbOrden.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menorPrecioToolStripMenuItem
            // 
            menorPrecioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { txtmin });
            menorPrecioToolStripMenuItem.Name = "menorPrecioToolStripMenuItem";
            menorPrecioToolStripMenuItem.Size = new Size(184, 22);
            menorPrecioToolStripMenuItem.Text = "Menor Precio";
            // 
            // txtmin
            // 
            txtmin.Name = "txtmin";
            txtmin.Size = new Size(100, 23);
            txtmin.KeyPress += txtmin_KeyPress;
            txtmin.TextChanged += toolStripTextBox2_TextChanged;
            // 
            // mayorPrecioToolStripMenuItem
            // 
            mayorPrecioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { txtMax });
            mayorPrecioToolStripMenuItem.Name = "mayorPrecioToolStripMenuItem";
            mayorPrecioToolStripMenuItem.Size = new Size(184, 22);
            mayorPrecioToolStripMenuItem.Text = "Mayor Precio";
            // 
            // txtMax
            // 
            txtMax.Name = "txtMax";
            txtMax.Size = new Size(100, 23);
            txtMax.TextChanged += toolStripTextBox3_TextChanged;
            // 
            // filtrarEntre2PreciosToolSt
            // 
            filtrarEntre2PreciosToolSt.BackColor = SystemColors.Highlight;
            filtrarEntre2PreciosToolSt.Name = "filtrarEntre2PreciosToolSt";
            filtrarEntre2PreciosToolSt.Size = new Size(184, 22);
            filtrarEntre2PreciosToolSt.Text = "Filtrar Entre 2 Precios";
            filtrarEntre2PreciosToolSt.Click += filtrarEntre2PreciosToolSt_Click;
            // 
            // TsbPrecios
            // 
            TsbPrecios.BackColor = Color.Bisque;
            TsbPrecios.Name = "TsbPrecios";
            TsbPrecios.Size = new Size(100, 23);
            TsbPrecios.Text = "Borrar Precios";
            TsbPrecios.Click += TsbPrecios_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 25);
            // 
            // tsbCerrar
            // 
            tsbCerrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbCerrar.ImageTransparentColor = Color.Magenta;
            tsbCerrar.Name = "tsbCerrar";
            tsbCerrar.Size = new Size(33, 22);
            tsbCerrar.Text = "Salir";
            tsbCerrar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbCerrar.Click += tsbCerrar_Click;
            // 
            // txtCantidadRegistros
            // 
            txtCantidadRegistros.Location = new Point(178, 8);
            txtCantidadRegistros.Name = "txtCantidadRegistros";
            txtCantidadRegistros.ReadOnly = true;
            txtCantidadRegistros.Size = new Size(85, 23);
            txtCantidadRegistros.TabIndex = 11;
            // 
            // cboPaginas
            // 
            cboPaginas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPaginas.FormattingEnabled = true;
            cboPaginas.Location = new Point(75, 8);
            cboPaginas.Name = "cboPaginas";
            cboPaginas.Size = new Size(68, 23);
            cboPaginas.TabIndex = 10;
            cboPaginas.SelectedIndexChanged += cboPaginas_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 11);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 8;
            label2.Text = "de:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 11);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 9;
            label1.Text = "Pág.:";
            // 
            // btnUltimo
            // 
            btnUltimo.Location = new Point(693, 3);
            btnUltimo.Name = "btnUltimo";
            btnUltimo.Size = new Size(75, 41);
            btnUltimo.TabIndex = 4;
            btnUltimo.Text = "--->";
            btnUltimo.UseVisualStyleBackColor = true;
            btnUltimo.Click += btnUltimo_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(612, 3);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 41);
            btnSiguiente.TabIndex = 5;
            btnSiguiente.Text = "->";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnAnterior
            // 
            btnAnterior.Location = new Point(531, 3);
            btnAnterior.Name = "btnAnterior";
            btnAnterior.Size = new Size(75, 41);
            btnAnterior.TabIndex = 6;
            btnAnterior.Text = "<-";
            btnAnterior.UseVisualStyleBackColor = true;
            btnAnterior.Click += btnAnterior_Click;
            // 
            // btnPrimero
            // 
            btnPrimero.Location = new Point(450, 3);
            btnPrimero.Name = "btnPrimero";
            btnPrimero.Size = new Size(75, 41);
            btnPrimero.TabIndex = 7;
            btnPrimero.Text = "<---";
            btnPrimero.UseVisualStyleBackColor = true;
            btnPrimero.Click += btnPrimero_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmZapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 311);
            Controls.Add(splitContainer1);
            Name = "frmZapa";
            Text = "frmZapa";
            Load += frmZapa_Load;
            KeyPress += frmZapa_KeyPress;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDatos;
        private SplitContainer splitContainer1;
        private TextBox txtCantidadRegistros;
        private ComboBox cboPaginas;
        private Label label2;
        private Label label1;
        private Button btnUltimo;
        private Button btnSiguiente;
        private Button btnAnterior;
        private Button btnPrimero;
        private SplitContainer splitContainer2;
        private ToolStrip toolStrip2;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tsbFiltrar;
        private ToolStripMenuItem porTipoDeEnvaseToolStripMenuItem;
        private ToolStripComboBox ComboMarca;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripComboBox ComboGenero;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripComboBox ComboDeporte;
        private ToolStripButton tsbActualizar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripDropDownButton tsbOrden;
        private ToolStripMenuItem menorPrecioToolStripMenuItem;
        private ToolStripMenuItem mayorPrecioToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton tsbCerrar;
        private DataGridViewTextBoxColumn Zapatilla;
        private DataGridViewTextBoxColumn Marca;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Deporte;
        private DataGridViewTextBoxColumn Price;
        private ToolStripTextBox toolStripTextBox1;
        private ToolStripTextBox txtmin;
        private ToolStripTextBox txtMax;
        private ToolStripMenuItem filtrarEntre2PreciosToolSt;
        private ErrorProvider errorProvider1;
        private ToolStripTextBox TsbPrecios;
    }
}