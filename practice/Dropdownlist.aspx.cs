using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace practice
{
    public partial class Dropdownlist : System.Web.UI.Page
    {
        DataAccessLayer dal;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               dal = new DataAccessLayer();
                dal.DD(DropDownList1, "select countryid,name from country");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dal = new DataAccessLayer();
            dal.DD(DropDownList2, "select stateid,name from state where countryid=" + Convert.ToInt16(DropDownList1.SelectedValue));

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dal = new DataAccessLayer();
            dal.DD(DropDownList3, "Select cityid,name from city where stateid=" + Convert.ToInt16(DropDownList2.SelectedValue));
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
    }
}