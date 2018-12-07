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
using ChangeSize;

namespace SA47_Team9B_UIDesignTemplate
{
    public partial class Bybook : Form
    {
        Changesize cg = new Changesize();
        private ReturnBooks _form;
        private IssueReturn _form1;


        public Bybook()
        {
            InitializeComponent();
        }

        public Bybook(ReturnBooks form) : this()
        {
            _form = form;
        }

        public Bybook(IssueReturn issueReturn)
        {
            InitializeComponent();
            _form1 = issueReturn;
        }

        private void Bybook_Load(object sender, EventArgs e)
        {
            SqlConnection cn;
            SqlDataAdapter da;
            DataSet ds;
            string conS = "data source=(local);initial catalog=Library;Integrated security=SSPI";
            cn = new SqlConnection(conS);

            string selectsql = "select BookID,BookTitle,Author,Quantity from Books";

            da = new SqlDataAdapter(selectsql, cn);

            ds = new DataSet();
            da.Fill(ds, "Books");

            dataGridView1.DataSource = ds.Tables["Books"];
            for (int i = 0; i < dataGridView1.ColumnCount; i++) 
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            this.Resize += new EventHandler(Form_Resize);
            cg.setTag(this);
            cg.X = this.Width;
            cg.Y = this.Height;
        }

        private void Form_Resize(object sender, EventArgs e)
        {
            float newx = (this.Width) / cg.X;
            float newy = (this.Height) / cg.Y;
            cg.setControls(newx, newy, this);
        }

        //OK button
        private void button1_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;

            string str = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            if (_form is null)
                _form1.UpdateTextBox(_form1.BIDTextBox, str);
            else _form.UpdateTextBox(_form.BIDTextBox, str);
            this.Close();

        }

        //exit button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
