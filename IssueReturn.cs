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
    public partial class IssueReturn : Form
    {


        public IssueReturn()
        {
            InitializeComponent();


        }
        //Issue button
        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection cn;
            SqlCommand cmInsertTransactionID;
            SqlCommand cmUpdBooks;

            cn = new SqlConnection("data source=(local);integrated security=SSPI;initial catalog=Library");
            cmInsertTransactionID = new SqlCommand();
            cmInsertTransactionID.Connection = cn;
            cmInsertTransactionID.CommandText = "Insert into TransactionID (BookID, MemberID, TransactionID,DateIssue, DateDue, LoanStatus) values (@BID, @MID, @TID,@DIE,@DDE,@LSS)";
            SqlParameter pBID = new SqlParameter("@BID", SqlDbType.SmallInt);
            SqlParameter pMID = new SqlParameter("@MID", SqlDbType.NVarChar, 4);
            SqlParameter pTID = new SqlParameter("@TID", SqlDbType.NVarChar, 255);
            SqlParameter pDIE = new SqlParameter("@DIE", SqlDbType.DateTime);
            SqlParameter pDDE = new SqlParameter("@DDE", SqlDbType.DateTime);
            SqlParameter pLSS = new SqlParameter("@LSS", SqlDbType.NVarChar, 3);
            SqlParameter[] pArr = new SqlParameter[] { pBID, pMID, pTID, pDIE, pDDE, pLSS };
            cmInsertTransactionID.Parameters.AddRange(pArr);

            //Update book qty in book list

            cmUpdBooks = new SqlCommand();
            cmUpdBooks.Connection = cn;
            cmUpdBooks.CommandText = "Update Books Set Quantity= Quantity-1 where BookID = @BID2";
            SqlParameter pBID2 = new SqlParameter("@BID2", SqlDbType.SmallInt);
            cmUpdBooks.Parameters.Add(pBID2);

            cn.Open();
            pBID.Value = Convert.ToInt16(BIDTextBox.Text);
            pMID.Value = MIDTextBox.Text.ToUpper();
            pTID.Value = 1;
            pBID2.Value = Convert.ToInt16(BIDTextBox.Text);
            pDIE.Value = DateTime.Now;
            pDDE.Value = DateTime.Now.AddDays(7);
            pLSS.Value = "Out".ToString();

            
                {
                cmInsertTransactionID.ExecuteNonQuery();
                cmUpdBooks.ExecuteNonQuery();
                cn.Close();
                }
            MessageBox.Show("Done");
        }
    

        

            private void button2_Click(object sender, EventArgs e)
            {
                Bymember bmm = new Bymember(this);
                bmm.ShowDialog();
            }

            private void button2_Click_1(object sender, EventArgs e)
            {
                Close();
            }

            private void IssueReturn_Load(object sender, EventArgs e)
            {

            }

            private void groupBox2_Enter(object sender, EventArgs e)
            {

            }

            private void groupBox1_Enter(object sender, EventArgs e)
            {

            }

            private void tidBox_TextChanged(object sender, EventArgs e)
            {

            }

            //look up by book code button
            private void button3_Click(object sender, EventArgs e)
            {
                Bybook form = new Bybook(this);
                form.ShowDialog();
            }

        public void UpdateTextBox(TextBox tb1, string newData)
        {
            tb1.Text = newData;
        }
    }

}

