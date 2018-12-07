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
    public partial class Edit_Details : Form
    {
        public Edit_Details()
        {
            InitializeComponent();

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void CurrentlyEditingLabel_Click(object sender, EventArgs e)
        {
            // CurrentlyEditingLabel.Text = 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            
            
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SaveButton.Show();
            CancelButton.Show();

            TitleTextBox.Enabled = true;
            AuthorTextBox.Enabled = true;
            PublisherTextBox.Enabled = true;
            BookTypeListBox.Enabled = true;
            PriceTextBox.Enabled = true;
            EditionTextBox.Enabled = true;
            YearPublishedTextBox.Enabled = true;
            QuantityTextBox.Enabled = true;


        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Edit_Details_Load_1(object sender, EventArgs e)
        {
            SaveButton.Hide();
            CancelButton.Hide();

            NewBookButton.Enabled= true;
            SaveNewBookButton.Enabled = false;

            TitleTextBox.Text = BookSearchMain.passtitle;
            AuthorTextBox.Text = BookSearchMain.passauthor;
            PublisherTextBox.Text = BookSearchMain.passpublisher;
            BookTypeListBox.Text = BookSearchMain.passbooktype;
            PriceTextBox.Text = BookSearchMain.passprice;
            EditionTextBox.Text = BookSearchMain.passedition;
            YearPublishedTextBox.Text = BookSearchMain.passyearpublished;
            QuantityTextBox.Text = BookSearchMain.passquantity;
            BookIDLabelBox.Text = BookSearchMain.passbookID;

            TitleTextBox.Enabled = false;
            AuthorTextBox.Enabled = false;
            PublisherTextBox.Enabled = false;
            BookTypeListBox.Enabled = false;
            PriceTextBox.Enabled = false;
            EditionTextBox.Enabled = false;
            YearPublishedTextBox.Enabled = false;
            QuantityTextBox.Enabled = false;
            
        }

        private void NewBookButton_Click_1(object sender, EventArgs e)
        {
            SaveNewBookButton.Enabled = true;

            TitleTextBox.Text = "";
            AuthorTextBox.Text = "";
            PublisherTextBox.Text = "";
            BookTypeListBox.Text = "";
            BookTypeListBox.ClearSelected();
            PriceTextBox.Text = "";
            EditionTextBox.Text = "";
            YearPublishedTextBox.Text = "";
            QuantityTextBox.Text = "";
            BookIDLabelBox.Text = "";

            TitleTextBox.Enabled = true;
            AuthorTextBox.Enabled = true;
            PublisherTextBox.Enabled = true;
            BookTypeListBox.Enabled = true;
            PriceTextBox.Enabled = true;
            EditionTextBox.Enabled = true;
            YearPublishedTextBox.Enabled = true;
            QuantityTextBox.Enabled = true;
        }

        private void SaveNewBookButton_Click(object sender, EventArgs e)
        {

            if  ((TitleTextBox.Text == String.Empty) ||
                (BookTypeListBox.Text == String.Empty) ||
                (PublisherTextBox.Text == String.Empty) ||
                (YearPublishedTextBox.Text == String.Empty) ||
                (QuantityTextBox.Text == String.Empty) ||
                (PriceTextBox.Text == String.Empty) ||
                (AuthorTextBox.Text == String.Empty) ||
                (EditionTextBox.Text == String.Empty))
            {
                    MessageBox.Show("Cannot leave a field blank. Please enter details for all fields.");
                
            }
            else
            switch (MessageBox.Show("Proceed adding book?", "New Book",
                  MessageBoxButtons.YesNo,
                  MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        // "Yes" processing

                        String cnS = "data source = (local); integrated security = SSPI; initial catalog = Library ";
                        SqlConnection cn = new SqlConnection(cnS);
                        string sql = "insert into Books(BookType,Price,Publisher,YearPublished,Quantity,Edition,Author,BookTitle) " +
                            "Values('" + BookTypeListBox.Text + "', '" + PriceTextBox.Text + "', '" + PublisherTextBox.Text + "', '" + YearPublishedTextBox.Text + "', '" + QuantityTextBox.Text + "', '" + EditionTextBox.Text + "', '" + AuthorTextBox.Text + "', '" + TitleTextBox.Text + "')";
                        SqlCommand cm = new SqlCommand(sql, cn);
                        SqlDataAdapter da = new SqlDataAdapter(cm);
                        SqlCommandBuilder cmb = new SqlCommandBuilder(da);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Books");
                        MessageBox.Show("The book has been added.");
                        EditButton.Enabled = false;
                        SaveNewBookButton.Enabled = false;

                        break;

                    case DialogResult.No:
                        // "No" processing
                        break;
                }
                
            
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {

            
                if ((TitleTextBox.Text == String.Empty) ||
                 (BookTypeListBox.Text == String.Empty) ||
                 (PublisherTextBox.Text == String.Empty) ||
                 (YearPublishedTextBox.Text == String.Empty) ||
                 (QuantityTextBox.Text == String.Empty) ||
                 (PriceTextBox.Text == String.Empty) ||
                 (AuthorTextBox.Text == String.Empty) ||
                 (EditionTextBox.Text == String.Empty))

                {
                MessageBox.Show("Cannot leave a field blank. Please enter details for all fields.");
                return;
                }
                


                switch (MessageBox.Show("Proceed with the changes?", "Update Book Details",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question))
                {
                    case DialogResult.Yes:
                        // "Yes" processing
                        string conString = "Data Source=(local);" + "Initial Catalog=Library;Integrated Security=SSPI";
                        SqlConnection cn = new SqlConnection(conString);
                        string newbooktitle = TitleTextBox.Text;
                        string newauthor = AuthorTextBox.Text;
                        string newpublisher = PublisherTextBox.Text;
                        string newtype = BookTypeListBox.SelectedItem.ToString();
                        string newyearpublished = YearPublishedTextBox.Text;
                        string newedition = EditionTextBox.Text;
                        string newquantity = QuantityTextBox.Text;
                        string newprice = PriceTextBox.Text;


                        if (PriceTextBox.Text.Length >= 2)
                        {
                            int selectionStart = PriceTextBox.SelectionStart;
                            PriceTextBox.Text = PriceTextBox.Text.Replace(".", "");
                            int length = PriceTextBox.Text.Length;
                            PriceTextBox.Text = PriceTextBox.Text.Insert(length - 2, ".");
                            PriceTextBox.SelectionStart = PriceTextBox.Text.Length;
                        }
                      

                    cn.Open();

                        string sql = "Update Books SET BookTitle='" + newbooktitle +
                            "', Author='" + newauthor +
                            "', publisher='" + newpublisher +
                            "', BookType='" + newtype +
                            "', YearPublished='" + newyearpublished +
                            "', edition ='" + newedition +
                            "', quantity='" + newquantity +
                            "', price='" + newprice +
                            "' where BookID ="+ "@BookID";
                        SqlCommand cm = new SqlCommand(sql, cn);
                        SqlParameter name = cm.Parameters.Add("@BookID", SqlDbType.SmallInt);
                        name.Value = BookIDLabelBox.Text;
                        cm.ExecuteNonQuery();

                        MessageBox.Show("Update Successful");
                        //cn.Close();

                        break;

                    case DialogResult.No:
                        // "No" processing
                        break;

                }
                TitleTextBox.Enabled = false;
                AuthorTextBox.Enabled = false;
                PublisherTextBox.Enabled = false;
                BookTypeListBox.Enabled = false;
                PriceTextBox.Enabled = false;
                EditionTextBox.Enabled = false;
                YearPublishedTextBox.Enabled = false;
                QuantityTextBox.Enabled = false;

            }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            BookSearchMain front = new BookSearchMain();
            front.Show();
        }

        private void BacktoMainButton_Click(object sender, EventArgs e)
        {
            Edit_Details.ActiveForm.Close();
            BookSearchMain n1 = new BookSearchMain();
            n1.Show();
            Edit_Details e1 = new Edit_Details();
            e1.Hide();
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void QuantityTextBox_Leave(object sender, EventArgs e)
        {
           
        }

        private void YearPublishedTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(YearPublishedTextBox.Text, out int i) == false)
            {
                YearPublishedTextBox.Text = string.Empty;
                YearPublishedTextBox.Visible = true;
                MessageBox.Show("Year only allows numeric");
                return;
            }
            if (YearPublishedTextBox.Text.Length > 4 )
            {
                MessageBox.Show("Please enter valid year");
                return;
            }
         


        }
        private void PriceTextBox_KeyUp(object sender, KeyEventArgs e)
        { }
        private void EditionTextBox_KeyUp(object sender, KeyEventArgs e)
        { }
        private void YearPublishedTextBox_KeyUp(object sender, KeyEventArgs e)
        { }
        private void PriceTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(PriceTextBox.Text, out int i) == false)
            {
                PriceTextBox.Text = string.Empty;
                PriceTextBox.Visible = true;
                MessageBox.Show("Price only allows numeric");
                return;
            }
        }

        private void EditionTextBox_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(EditionTextBox.Text, out int i) == false)
            {
                EditionTextBox.Text = string.Empty;
                EditionTextBox.Visible = true;
                MessageBox.Show("Edition only allows numeric");
                return;
            }
        }

        private void QuantityTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (int.TryParse(QuantityTextBox.Text, out int i) == false)
            {
                QuantityTextBox.Text = string.Empty;
                QuantityTextBox.Visible = true;
                MessageBox.Show("Quantity only allows numeric (no decimals)");
                return;
            }
        }
    }
}