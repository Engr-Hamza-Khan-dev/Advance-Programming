
using System.Data;
using Microsoft.Data.SqlClient;
namespace midpaper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton3.Checked = true;

            comboBox1.SelectedIndex = 2;
        }
        string colors;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                colors = radioButton1.Text;
                this.BackColor = Color.Red;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                colors = radioButton2.Text;
                this.BackColor = Color.Green;
                groupBox1.BackColor = Color.Red;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            colors = radioButton3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colors += " color";
            MessageBox.Show(colors, "Color", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Items.Contains(textBox1.Text))
            {
                label1.Text = "available";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox2.Text);
            comboBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = dateTimePicker1.Value.DayOfWeek.ToString();
            textBox4.Text = dateTimePicker1.Value.Month.ToString();
            textBox5.Text = dateTimePicker1.Value.Year.ToString();
            textBox6.Text = dateTimePicker1.Value.Subtract(dateTimePicker2.Value).Days.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Employee;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(con);
            sqlConnection.Open();
            string quory = "select * from employe;";
            SqlDataAdapter da = new SqlDataAdapter(quory, sqlConnection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string con = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Employee;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False;Command Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(con);
            sqlConnection.Open();
            string quory="INSERT INTO employe(id,name) values("+int.Parse(textBox7.Text)+",'"+textBox8.Text+"');";
            SqlCommand cmd=new SqlCommand(quory,sqlConnection);
            cmd.ExecuteNonQuery();

        }
    }
}
