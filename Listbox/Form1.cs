using System.Data;

namespace Listbox
{
    public partial class Form1 : Form
    {
        private DataTable dt = new DataTable();
        private DataTable dt2 = new DataTable();
        public Form1()
        {
            InitializeComponent();
            
        }
        private int i = 8;
        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            dt.Rows.Add(i++,name,i+" months");
            textBox1.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string name = textBox1.Text;
                dt.Rows.Add(i++, name, i + " months");
                textBox1.Text = "";
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                dt2.ImportRow(dt.Rows[listBox1.SelectedIndex]);
                dt.Rows[listBox1.SelectedIndex].Delete();
            }
        }
        private void removeBtn_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                dt.ImportRow(dt2.Rows[listBox2.SelectedIndex]);
                dt2.Rows[listBox2.SelectedIndex].Delete();
            }
        }

        private void AddallBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                int count=dt.Rows.Count;
                for (int i= count-1; i>=0; i-- )
                {
                    dt2.ImportRow(dt.Rows[listBox1.SelectedIndex]);
                    dt.Rows[listBox1.SelectedIndex].Delete();
                }
            }
        }

        private void RemoveallBtn_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Count > 0)
            {
                int count = dt2.Rows.Count;
                for (int i = count - 1; i >= 0; i--)
                {
                    dt.ImportRow(dt2.Rows[listBox2.SelectedIndex]);
                    dt2.Rows[listBox2.SelectedIndex].Delete();
                }
            }
        }

        private void FinalizeBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You sure", "Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                dataGridView1.DataSource = dt2;
                dataGridView1.Enabled=false;
                dataGridView1.Columns[0].Visible=false;
                dataGridView1.RowHeadersVisible=false;
                dataGridView1.Columns[1].Width = 500;
                dataGridView1.Columns[2].Width = 500;
            }
            else
            {
                MessageBox.Show("Please Select at least one course","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void selectcourses()
        {
            dt2.Columns.Add("Course ID", typeof(int));
            dt2.Columns.Add("Course Name");
            dt2.Columns.Add("Course Duration");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            courses();
            selectcourses();

            listBox1.DataSource = dt;
            listBox1.DisplayMember = "Course Name";

            listBox2.DataSource = dt2;
            listBox2.DisplayMember = "Course Name";
        }
        private void courses()
        {
            dt.Columns.Add("Course ID", typeof(int));
            dt.Columns.Add("Course Name");
            dt.Columns.Add("Course Duration");

            dt.Rows.Add(1, "Advance Programming", "4 Months");
            dt.Rows.Add(2, "Data Stucture", "5 Months");
            dt.Rows.Add(3, "Database", "3 Months");
            dt.Rows.Add(4, "English", "2 Months");
            dt.Rows.Add(5, "Web Technologies", "4 Months");
            dt.Rows.Add(6, "ICT", "4 Months");
            dt.Rows.Add(7, "Linear Algebra", "4 Months");
        }
    }
}
