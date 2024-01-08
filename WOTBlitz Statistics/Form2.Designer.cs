namespace WOTBlitz_Statistics
{
    partial class Form2
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(61, 16);
            label1.TabIndex = 0;
            label1.Text = "Никнейм";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(75, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(231, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(78, 16);
            label2.TabIndex = 0;
            label2.Text = "Кол-во боёв";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox2.Location = new Point(8, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(87, 23);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(103, 40);
            label3.Name = "label3";
            label3.Size = new Size(93, 16);
            label3.TabIndex = 0;
            label3.Text = "Процент побед";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(106, 59);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(87, 23);
            textBox3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(214, 40);
            label4.Name = "label4";
            label4.Size = new Size(67, 16);
            label4.TabIndex = 0;
            label4.Text = "Сред. урон";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI Variable Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(205, 59);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(87, 23);
            textBox4.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 416);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            ShowIcon = false;
            Text = "Подробности";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
    }
}