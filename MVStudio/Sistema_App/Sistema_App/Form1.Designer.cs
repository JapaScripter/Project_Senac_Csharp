namespace Sistema_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TB_Email = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            TB_Senha = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            TB_ID = new TextBox();
            label3 = new Label();
            TB_Nome = new TextBox();
            SuspendLayout();
            // 
            // TB_Email
            // 
            TB_Email.Location = new Point(48, 119);
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new Size(150, 31);
            TB_Email.TabIndex = 0;
            TB_Email.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 91);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 1;
            label1.Text = "Email";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(48, 256);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 168);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // TB_Senha
            // 
            TB_Senha.Location = new Point(48, 196);
            TB_Senha.Name = "TB_Senha";
            TB_Senha.Size = new Size(150, 31);
            TB_Senha.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(197, 256);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(345, 256);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 6;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(492, 256);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 7;
            button4.Text = "Select";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // TB_ID
            // 
            TB_ID.Location = new Point(215, 57);
            TB_ID.Name = "TB_ID";
            TB_ID.PlaceholderText = "id";
            TB_ID.Size = new Size(150, 31);
            TB_ID.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 29);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 10;
            label3.Text = "Nome";
            // 
            // TB_Nome
            // 
            TB_Nome.Location = new Point(48, 57);
            TB_Nome.Name = "TB_Nome";
            TB_Nome.Size = new Size(150, 31);
            TB_Nome.TabIndex = 9;
            TB_Nome.TextChanged += textBox1_TextChanged_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 450);
            Controls.Add(label3);
            Controls.Add(TB_Nome);
            Controls.Add(TB_ID);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(TB_Senha);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(TB_Email);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Email;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox TB_Senha;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox TB_ID;
        private Label label3;
        private TextBox TB_Nome;
    }
}
