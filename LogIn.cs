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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string staffid = textBox1.Text;
            string password = textBox2.Text;
            string conS = "data source=(local);integrated security=SSPI;initial catalog=Library";

            SqlConnection cn = new SqlConnection(conS);
            cn.Open();

            string selectsql = "select * from Staff where StaffID='" + staffid
                   + "' and Password='" + password + "'";
            SqlCommand cm = new SqlCommand(selectsql, cn);

            //establish DataAdapter and DataSet
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataSet ds = new DataSet();

            //search data in DB
            int n = da.Fill(ds, "Staff");
            if (n != 0)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                this.Hide();//hide login form
                main main = new main();
                main.ShowDialog();//pop out main screen
            }
            else
            {
                MessageBox.Show("username or password is wrong,input again!");
                textBox1.Text = "";
                textBox2.Text = "";
            }

            cn.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
