namespace EFCore3Ferro.GUI
{
    partial class frmShoesAE
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
            label1 = new Label();
            btnaceptar = new Button();
            btncancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtprecio = new TextBox();
            txtdescripcion = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtmodel = new TextBox();
            cboBrands = new ComboBox();
            cboSports = new ComboBox();
            cboGenre = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 26);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 1;
            label1.Text = "Nuevo Shoe";
            // 
            // btnaceptar
            // 
            btnaceptar.Location = new Point(97, 201);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(97, 39);
            btnaceptar.TabIndex = 2;
            btnaceptar.Text = "aceptar";
            btnaceptar.UseVisualStyleBackColor = true;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(231, 201);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(97, 39);
            btncancelar.TabIndex = 3;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 108);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 4;
            label2.Text = "Sport";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 71);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "Brand";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 142);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "Genre";
            // 
            // txtprecio
            // 
            txtprecio.Location = new Point(295, 134);
            txtprecio.Name = "txtprecio";
            txtprecio.Size = new Size(100, 23);
            txtprecio.TabIndex = 14;
            txtprecio.KeyPress += txtprecio_KeyPress;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(295, 100);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(100, 23);
            txtdescripcion.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(218, 142);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 12;
            label5.Text = "Precio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(218, 71);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 11;
            label6.Text = "Model";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(218, 108);
            label7.Name = "label7";
            label7.Size = new Size(69, 15);
            label7.TabIndex = 10;
            label7.Text = "Descripcion";
            // 
            // txtmodel
            // 
            txtmodel.Location = new Point(295, 68);
            txtmodel.Name = "txtmodel";
            txtmodel.Size = new Size(100, 23);
            txtmodel.TabIndex = 9;
            // 
            // cboBrands
            // 
            cboBrands.FormattingEnabled = true;
            cboBrands.Location = new Point(73, 68);
            cboBrands.Name = "cboBrands";
            cboBrands.Size = new Size(121, 23);
            cboBrands.TabIndex = 15;
            cboBrands.SelectedIndexChanged += cboBrands_SelectedIndexChanged;
            // 
            // cboSports
            // 
            cboSports.FormattingEnabled = true;
            cboSports.Location = new Point(73, 105);
            cboSports.Name = "cboSports";
            cboSports.Size = new Size(121, 23);
            cboSports.TabIndex = 16;
            cboSports.SelectedIndexChanged += cboSports_SelectedIndexChanged;
            // 
            // cboGenre
            // 
            cboGenre.FormattingEnabled = true;
            cboGenre.Location = new Point(73, 142);
            cboGenre.Name = "cboGenre";
            cboGenre.Size = new Size(121, 23);
            cboGenre.TabIndex = 17;
            cboGenre.SelectedIndexChanged += cboGenre_SelectedIndexChanged;
            // 
            // frmShoesAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 278);
            Controls.Add(cboGenre);
            Controls.Add(cboSports);
            Controls.Add(cboBrands);
            Controls.Add(txtprecio);
            Controls.Add(txtdescripcion);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtmodel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btncancelar);
            Controls.Add(btnaceptar);
            Controls.Add(label1);
            Name = "frmShoesAE";
            Text = "frmShoesAE";
            Load += frmShoesAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnaceptar;
        private Button btncancelar;
        private ErrorProvider errorProvider1;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtprecio;
        private TextBox txtdescripcion;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtmodel;
        private ComboBox cboGenre;
        private ComboBox cboSports;
        private ComboBox cboBrands;
    }
}