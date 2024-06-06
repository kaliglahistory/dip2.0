namespace WinFormsApp1
{
    partial class desctop
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
            textBox1 = new TextBox();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(-2, 185);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(803, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "Что сохранить ?";
            // 
            // button1
            // 
            button1.Location = new Point(327, 264);
            button1.Name = "button1";
            button1.Size = new Size(120, 23);
            button1.TabIndex = 1;
            button1.Text = "Создать бекап";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1, 214);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(800, 23);
            textBox2.TabIndex = 2;
            textBox2.Text = "Куда сохранить ?";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(634, 342);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(120, 23);
            textBox3.TabIndex = 4;
            textBox3.Text = "Укажите адрес сервера ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(634, 371);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(120, 23);
            textBox4.TabIndex = 5;
            textBox4.Text = "порт";
            // 
            // button2
            // 
            button2.Location = new Point(634, 400);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 6;
            button2.Text = "Тест соеденения ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(634, 429);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(152, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Индекатор соеденения";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // desctop
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(button2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "desctop";
            Text = "desctop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private CheckBox checkBox1;
    }
}