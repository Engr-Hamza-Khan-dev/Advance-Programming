namespace Listbox
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
            listBox1 = new ListBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            listBox2 = new ListBox();
            addBtn = new Button();
            removeBtn = new Button();
            AddallBtn = new Button();
            RemoveallBtn = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            FinalizeBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(135, 176);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(273, 279);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(551, 101);
            button1.Name = "button1";
            button1.Size = new Size(182, 34);
            button1.TabIndex = 1;
            button1.Text = "Add New Course";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(241, 101);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(283, 31);
            textBox1.TabIndex = 2;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(266, 28);
            label1.Name = "label1";
            label1.Size = new Size(348, 38);
            label1.TabIndex = 3;
            label1.Text = "Courses Offer In Summer";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(640, 176);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(277, 279);
            listBox2.TabIndex = 4;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(457, 194);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(112, 34);
            addBtn.TabIndex = 5;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // removeBtn
            // 
            removeBtn.Location = new Point(457, 247);
            removeBtn.Name = "removeBtn";
            removeBtn.Size = new Size(112, 34);
            removeBtn.TabIndex = 6;
            removeBtn.Text = "Remove";
            removeBtn.UseVisualStyleBackColor = true;
            removeBtn.Click += removeBtn_Click;
            // 
            // AddallBtn
            // 
            AddallBtn.Location = new Point(457, 301);
            AddallBtn.Name = "AddallBtn";
            AddallBtn.Size = new Size(112, 34);
            AddallBtn.TabIndex = 7;
            AddallBtn.Text = "Add All";
            AddallBtn.UseVisualStyleBackColor = true;
            AddallBtn.Click += AddallBtn_Click;
            // 
            // RemoveallBtn
            // 
            RemoveallBtn.Location = new Point(457, 358);
            RemoveallBtn.Name = "RemoveallBtn";
            RemoveallBtn.Size = new Size(112, 34);
            RemoveallBtn.TabIndex = 8;
            RemoveallBtn.Text = "Remove All";
            RemoveallBtn.UseVisualStyleBackColor = true;
            RemoveallBtn.Click += RemoveallBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(135, 562);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(782, 227);
            dataGridView1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(135, 519);
            label3.Name = "label3";
            label3.Size = new Size(285, 30);
            label3.TabIndex = 11;
            label3.Text = "The Data Will Be Show Here";
            // 
            // FinalizeBtn
            // 
            FinalizeBtn.Location = new Point(457, 414);
            FinalizeBtn.Name = "FinalizeBtn";
            FinalizeBtn.Size = new Size(112, 34);
            FinalizeBtn.TabIndex = 12;
            FinalizeBtn.Text = "Finalize";
            FinalizeBtn.UseVisualStyleBackColor = true;
            FinalizeBtn.Click += FinalizeBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1101, 822);
            Controls.Add(FinalizeBtn);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(RemoveallBtn);
            Controls.Add(AddallBtn);
            Controls.Add(removeBtn);
            Controls.Add(addBtn);
            Controls.Add(listBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Courses Selection";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private ListBox listBox2;
        private Button addBtn;
        private Button removeBtn;
        private Button AddallBtn;
        private Button RemoveallBtn;
        private DataGridView dataGridView1;
        private Label label3;
        private Button FinalizeBtn;
    }
}
