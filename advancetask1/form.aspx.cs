using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace advancetask1
{
    public partial class form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string text="";
            text+=lblfullname.Text;
            text += txtbox.Text;
            text += "<br>";
            text += lblGender.Text;
            if (RadioButton1.Checked)
            {
                text += RadioButton1.Text;
            }
            else
            {
                text += RadioButton2.Text;
            }
            text += "<br>";
            text += lblhobbies.Text;
            if (CheckBox1.Checked)
            {
                text += CheckBox1.Text;
            }
            else if (CheckBox2.Checked)
            {
                text += CheckBox2.Text;
            }
            else if (CheckBox3.Checked)
            {
                text+= CheckBox3.Text;
            }

            Label1.Text = text;
        }
    }
}