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
    public partial class EditMemberDetails : Form
    {
        SqlConnection con = new SqlConnection("data source = (local); integrated security = SSPI; initial catalog = Library ");

        public EditMemberDetails()
        {
            InitializeComponent();
        }

        private void EditMemberDetails_Load_1(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox3.Enabled = true;
            textBox2.Enabled = false;

            textBox4.Enabled = true;
            textBox7.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            string sql = ("Update Members set MemberName = '" + textBox3.Text + "', MemberType='" + textBox4.Text + "', EmailAddress='"+textBox5.Text+"', Address='" + textBox6.Text + "',Country='" + textBox7.Text +"'  Where MemberId ='"+textBox1.Text+"' ");
            SqlCommand cm = new SqlCommand(sql, con);
            SqlDataAdapter da = new SqlDataAdapter(cm);
            SqlCommandBuilder cmb = new SqlCommandBuilder(da);
            DataSet das = new DataSet();
            da.Fill(das, "Members");
            MessageBox.Show("Data Updated Successfully");

        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Please Enter Text only");
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space)
            {

                e.Handled = false;
            }
            else
            {

                e.Handled = true;
                MessageBox.Show("Please Enter Text only");
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
