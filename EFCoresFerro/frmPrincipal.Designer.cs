namespace EFCoresFerro.Windows
{
    partial class frmPrincipal
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            label1 = new Label();
            label2 = new Label();
            btnshoeSize = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(123, 74);
            button1.Name = "button1";
            button1.Size = new Size(90, 91);
            button1.TabIndex = 0;
            button1.Text = "Brands";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(365, 74);
            button2.Name = "button2";
            button2.Size = new Size(90, 91);
            button2.TabIndex = 1;
            button2.Text = "Sports";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(244, 74);
            button3.Name = "button3";
            button3.Size = new Size(90, 91);
            button3.TabIndex = 2;
            button3.Text = "Genre";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(490, 74);
            button4.Name = "button4";
            button4.Size = new Size(90, 91);
            button4.TabIndex = 3;
            button4.Text = "Colors";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(608, 74);
            button5.Name = "button5";
            button5.Size = new Size(90, 91);
            button5.TabIndex = 4;
            button5.Text = "Shoes";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(608, 211);
            button6.Name = "button6";
            button6.Size = new Size(90, 91);
            button6.TabIndex = 9;
            button6.Text = "Zapatilla";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.Location = new Point(244, 211);
            button8.Name = "button8";
            button8.Size = new Size(90, 91);
            button8.TabIndex = 7;
            button8.Text = "Genero";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(365, 211);
            button9.Name = "button9";
            button9.Size = new Size(90, 91);
            button9.TabIndex = 6;
            button9.Text = "Deporte";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(123, 211);
            button10.Name = "button10";
            button10.Size = new Size(90, 91);
            button10.TabIndex = 5;
            button10.Text = "Marca";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 112);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 10;
            label1.Text = "EFCore 3 ferro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 249);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 11;
            label2.Text = "EFCore 2 ferro";
            // 
            // btnshoeSize
            // 
            btnshoeSize.Location = new Point(713, 74);
            btnshoeSize.Name = "btnshoeSize";
            btnshoeSize.Size = new Size(90, 91);
            btnshoeSize.TabIndex = 12;
            btnshoeSize.Text = "ShoeSize";
            btnshoeSize.UseVisualStyleBackColor = true;
            btnshoeSize.Click += btnshoeSize_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnshoeSize);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button9;
        private Button button10;
        private Label label1;
        private Label label2;
        private Button btnshoeSize;
    }
}