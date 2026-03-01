using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hey Fsociety...";
            Textbox.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label1.Text = "Good byeeee...";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            label1.Text = "You are successfully logged in...";
            Loginform loginform = new Loginform();
            loginform.Show();
            this.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Hello Hamza";
            Textbox.Visible= false;
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Userdetail userdetail = new Userdetail();
            userdetail.Show();
        }
    }
}
