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
using System.Reflection;

namespace SA47_Team09b_
{
    public partial class SearchBooksForm : Form
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
        public int Rownumber { get; private set; }
        public object NULL { get; private set; }
        public object Searchbookdatagrid { get; private set; }

        public SearchBooksForm()
        {
            InitializeComponent();
            ViewBookButton.Enabled = false;
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            var q = from x in context.Books 
                    select x;
            SearchBookDataGrid.DataSource = q.ToList();
            SearchBookDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SearchBookDataGrid.MultiSelect = false;
           
            if (SearchBookDataGrid.SelectedRows.Count < 1)
            {
                ViewBookButton.Enabled = true;
            }
        
        }
        private void ViewBookButton_Click(object sender, EventArgs e)
        {

            if (SearchBookDataGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select item before update");
            }

            this.Hide();
            var Edit_Details = new Edit_Details();
            Edit_Details.Closed += (s, args) => this.Close();
            Edit_Details.Show();

        }

        private void SearchBooksForm_Load(object sender, EventArgs e)
        {

        }

        private void SearchBookDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SearchBookDataGrid.Rows[e.RowIndex].ReadOnly = false;
           
            DataGridViewRow row = this.SearchBookDataGrid.Rows[e.RowIndex];
            passtitle = row.Cells[8].Value.ToString();
            passauthor = row.Cells[7].Value.ToString();
            passpublisher = row.Cells[3].Value.ToString();
            passbooktype = row.Cells[1].Value.ToString();
            passbookID = row.Cells[0].Value.ToString();
            passprice = row.Cells[2].Value.ToString();
            passyearpublished = row.Cells[4].Value.ToString();
            passedition = row.Cells[6].Value.ToString();
            passquantity = row.Cells[5].Value.ToString();
        }

        private void SearchBookDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            var p = context.Books.ToList();

            bool searchstatus = false;
            if (SearchBookDataGrid.SelectedRows.Count < 1)
                {
                    ViewBookButton.Enabled = true;
                }
            //search by BookID
            foreach (var item in p)
                {

                    if (item.BookID.ToString() == SearchBookIDTextBox.Text)
                    {
                        var q = context.Books.Where(x => x.BookID.ToString() == SearchBookIDTextBox.Text);
                    SearchBookDataGrid.DataSource = q.ToList();
                        searchstatus = true;
                    }
                }
            
                //search by BookTitle
                foreach (var item in p)
                {
                    if (item.BookTitle == SearchTitleTextBox.Text)
                    {
                        var q = context.Books.Where(x => x.BookTitle == SearchTitleTextBox.Text);
                        SearchBookDataGrid.DataSource = q.ToList();
                        searchstatus = true;
                    }
                }
                if (!searchstatus)
                    MessageBox.Show("Cannot find this book");
            }
        }
    }
    


