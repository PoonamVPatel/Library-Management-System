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
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            {
                //Specifying SQL String:

                string conS = "data source=(local);integrated security=SSPI;initial catalog=Library";
                SqlConnection cn = new SqlConnection(conS);

                //Constructing command object

                SqlCommand cm = new SqlCommand();
                cm.CommandText ="Insert into Books(BookID, BookTitle, Price, Quantity) Values ('" + BIDTextBox.Text + "','" + BTTextBox.Text + "','"+3+"'.'"+4+"')";
                cm.Connection = cn;

                cn.Open();
                cm.ExecuteNonQuery();
                cn.Close();
            }
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {

        }
    }
}
