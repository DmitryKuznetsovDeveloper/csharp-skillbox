namespace PracticalWork009
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
            MySplite = new Button();
            MyReverse = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // MySplite
            // 
            MySplite.Location = new Point(657, 263);
            MySplite.Name = "MySplite";
            MySplite.Size = new Size(200, 50);
            MySplite.TabIndex = 0;
            MySplite.Text = "Splite";
            MySplite.UseVisualStyleBackColor = true;
            MySplite.Click += Splite_Click;
            // 
            // MyReverse
            // 
            MyReverse.Location = new Point(657, 354);
            MyReverse.Name = "MyReverse";
            MyReverse.Size = new Size(200, 50);
            MyReverse.TabIndex = 1;
            MyReverse.Text = "Reverse";
            MyReverse.UseVisualStyleBackColor = true;
            MyReverse.Click += MyReverse_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 32;
            listBox1.Location = new Point(-1, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(500, 356);
            listBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(517, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(400, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(517, 36);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 4;
            label1.Text = "Ввод для Splite";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 389);
            label2.Name = "label2";
            label2.Size = new Size(72, 30);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(517, 129);
            label3.Name = "label3";
            label3.Size = new Size(158, 25);
            label3.TabIndex = 7;
            label3.Text = "Ввод для Reverse";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(517, 171);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(400, 23);
            textBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(MyReverse);
            Controls.Add(MySplite);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button MySplite;
        private Button MyReverse;
        private ListBox listBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
    }
}