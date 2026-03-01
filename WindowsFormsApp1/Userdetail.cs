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
    public partial class Userdetail : Form
    {
        public Userdetail()
        {
            InitializeComponent();
        }

     


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string detail = "";
            string name=txtName.Text;
            string Id=txtId.Text;
            string address=txtAddress.Text;
            string age=txtAge.Text;
            if(!string.IsNullOrEmpty(name)&&
                !string.IsNullOrEmpty(Id)&&
                !string.IsNullOrEmpty(address)&&
                !string.IsNullOrEmpty(age))
            {
                detail = $"Name : {name}\nId : {Id}\nAddress : {address}\nAge : {age}";
                lblInfo.Text= detail ;
                lblInfo.Visible = true ;
            }
           else{
                MessageBox.Show("Please fill all the text boxes!");
            }
        }

      
    }
}
