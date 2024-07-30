namespace EFCoresFerro.Windows
{
    partial class frmDeporteAE
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
            textBox1 = new TextBox();
            label1 = new Label();
            btnaceptar = new Button();
            btncancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(133, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 61);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 1;
            label1.Text = "Nuevo Deporte";
            // 
            // btnaceptar
            // 
            btnaceptar.Location = new Point(91, 180);
            btnaceptar.Name = "btnaceptar";
            btnaceptar.Size = new Size(75, 23);
            btnaceptar.TabIndex = 2;
            btnaceptar.Text = "aceptar";
            btnaceptar.UseVisualStyleBackColor = true;
            btnaceptar.Click += btnaceptar_Click;
            // 
            // btncancelar
            // 
            btncancelar.Location = new Point(196, 180);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(75, 23);
            btncancelar.TabIndex = 3;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmDeporteAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 281);
            Controls.Add(btncancelar);
            Controls.Add(btnaceptar);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "frmDeporteAE";
            Text = "frmDeporteAE";
            Load += frmDeporteAE_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button btnaceptar;
        private Button btncancelar;
        private ErrorProvider errorProvider1;
    }
}