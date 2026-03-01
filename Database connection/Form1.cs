
using System.Data;

using Microsoft.Data.SqlClient;
namespace Database_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Students;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=False";
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
            string quory = "select * from [Table];";
            SqlDataAdapter da = new SqlDataAdapter(quory, connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Students;Integrated Security=True;Pooling=False;Encrypt=True;Trust Server Certificate=False";
            SqlConnection connection = new SqlConnection(constr);
            connection.Open();
            string quory = "update [Table] set Name='"+textBox1.Text+"' where Name='"+textBox2.Text+"'";
            SqlCommand cmd = new SqlCommand(quory, connection);
            cmd.ExecuteNonQuery();
            MessageBox.Show("updated successfully");
        }
    }
}
