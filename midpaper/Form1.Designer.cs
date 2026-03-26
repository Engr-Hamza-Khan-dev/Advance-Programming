namespace midpaper
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
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            button1 = new Button();
            radioButton3 = new RadioButton();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            textBox2 = new TextBox();
            groupBox3 = new GroupBox();
            dateTimePicker2 = new DateTimePicker();
            textBox6 = new TextBox();
            button5 = new Button();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button4 = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            button6 = new Button();
            button7 = new Button();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(237, 61);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 29);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Red";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(136, 61);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 29);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Blue";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(109, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(490, 133);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Bg-Color";
            // 
            // button1
            // 
            button1.Location = new Point(350, 56);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(26, 61);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(94, 29);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Defualt";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "hamza", "ali", "muhammad" });
            comboBox1.Location = new Point(11, 50);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(290, 33);
            comboBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(351, 52);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(213, 31);
            textBox1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(452, 95);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "check";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 86);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(98, 171);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(604, 210);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button3
            // 
            button3.Location = new Point(287, 142);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 8;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(23, 145);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 31);
            textBox2.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(textBox6);
            groupBox3.Controls.Add(button5);
            groupBox3.Controls.Add(textBox5);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(button4);
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Location = new Point(100, 395);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(754, 311);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Profile";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(35, 228);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 8;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(553, 228);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(150, 31);
            textBox6.TabIndex = 7;
            // 
            // button5
            // 
            button5.Location = new Point(403, 173);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 6;
            button5.Text = "show time";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(553, 176);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 5;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(553, 130);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(553, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 3;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(403, 30);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 2;
            // 
            // button4
            // 
            button4.Location = new Point(229, 141);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 1;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(53, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(121, 780);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(581, 225);
            dataGridView1.TabIndex = 9;
            // 
            // button6
            // 
            button6.Location = new Point(731, 780);
            button6.Name = "button6";
            button6.Size = new Size(112, 34);
            button6.TabIndex = 10;
            button6.Text = "Load";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(742, 946);
            button7.Name = "button7";
            button7.Size = new Size(112, 34);
            button7.TabIndex = 11;
            button7.Text = "insert";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(731, 836);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(150, 31);
            textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(731, 882);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(150, 31);
            textBox8.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 1027);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Button button2;
        private Label label1;
        private GroupBox groupBox2;
        private Button button3;
        private TextBox textBox2;
        private GroupBox groupBox3;
        private Button button4;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox4;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private Button button5;
        private TextBox textBox5;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView1;
        private Button button6;
        private Button button7;
        private TextBox textBox7;
        private TextBox textBox8;
    }
}
