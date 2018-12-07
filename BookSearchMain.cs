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
    public partial class BookSearchMain : Form
    {
        public static string passtitle;
        public static string passauthor;
        public static string passpublisher;
        public static string passbooktype;
        public static string passprice;
        public static string passyearpublished;
        public static string passedition;
        public static string passquantity;
        public static string passbookID;
        SqlConnection cn;
        SqlDataAdapter da;
        DataSet ds;
        class NameCountType
        {
            public string Title { get; set; }
            public string Author { get; set; }
        }

        public int Rownumber { get; private set; }
        public object NULL { get; private set; }
        public object Searchbookdatagrid { get; private set; }
        public decimal Amount { get; set; }
        public BookSearchMain()
        {
            InitializeComponent();
            ViewBookButton.Enabled = false;
            SearchAuthorButton.Enabled=false;
            SearchTitlesButton.Enabled=false;
            SearchPublishersButton.Enabled = false;
        }

        private string QuerySearchResults
        {
            get { return "SELECT * FROM Books WHERE Description LIKE '%'+@BookTitle+'%'"; }
        }
        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            SearchAuthorButton.Enabled = true;
            SearchTitlesButton.Enabled = true;
            SearchPublishersButton.Enabled = true;
            //SqlConnection cn;
            //SqlDataAdapter da;
            //DataSet ds;
            string conS = "data source=(local); Initial catalog=Library;Integrated Security=SSPI";
            cn = new SqlConnection(conS);

            string selectsql = "select * from Books";
            da = new SqlDataAdapter(selectsql, cn);
            ds = new DataSet();

            da.Fill(ds, "Books");
            SearchBookDataGrid.DataSource = ds.Tables["Books"];
       
        
            try
            {
                cn.Open();
                da = new SqlDataAdapter(selectsql, cn);
                da.Fill(ds);
                cn.Close();
                SearchBookDataGrid.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            if (SearchBookDataGrid.SelectedRows.Count < 1)
            {
                ViewBookButton.Enabled = true;
            }
        }

        private void SearchBooksMain_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;

        }

      

        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void ViewBookButton_Click_1(object sender, EventArgs e)
        {
            if (SearchBookDataGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select item before update");
            }

            this.Hide();
            var Edit_Details = new Edit_Details();
            Edit_Details.Show();
        }

        private void SearchBookDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SearchBookDataGrid.SelectedRows.Count < 0)

            {
                MessageBox.Show("Please select item before update");
            }
            else
            {
                ViewBookButton.Enabled = true;
            }
            SearchBookDataGrid.Rows[e.RowIndex].ReadOnly = true;

            DataGridViewRow row = this.SearchBookDataGrid.Rows[e.RowIndex];
            passtitle = row.Cells[1].Value.ToString();
            passauthor = row.Cells[2].Value.ToString();
            passpublisher = row.Cells[5].Value.ToString();
            passbooktype = row.Cells[4].Value.ToString();
            passbookID = row.Cells[0].Value.ToString();
            passprice = row.Cells[8].Value.ToString();
            passyearpublished = row.Cells[6].Value.ToString();
            passedition = row.Cells[7].Value.ToString();
            passquantity = row.Cells[3].Value.ToString();
        }

        private void SearchBookDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BookSearchMain_Load(object sender, EventArgs e)
        {
          
          
        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        { 
       
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click_2(object sender, EventArgs e)
        {
            (SearchBookDataGrid.DataSource as DataTable).DefaultView.RowFilter = string.Format("BookTitle LIKE '%{0}%'", FindTextBox.Text);
        }

        private void SearchAuthorButton_Click(object sender, EventArgs e)
        {
            (SearchBookDataGrid.DataSource as DataTable).DefaultView.RowFilter = string.Format("Author LIKE '%{0}%'", SearchAuthorTextBox.Text);
        }

        private void SearchPublishersButton_Click(object sender, EventArgs e)
        {
            {
                (SearchBookDataGrid.DataSource as DataTable).DefaultView.RowFilter = string.Format("Publisher LIKE '%{0}%'", SearchPubTextbox.Text);
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void SearchAuthorTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SearchPubTextbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
