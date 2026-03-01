namespace WindowsFormsApp1
{
    partial class Loginform
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.usrID = new System.Windows.Forms.TextBox();
            this.usePass = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(115, 128);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(132, 32);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Arid No :";
          
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(115, 202);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(163, 32);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Password :";
            // 
            // usrID
            // 
            this.usrID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrID.Location = new System.Drawing.Point(253, 128);
            this.usrID.Name = "usrID";
            this.usrID.Size = new System.Drawing.Size(416, 39);
            this.usrID.TabIndex = 2;
            // 
            // usePass
            // 
            this.usePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usePass.Location = new System.Drawing.Point(284, 199);
            this.usePass.Name = "usePass";
            this.usePass.Size = new System.Drawing.Size(416, 39);
            this.usePass.TabIndex = 3;
            this.usePass.UseSystemPasswordChar = true;
           
            this.usePass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.usePass_KeyPress);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(262, 448);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(125, 59);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.set_Click);
            // 
            // Reset
            // 
            this.Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(436, 448);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(125, 59);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 662);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.usePass);
            this.Controls.Add(this.usrID);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "Loginform";
            this.Text = "Login";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox usrID;
        private System.Windows.Forms.TextBox usePass;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button Reset;
    }
}