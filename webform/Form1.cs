namespace webform
{
    public partial class Form1 : Form
    {
        string[] gender = { "Male", "Female", "Gay" };
        public Form1()
        {
            InitializeComponent();
            comboGender.Items.AddRange(gender);

            
                groupBox1.Enabled = false;
           

        }

        private void RadioChange(object sender, EventArgs e)
        {
            if (radioYes.Checked)
            {
                lblText.Text = "Thanks";
            }
            else if (radioNo.Checked)
            {
                lblText.Text = "Goodbye";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkChange(object sender, EventArgs e)
        {
            string text = "";
            if (checkBox1.Checked)
            {

                text += "Rawalpindi\n";
                MessageBox.Show("Do you want to click", "helloo", MessageBoxButtons.YesNo);

            }
            if (checkBox2.Checked)
            {
                text += "Islamabad\n";
                MessageBox.Show("Do you want to click", "helloo", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2);
            }
            if (checkBox3.Checked)
            {
                text += "Karachi";
                MessageBox.Show("Do you want to click", "helloo", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            lbltext2.Text = text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDate.Text = dateTimePicker1.Value.ToString();
        }

        private void comboGender_SelectedValueChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }
    }
}
