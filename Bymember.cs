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
    public partial class Bymember : Form
    {
        Changesize cg = new Changesize();
        private ReturnBooks _form;
        private IssueReturn _form1;
       
        public Bymember()
        {
            InitializeComponent();
        }
        public Bymember(IssueReturn issueReturn)
        {
            InitializeComponent();
            _form1 = issueReturn;
        }

        public Bymember(ReturnBooks form) : this()
        {
            _form = form;
        }

 



        //ok buttton
        private void button1_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;

            string str = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            
            if(_form is null)
            _form1.UpdateTextBox(_form1.MIDTextBox, str);
            else _form.UpdateTextBox(_form.MIDTextBox, str);

            this.Close();

        }

        private void Bymember_Load(object sender, EventArgs e)
        {
            SqlConnection cn;
            SqlDataAdapter da;
            DataSet ds;
            string conS = "data source=(local);initial catalog=Library;Integrated security=SSPI";
            cn = new SqlConnection(conS);

            string selectsql = "select MemberID,MemberName,MemberType,Address from Members ";

            da = new SqlDataAdapter(selectsql, cn);

            ds = new DataSet();
            da.Fill(ds, "Members");

            dataGridView1.DataSource = ds.Tables["Members"];
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
    //public partial class Bymember : Form
    //{
    //    Changesize cg = new Changesize();
    //    private ReturnBooks _form;

    //    public Bymember()
    //    {
    //        InitializeComponent();
    //    }
    //    public Bymember(IssueReturn issueReturn)
    //    {
    //        InitializeComponent();
    //    }

    //    public Bymember(ReturnBooks form) : this()
    //    {
    //        _form = form;
    //    }
    }

