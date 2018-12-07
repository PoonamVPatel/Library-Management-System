namespace SA47_Team09b_
{
    partial class SearchBooksForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SearchBooksGroupBox = new System.Windows.Forms.GroupBox();
            this.SearchPublisherTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.SearchTitleTextBox = new System.Windows.Forms.TextBox();
            this.SearchPublisherLabel = new System.Windows.Forms.Label();
            this.SearchAuthorLabel = new System.Windows.Forms.Label();
            this.SearchTitleLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.SearchBookDataGrid = new System.Windows.Forms.DataGridView();
            this.ViewBookButton = new System.Windows.Forms.Button();
            this.SearchResultsLabel = new System.Windows.Forms.Label();
            this.SearchBookIDTextBox = new System.Windows.Forms.TextBox();
            this.SearchBookTypeListBox = new System.Windows.Forms.ListBox();
            this.SearchBookIDLabel = new System.Windows.Forms.Label();
            this.SearchBookTypeLabel = new System.Windows.Forms.Label();
            this.SearchBooksGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBookDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBooksGroupBox
            // 
            this.SearchBooksGroupBox.Controls.Add(this.SearchBookTypeLabel);
            this.SearchBooksGroupBox.Controls.Add(this.SearchBookIDLabel);
            this.SearchBooksGroupBox.Controls.Add(this.SearchBookTypeListBox);
            this.SearchBooksGroupBox.Controls.Add(this.SearchBookIDTextBox);
            this.SearchBooksGroupBox.Controls.Add(this.SearchPublisherTextBox);
            this.SearchBooksGroupBox.Controls.Add(this.AuthorTextBox);
            this.SearchBooksGroupBox.Controls.Add(this.SearchTitleTextBox);
            this.SearchBooksGroupBox.Controls.Add(this.SearchPublisherLabel);
            this.SearchBooksGroupBox.Controls.Add(this.SearchAuthorLabel);
            this.SearchBooksGroupBox.Controls.Add(this.SearchTitleLabel);
            this.SearchBooksGroupBox.Controls.Add(this.SearchButton);
            this.SearchBooksGroupBox.Location = new System.Drawing.Point(22, 12);
            this.SearchBooksGroupBox.Name = "SearchBooksGroupBox";
            this.SearchBooksGroupBox.Size = new System.Drawing.Size(701, 174);
            this.SearchBooksGroupBox.TabIndex = 0;
            this.SearchBooksGroupBox.TabStop = false;
            // 
            // SearchPublisherTextBox
            // 
            this.SearchPublisherTextBox.Location = new System.Drawing.Point(77, 87);
            this.SearchPublisherTextBox.Name = "SearchPublisherTextBox";
            this.SearchPublisherTextBox.Size = new System.Drawing.Size(294, 20);
            this.SearchPublisherTextBox.TabIndex = 6;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(77, 54);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(294, 20);
            this.AuthorTextBox.TabIndex = 5;
            // 
            // SearchTitleTextBox
            // 
            this.SearchTitleTextBox.Location = new System.Drawing.Point(77, 19);
            this.SearchTitleTextBox.Name = "SearchTitleTextBox";
            this.SearchTitleTextBox.Size = new System.Drawing.Size(294, 20);
            this.SearchTitleTextBox.TabIndex = 4;
            // 
            // SearchPublisherLabel
            // 
            this.SearchPublisherLabel.AutoSize = true;
            this.SearchPublisherLabel.Location = new System.Drawing.Point(18, 92);
            this.SearchPublisherLabel.Name = "SearchPublisherLabel";
            this.SearchPublisherLabel.Size = new System.Drawing.Size(50, 13);
            this.SearchPublisherLabel.TabIndex = 3;
            this.SearchPublisherLabel.Text = "Publisher";
            // 
            // SearchAuthorLabel
            // 
            this.SearchAuthorLabel.AutoSize = true;
            this.SearchAuthorLabel.Location = new System.Drawing.Point(18, 60);
            this.SearchAuthorLabel.Name = "SearchAuthorLabel";
            this.SearchAuthorLabel.Size = new System.Drawing.Size(38, 13);
            this.SearchAuthorLabel.TabIndex = 2;
            this.SearchAuthorLabel.Text = "Author";
            // 
            // SearchTitleLabel
            // 
            this.SearchTitleLabel.AutoSize = true;
            this.SearchTitleLabel.Location = new System.Drawing.Point(18, 26);
            this.SearchTitleLabel.Name = "SearchTitleLabel";
            this.SearchTitleLabel.Size = new System.Drawing.Size(27, 13);
            this.SearchTitleLabel.TabIndex = 1;
            this.SearchTitleLabel.Text = "Title";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(21, 124);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(112, 27);
            this.SearchButton.TabIndex = 0;
            this.SearchButton.Text = "Search Matches";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(163, 228);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(112, 23);
            this.ShowAllButton.TabIndex = 1;
            this.ShowAllButton.Text = "Show All Books";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // SearchBookDataGrid
            // 
            this.SearchBookDataGrid.AllowUserToAddRows = false;
            this.SearchBookDataGrid.AllowUserToDeleteRows = false;
            this.SearchBookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchBookDataGrid.Location = new System.Drawing.Point(22, 257);
            this.SearchBookDataGrid.Name = "SearchBookDataGrid";
            this.SearchBookDataGrid.ReadOnly = true;
            this.SearchBookDataGrid.Size = new System.Drawing.Size(701, 181);
            this.SearchBookDataGrid.TabIndex = 2;
            this.SearchBookDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchBookDataGrid_CellContentClick);
            this.SearchBookDataGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SearchBookDataGrid_RowHeaderMouseClick);
            this.SearchBookDataGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SearchBookDataGrid_RowHeaderMouseClick);
            // 
            // ViewBookButton
            // 
            this.ViewBookButton.Location = new System.Drawing.Point(637, 228);
            this.ViewBookButton.Name = "ViewBookButton";
            this.ViewBookButton.Size = new System.Drawing.Size(86, 23);
            this.ViewBookButton.TabIndex = 3;
            this.ViewBookButton.Text = "View Selected";
            this.ViewBookButton.UseVisualStyleBackColor = true;
            this.ViewBookButton.Click += new System.EventHandler(this.ViewBookButton_Click);
            // 
            // SearchResultsLabel
            // 
            this.SearchResultsLabel.AutoSize = true;
            this.SearchResultsLabel.Location = new System.Drawing.Point(29, 233);
            this.SearchResultsLabel.Name = "SearchResultsLabel";
            this.SearchResultsLabel.Size = new System.Drawing.Size(79, 13);
            this.SearchResultsLabel.TabIndex = 4;
            this.SearchResultsLabel.Text = "Search Results";
            // 
            // SearchBookIDTextBox
            // 
            this.SearchBookIDTextBox.Location = new System.Drawing.Point(468, 19);
            this.SearchBookIDTextBox.Name = "SearchBookIDTextBox";
            this.SearchBookIDTextBox.Size = new System.Drawing.Size(39, 20);
            this.SearchBookIDTextBox.TabIndex = 7;
            // 
            // SearchBookTypeListBox
            // 
            this.SearchBookTypeListBox.FormattingEnabled = true;
            this.SearchBookTypeListBox.Items.AddRange(new object[] {
            "Sci-fi",
            "Action",
            "Drama",
            "Comedy",
            "Horror",
            "Adventure"});
            this.SearchBookTypeListBox.Location = new System.Drawing.Point(468, 54);
            this.SearchBookTypeListBox.Name = "SearchBookTypeListBox";
            this.SearchBookTypeListBox.Size = new System.Drawing.Size(151, 82);
            this.SearchBookTypeListBox.TabIndex = 23;
            // 
            // SearchBookIDLabel
            // 
            this.SearchBookIDLabel.AutoSize = true;
            this.SearchBookIDLabel.Location = new System.Drawing.Point(416, 26);
            this.SearchBookIDLabel.Name = "SearchBookIDLabel";
            this.SearchBookIDLabel.Size = new System.Drawing.Size(46, 13);
            this.SearchBookIDLabel.TabIndex = 24;
            this.SearchBookIDLabel.Text = "Book ID";
            // 
            // SearchBookTypeLabel
            // 
            this.SearchBookTypeLabel.AutoSize = true;
            this.SearchBookTypeLabel.Location = new System.Drawing.Point(416, 54);
            this.SearchBookTypeLabel.Name = "SearchBookTypeLabel";
            this.SearchBookTypeLabel.Size = new System.Drawing.Size(31, 13);
            this.SearchBookTypeLabel.TabIndex = 25;
            this.SearchBookTypeLabel.Text = "Type";
            // 
            // SearchBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.SearchResultsLabel);
            this.Controls.Add(this.ViewBookButton);
            this.Controls.Add(this.SearchBookDataGrid);
            this.Controls.Add(this.ShowAllButton);
            this.Controls.Add(this.SearchBooksGroupBox);
            this.Name = "SearchBooksForm";
            this.Text = "Search Books Form";
            this.Load += new System.EventHandler(this.SearchBooksForm_Load);
            this.SearchBooksGroupBox.ResumeLayout(false);
            this.SearchBooksGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBookDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox SearchBooksGroupBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.DataGridView SearchBookDataGrid;
        private System.Windows.Forms.TextBox SearchPublisherTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox SearchTitleTextBox;
        private System.Windows.Forms.Label SearchPublisherLabel;
        private System.Windows.Forms.Label SearchAuthorLabel;
        private System.Windows.Forms.Label SearchTitleLabel;
        private System.Windows.Forms.Button ViewBookButton;
        private System.Windows.Forms.Label SearchResultsLabel;
        private System.Windows.Forms.TextBox SearchBookIDTextBox;
        private System.Windows.Forms.Label SearchBookTypeLabel;
        private System.Windows.Forms.Label SearchBookIDLabel;
        private System.Windows.Forms.ListBox SearchBookTypeListBox;
    }
}

