namespace WinFormsApp4
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            label9 = new Label();
            button1 = new Button();
            panel2 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label11 = new Label();
            richTextBox1 = new RichTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(103, 146);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 23);
            label1.TabIndex = 0;
            label1.Text = "Ögrenci AD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 193);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(164, 23);
            label2.TabIndex = 1;
            label2.Text = "Ögrenci SOYAD:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 252);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(188, 23);
            label3.TabIndex = 2;
            label3.Text = "Ögrenci Numarası:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(610, 146);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(63, 23);
            label4.TabIndex = 3;
            label4.Text = "VİZE:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(610, 210);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(63, 23);
            label5.TabIndex = 4;
            label5.Text = "Final:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(117, 302);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(122, 23);
            label6.TabIndex = 5;
            label6.Text = "Ögrenci TC:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(918, 146);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(67, 23);
            label7.TabIndex = 6;
            label7.Text = "Proje:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(891, 219);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(105, 23);
            label8.TabIndex = 7;
            label8.Text = "Ortalama:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(26, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1425, 120);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images;
            pictureBox1.Location = new Point(1051, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(359, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tempus Sans ITC", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(584, 25);
            label10.Name = "label10";
            label10.Size = new Size(236, 42);
            label10.TabIndex = 0;
            label10.Text = "Erdem Okulları";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1024, 219);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(68, 23);
            label9.TabIndex = 9;
            label9.Text = "label9";
            // 
            // button1
            // 
            button1.BackColor = Color.Cyan;
            button1.Location = new Point(119, 396);
            button1.Name = "button1";
            button1.Size = new Size(472, 119);
            button1.TabIndex = 11;
            button1.Text = "KAYDET!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.IndianRed;
            panel2.Location = new Point(2, 521);
            panel2.Name = "panel2";
            panel2.Size = new Size(1474, 105);
            panel2.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 146);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 30);
            textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(248, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 30);
            textBox2.TabIndex = 14;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(248, 252);
            maskedTextBox1.Mask = "(999) 000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(286, 30);
            maskedTextBox1.TabIndex = 15;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(248, 302);
            maskedTextBox2.Mask = "00000000000";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(286, 30);
            maskedTextBox2.TabIndex = 16;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // textBox3
            // 
            textBox3.Location = new Point(682, 146);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 30);
            textBox3.TabIndex = 17;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(682, 212);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(200, 30);
            textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(994, 146);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(245, 30);
            textBox5.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(248, 360);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(286, 30);
            dateTimePicker1.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(104, 360);
            label11.Name = "label11";
            label11.Size = new Size(135, 23);
            label11.TabIndex = 21;
            label11.Text = "DogumGünü:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(610, 280);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(852, 235);
            richTextBox1.TabIndex = 22;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(1482, 630);
            Controls.Add(richTextBox1);
            Controls.Add(label11);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "ÖgrenciBilgiSistemi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Panel panel1;
        private Label label9;
        private Button button1;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Label label10;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
        private Label label11;
        private RichTextBox richTextBox1;
    }
}
