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
    public partial class frmTran : Form
    {
        public frmTran()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void frmTran_Load(object sender, EventArgs e)
        {
            crTransactions cr = new crTransactions();
            

            SqlConnection cn;
            SqlDataAdapter da;
            DataSet ds = new DataSet(); ;
            string conS = "data source=(local);initial catalog=Library;Integrated security=SSPI";
            cn = new SqlConnection(conS);

            string selectsql = "select TransactionID as TransactionID1,TransactionID.MemberID,BookID,LoanStatus,MemberName" +
                " from TransactionID left join Members on TransactionID.MemberID=Members.MemberID";

            da = new SqlDataAdapter(selectsql, cn);
            
            da.Fill(ds, "TransactionID");

            cr.SetDataSource(ds.Tables["TransactionID"]);
            cRVtran.ReportSource = cr;
        }
    }
}
