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
    public partial class Loginform : Form
    {
        public Loginform()
        {
            InitializeComponent();
        }

       
        private void set_Click(object sender, EventArgs e)
        {
            loginfunc();
           
        }

        public void loginfunc()
        {
            string id = usrID.Text.Trim();
            string pass = usePass.Text.Trim();
            if (id == "24-ARID-1044" && pass == "123")
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Your Id or Password is Incorrect");
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            reset();
        }
        public void reset()
        {
            usePass.Text = string.Empty;
            usrID.Text = string.Empty;
        }



      

        private void usePass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                loginfunc();
            }
            if(e.KeyChar == (char)(Keys.Escape))
            {
                reset();
            }
              
        }
    }
}
