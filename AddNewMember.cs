using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SA47_Team9B_UIDesignTemplate
{
    public partial class AddNewMember : Form
    {
        string ContactTitle;


        SqlConnection con = new SqlConnection("data source = (local); integrated security = SSPI; initial catalog = Library ");

        public AddNewMember()
        {
            InitializeComponent();
        }
      
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && ContactTitle != "" && textBox3.Text != "" && comboBox2.Text != "" && textBox5.Text != "" && textBox6.Text != "" && comboBox1.Text != "")
            {
                con.Open();

                if (radioButton1.Checked)
                {
                    ContactTitle = "Ms.";
                }

                else if (radioButton2.Checked)
                {
                    ContactTitle = "Mr.";
                }

                else
                {
                    MessageBox.Show("Please Input Your Contact Type..");
                    return;
                }

                string sql = "Insert into Members(MemberID, ContactTitle, MemberName,MemberType, EmailAddress, Address,Country) Values('" + textBox1.Text + "','" + ContactTitle + "', '" + textBox3.Text + "','" + comboBox2.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "','" + comboBox1.Text + "')";
                SqlCommand cm = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cm);
                SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                DataSet das = new DataSet();
                da.Fill(das, "Members");
                MessageBox.Show("Data Inserted sucessfully");
            }

            else
            {
                MessageBox.Show("One or more Fields are Empty..!");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {

                e.Handled = false;
            }
            else
            {

                e.Handled = true;
                MessageBox.Show("Please Enter Alphanumeric Characters Only!");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {

                e.Handled = false;
            }
            else
            {

                e.Handled = true;
                MessageBox.Show("Please Enter Text Only");

            }
        }

        private void AddNewMember_Load(object sender, EventArgs e)
        {

        }
    }
}
