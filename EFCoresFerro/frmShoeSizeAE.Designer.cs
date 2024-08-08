namespace EFCore3Ferro.GUI
{
    partial class frmShoeSizeAE
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
            label6 = new Label();
            cboShoe = new ComboBox();
            cboSize = new ComboBox();
            txtQuantityInStock = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 26);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Nuevo ShoeSize";
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
            label2.Size = new Size(27, 15);
            label2.TabIndex = 4;
            label2.Text = "Size";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 71);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 5;
            label3.Text = "Shoe";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(197, 71);
            label6.Name = "label6";
            label6.Size = new Size(92, 15);
            label6.TabIndex = 11;
            label6.Text = "QuantityInStock";
            // 
            // cboShoe
            // 
            cboShoe.FormattingEnabled = true;
            cboShoe.Location = new Point(57, 68);
            cboShoe.Name = "cboShoe";
            cboShoe.Size = new Size(121, 23);
            cboShoe.TabIndex = 15;
            cboShoe.SelectedIndexChanged += cboShoe_SelectedIndexChanged;
            cboShoe.KeyPress += cboShoe_KeyPress;
            // 
            // cboSize
            // 
            cboSize.FormattingEnabled = true;
            cboSize.Location = new Point(57, 108);
            cboSize.Name = "cboSize";
            cboSize.Size = new Size(121, 23);
            cboSize.TabIndex = 16;
            cboSize.SelectedIndexChanged += cboSize_SelectedIndexChanged;
            cboSize.KeyPress += cboSize_KeyPress;
            // 
            // txtQuantityInStock
            // 
            txtQuantityInStock.Location = new Point(295, 68);
            txtQuantityInStock.Name = "txtQuantityInStock";
            txtQuantityInStock.Size = new Size(100, 23);
            txtQuantityInStock.TabIndex = 17;
            // 
            // frmShoeSizeAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 278);
            Controls.Add(txtQuantityInStock);
            Controls.Add(cboSize);
            Controls.Add(cboShoe);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btncancelar);
            Controls.Add(btnaceptar);
            Controls.Add(label1);
            Name = "frmShoeSizeAE";
            Text = "frmShoeSizeAE";
            Load += frmShoeSizeAE_Load;
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
        private ComboBox cboShoe;
        private TextBox txt;
        private ComboBox cboSize;
        private TextBox txtQuantityInStock;
    }
}