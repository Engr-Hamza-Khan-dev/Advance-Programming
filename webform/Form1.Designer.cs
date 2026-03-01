namespace webform
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
            radioYes = new RadioButton();
            radioNo = new RadioButton();
            lblText = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            lbltext2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblDate = new Label();
            pictureBox1 = new PictureBox();
            comboGender = new ComboBox();
            lblGender = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // radioYes
            // 
            radioYes.AutoSize = true;
            radioYes.Location = new Point(24, 86);
            radioYes.Name = "radioYes";
            radioYes.Size = new Size(62, 29);
            radioYes.TabIndex = 0;
            radioYes.TabStop = true;
            radioYes.Text = "Yes";
            radioYes.UseVisualStyleBackColor = true;
            radioYes.CheckedChanged += RadioChange;
            // 
            // radioNo
            // 
            radioNo.AutoSize = true;
            radioNo.Location = new Point(25, 132);
            radioNo.Name = "radioNo";
            radioNo.Size = new Size(61, 29);
            radioNo.TabIndex = 1;
            radioNo.TabStop = true;
            radioNo.Text = "No";
            radioNo.UseVisualStyleBackColor = true;
            radioNo.CheckedChanged += RadioChange;
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(133, 104);
            lblText.Name = "lblText";
            lblText.Size = new Size(59, 25);
            lblText.TabIndex = 2;
            lblText.Text = "label1";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(222, 43);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(124, 29);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "Rawalpindi";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkChange;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(222, 78);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(120, 29);
            checkBox2.TabIndex = 4;
            checkBox2.Text = "Islamabad";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkChange;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(222, 113);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(94, 29);
            checkBox3.TabIndex = 5;
            checkBox3.Text = "Karachi";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkChange;
            // 
            // lbltext2
            // 
            lbltext2.AutoSize = true;
            lbltext2.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbltext2.Location = new Point(388, 84);
            lbltext2.Name = "lbltext2";
            lbltext2.Size = new Size(0, 30);
            lbltext2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(88, 160);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(180, 212);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(59, 25);
            lblDate.TabIndex = 8;
            lblDate.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(192, -34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(386, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // comboGender
            // 
            comboGender.DropDownStyle = ComboBoxStyle.DropDownList;
            comboGender.FormattingEnabled = true;
            comboGender.Location = new Point(146, 132);
            comboGender.Name = "comboGender";
            comboGender.Size = new Size(182, 33);
            comboGender.TabIndex = 10;
            comboGender.SelectedValueChanged += comboGender_SelectedValueChanged;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(62, 135);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(78, 25);
            lblGender.TabIndex = 11;
            lblGender.Text = "Gender :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(lblText);
            groupBox1.Controls.Add(lbltext2);
            groupBox1.Controls.Add(lblDate);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(radioYes);
            groupBox1.Controls.Add(radioNo);
            groupBox1.Location = new Point(137, 185);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(539, 253);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(lblGender);
            Controls.Add(comboGender);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioYes;
        private RadioButton radioNo;
        private Label lblText;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label lbltext2;
        private DateTimePicker dateTimePicker1;
        private Label lblDate;
        private PictureBox pictureBox1;
        private ComboBox comboGender;
        private Label lblGender;
        private GroupBox groupBox1;
    }
}
