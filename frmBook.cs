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
    public partial class frmBook : Form
    {
        public frmBook()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmBook_Load(object sender, EventArgs e)
        {

            crBook cr = new crBook();

            SqlConnection cn;
            SqlDataAdapter da;
            DataSet ds;
            string conS = "data source=(local);initial catalog=Library;Integrated security=SSPI";
            cn = new SqlConnection(conS);

            string selectsql = "select *  from Books";

            da = new SqlDataAdapter(selectsql, cn);

            ds = new DataSet();
            da.Fill(ds, "Books");
     
            cr.SetDataSource(ds.Tables["Books"]);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
