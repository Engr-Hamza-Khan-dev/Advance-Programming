using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;
namespace practice
{
    public class DataAccessLayer
    {
        string connString;
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection conn;
        public DataAccessLayer() {
            connString = System.Configuration.ConfigurationManager.ConnectionStrings["DB"].ToString();
        }
        protected SqlConnection Opencon()
        {
            conn = new SqlConnection(connString);
            conn.Open();
            return conn;
        }
        public DataSet fillds(string query)
        {
            da = new SqlDataAdapter(query, Opencon());
            ds=new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void DD(DropDownList ddl,string query)
        {
            ddl.DataSource = fillds(query).Tables[0];
            ddl.DataValueField = ds.Tables[0].Columns[0].ToString();
            ddl.DataTextField = ds.Tables[0].Columns[1].ToString();
            ddl.DataBind();
            ddl.Items.Insert(0, new ListItem("--Select--", "0"));   
        }
    }
}