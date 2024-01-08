namespace WOTBlitz_Statistics
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            button3 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(115, 67);
            button1.Name = "button1";
            button1.Size = new Size(100, 24);
            button1.TabIndex = 0;
            button1.Text = "Обновить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(7, 33);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(16, 14);
            label1.Name = "label1";
            label1.Size = new Size(78, 16);
            label1.TabIndex = 4;
            label1.Text = "Кол-во боёв";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(7, 67);
            button2.Name = "button2";
            button2.Size = new Size(100, 25);
            button2.TabIndex = 7;
            button2.Text = "Сессия";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(120, 14);
            label2.Name = "label2";
            label2.Size = new Size(93, 16);
            label2.TabIndex = 9;
            label2.Text = "Процент побед";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(115, 33);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.Location = new Point(221, 67);
            button3.Name = "button3";
            button3.Size = new Size(100, 24);
            button3.TabIndex = 0;
            button3.Text = "Подробно";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(221, 33);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(226, 14);
            label3.Name = "label3";
            label3.Size = new Size(87, 16);
            label3.TabIndex = 9;
            label3.Text = "Средний урон";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 102);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "WOTBlitz Statistics";
            Load += form1_load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Label label2;
        private TextBox textBox2;
        private Button button3;
        private TextBox textBox3;
        private Label label3;
    }
}
