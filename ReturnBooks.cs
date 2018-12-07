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
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }

        //return book button
        private void button1_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            var q = context.TransactionIDs.ToList();
            bool tag = false;

            //Loop through the transaction table
            foreach (var item in q)
            {
                //Only  match the bookid and the memberid can be naturalized
                if (item.BookID.ToString() == BIDTextBox.Text && item.MemberID == MIDTextBox.Text
                    && item.LoanStatus == "Out")
                {
                    SqlConnection cn;
                    SqlCommand cmInsertTransactionID;
                    SqlCommand cmUpdateBooks;
                    SqlCommand cmDeleteBooks;
                    SqlTransaction mytran;
                    cn = new SqlConnection("data source=(local);integrated security=SSPI;initial catalog=Library");

                    //insert record into transaction
                    cmInsertTransactionID = new SqlCommand();
                    cmInsertTransactionID.Connection = cn;
                    cmInsertTransactionID.CommandText = "Insert into TransactionID " +
                        "(BookID, MemberID, DateActualReturn,LoanStatus) values (@BID, @MID, @DAR,@LSS)";
                    
                    //Upadate book quantities(add)
                    cmUpdateBooks = new SqlCommand();
                    cmUpdateBooks.Connection = cn;
                    cmUpdateBooks.CommandText = "Update Books set Quantity=Quantity+1 where BookID=@BID2";

                    //delete the issue book record
                    cmDeleteBooks = new SqlCommand();
                    cmDeleteBooks.Connection = cn;
                    cmDeleteBooks.CommandText = "delete from TransactionID where " +
                        "BookID=@BID3 and MemberID=@MID3 and LoanStatus='out'";

                    SqlParameter pBID = new SqlParameter("@BID", SqlDbType.SmallInt);
                    SqlParameter pMID = new SqlParameter("@MID", SqlDbType.NVarChar, 4);
                    SqlParameter pDAR = new SqlParameter("@DAR", SqlDbType.DateTime);
                    SqlParameter pLSS = new SqlParameter("@LSS", SqlDbType.NVarChar, 3);
                    SqlParameter[] pArr = new SqlParameter[] { pBID, pMID, pDAR, pLSS };
                    SqlParameter parr1 = new SqlParameter("BID2", SqlDbType.SmallInt);
                    SqlParameter pBID3 = new SqlParameter("@BID3", SqlDbType.SmallInt);
                    SqlParameter pMID3= new SqlParameter("@MID3", SqlDbType.NVarChar, 4);
                    SqlParameter[] parr2 = new SqlParameter[] { pBID3, pMID3 };
                    cmInsertTransactionID.Parameters.AddRange(pArr);
                    cmUpdateBooks.Parameters.Add(parr1);
                    cmDeleteBooks.Parameters.AddRange(parr2);

                    cn.Open();
                    pBID.Value = short.Parse(BIDTextBox.Text);
                    pMID.Value = MIDTextBox.Text;
                    pDAR.Value = DateTime.Now;
                    pLSS.Value = "In";
                    parr1.Value= short.Parse(BIDTextBox.Text);
                    pBID3.Value= short.Parse(BIDTextBox.Text);
                    pMID3.Value = MIDTextBox.Text;

                    try
                    {
                        mytran = cn.BeginTransaction();
                        cmInsertTransactionID.Transaction = mytran;
                        cmInsertTransactionID.ExecuteNonQuery();
                        cmUpdateBooks.Transaction = mytran;
                        cmUpdateBooks.ExecuteNonQuery();
                        cmDeleteBooks.Transaction = mytran;
                        cmDeleteBooks.ExecuteNonQuery();
                        mytran.Commit();
                    }
                    catch (Exception err)
                    {
                        throw new ApplicationException("Return book failed!" + err.Message);
                    }
                    finally
                    {
                        cn.Close();
                        tag = true;
                        MessageBox.Show("Return Successful");
                    }

                }
            }
            if(!tag)
            {
                MessageBox.Show("No Loan Record found");
            }
        }

        //close button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //search bybook button
        private void memlookupButton_Click(object sender, EventArgs e)
        {
            Bybook form = new Bybook(this);
            form.ShowDialog();
        }

        public void UpdateTextBox(TextBox tb1, string newData)
        {
            tb1.Text = newData; 
        }

        //search bymember button
        private void button3_Click(object sender, EventArgs e)
        {
            Bymember form = new Bymember(this);
            form.ShowDialog();
        }
    }
}
