namespace WindowsFormsApp1
{
    partial class Form1
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
            this.set = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Textbox = new System.Windows.Forms.Label();
            this.btnUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // set
            // 
            this.set.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.set.Location = new System.Drawing.Point(46, 487);
            this.set.Name = "set";
            this.set.Size = new System.Drawing.Size(125, 59);
            this.set.TabIndex = 0;
            this.set.Text = "SET";
            this.set.UseVisualStyleBackColor = true;
            this.set.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(220, 487);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(125, 59);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(783, 487);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(125, 59);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            // 
            // Textbox
            // 
            this.Textbox.BackColor = System.Drawing.SystemColors.Highlight;
            this.Textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Textbox.Enabled = false;
            this.Textbox.Location = new System.Drawing.Point(639, 218);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(269, 82);
            this.Textbox.TabIndex = 5;
            this.Textbox.Text = "hello my name us thus";
            this.Textbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUser
            // 
            this.btnUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUser.Location = new System.Drawing.Point(767, 349);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(141, 86);
            this.btnUser.TabIndex = 6;
            this.btnUser.Text = "User Detail";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 594);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.Textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.set);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button set;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Textbox;
        private System.Windows.Forms.Button btnUser;
    }
}

