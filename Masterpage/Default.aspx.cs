using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;
namespace Masterpage
{
    public partial class Default : System.Web.UI.Page
    {
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {

            ds= new DataSet();
            ds.ReadXml(Server.MapPath("Database.xml"));
            GridView1.DataSource=ds.Tables[0];
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(Server.MapPath("Database.xml"));

            XmlElement student= xmldoc.CreateElement("student");
            XmlElement name= xmldoc.CreateElement("name");
            name.InnerText = txtname.Text;

            XmlElement ID= xmldoc.CreateElement("ID");
            ID.InnerText = txtID.Text;
            XmlElement Degree= xmldoc.CreateElement("Degree");
            Degree.InnerText = txtdegree.Text;

            student.AppendChild(name);
            student.AppendChild(ID);
            student.AppendChild(Degree);

            xmldoc.DocumentElement.AppendChild(student);
            xmldoc.Save(Server.MapPath("Database.xml"));

            GridView1.DataSource = null;
            GridView1.DataSource = xmldoc.DocumentElement.ChildNodes;
            GridView1.DataBind();
        }
    }
}