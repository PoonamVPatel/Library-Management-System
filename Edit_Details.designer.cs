namespace SA47_Team9B_UIDesignTemplate
{
    partial class Edit_Details
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
            this.NewBookGroupBox = new System.Windows.Forms.GroupBox();
            this.NewBookButton = new System.Windows.Forms.Button();
            this.SaveNewBookButton = new System.Windows.Forms.Button();
            this.BookIDLabelBox = new System.Windows.Forms.Label();
            this.EditButton = new System.Windows.Forms.Button();
            this.BookTypeListBox = new System.Windows.Forms.ListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.UpdateBookGroupBox = new System.Windows.Forms.GroupBox();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.EditionTextBox = new System.Windows.Forms.TextBox();
            this.YearPublishedTextBox = new System.Windows.Forms.TextBox();
            this.PublisherTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.EditionLabel = new System.Windows.Forms.Label();
            this.YearPublishedLabel = new System.Windows.Forms.Label();
            this.BookIDLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BookTypeLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.BacktoMainButton = new System.Windows.Forms.Button();
            this.NewBookGroupBox.SuspendLayout();
            this.UpdateBookGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewBookGroupBox
            // 
            this.NewBookGroupBox.Controls.Add(this.NewBookButton);
            this.NewBookGroupBox.Controls.Add(this.SaveNewBookButton);
            this.NewBookGroupBox.Location = new System.Drawing.Point(616, 430);
            this.NewBookGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.NewBookGroupBox.Name = "NewBookGroupBox";
            this.NewBookGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.NewBookGroupBox.Size = new System.Drawing.Size(367, 185);
            this.NewBookGroupBox.TabIndex = 48;
            this.NewBookGroupBox.TabStop = false;
            this.NewBookGroupBox.Text = "New Book";
            // 
            // NewBookButton
            // 
            this.NewBookButton.Location = new System.Drawing.Point(42, 52);
            this.NewBookButton.Margin = new System.Windows.Forms.Padding(6);
            this.NewBookButton.Name = "NewBookButton";
            this.NewBookButton.Size = new System.Drawing.Size(196, 42);
            this.NewBookButton.TabIndex = 25;
            this.NewBookButton.Text = "Add New Book";
            this.NewBookButton.UseVisualStyleBackColor = true;
            this.NewBookButton.Click += new System.EventHandler(this.NewBookButton_Click_1);
            // 
            // SaveNewBookButton
            // 
            this.SaveNewBookButton.Location = new System.Drawing.Point(42, 118);
            this.SaveNewBookButton.Margin = new System.Windows.Forms.Padding(6);
            this.SaveNewBookButton.Name = "SaveNewBookButton";
            this.SaveNewBookButton.Size = new System.Drawing.Size(196, 42);
            this.SaveNewBookButton.TabIndex = 26;
            this.SaveNewBookButton.Text = "Save Details";
            this.SaveNewBookButton.UseVisualStyleBackColor = true;
            this.SaveNewBookButton.Click += new System.EventHandler(this.SaveNewBookButton_Click);
            // 
            // BookIDLabelBox
            // 
            this.BookIDLabelBox.AutoSize = true;
            this.BookIDLabelBox.Location = new System.Drawing.Point(196, 35);
            this.BookIDLabelBox.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BookIDLabelBox.Name = "BookIDLabelBox";
            this.BookIDLabelBox.Size = new System.Drawing.Size(0, 25);
            this.BookIDLabelBox.TabIndex = 46;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(11, 35);
            this.EditButton.Margin = new System.Windows.Forms.Padding(6);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(138, 42);
            this.EditButton.TabIndex = 23;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // BookTypeListBox
            // 
            this.BookTypeListBox.FormattingEnabled = true;
            this.BookTypeListBox.ItemHeight = 24;
            this.BookTypeListBox.Items.AddRange(new object[] {
            "Adventure",
            "Business",
            "History",
            "Horror",
            "Kids",
            "Science",
            "Sci-fi",
            "Teens"});
            this.BookTypeListBox.Location = new System.Drawing.Point(700, 30);
            this.BookTypeListBox.Margin = new System.Windows.Forms.Padding(6);
            this.BookTypeListBox.Name = "BookTypeListBox";
            this.BookTypeListBox.Size = new System.Drawing.Size(274, 148);
            this.BookTypeListBox.TabIndex = 45;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(202, 35);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(6);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(138, 42);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(202, 120);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(6);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(138, 42);
            this.CancelButton.TabIndex = 20;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click_1);
            // 
            // UpdateBookGroupBox
            // 
            this.UpdateBookGroupBox.Controls.Add(this.SaveButton);
            this.UpdateBookGroupBox.Controls.Add(this.EditButton);
            this.UpdateBookGroupBox.Controls.Add(this.CancelButton);
            this.UpdateBookGroupBox.Location = new System.Drawing.Point(616, 234);
            this.UpdateBookGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.UpdateBookGroupBox.Name = "UpdateBookGroupBox";
            this.UpdateBookGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.UpdateBookGroupBox.Size = new System.Drawing.Size(367, 185);
            this.UpdateBookGroupBox.TabIndex = 47;
            this.UpdateBookGroupBox.TabStop = false;
            this.UpdateBookGroupBox.Text = "Update Book";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(416, 30);
            this.QuantityTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(76, 29);
            this.QuantityTextBox.TabIndex = 44;
            this.QuantityTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.QuantityTextBox_KeyUp);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(196, 515);
            this.PriceTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(110, 29);
            this.PriceTextBox.TabIndex = 43;
            this.PriceTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PriceTextBox_KeyUp);
            // 
            // EditionTextBox
            // 
            this.EditionTextBox.Location = new System.Drawing.Point(196, 430);
            this.EditionTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.EditionTextBox.Name = "EditionTextBox";
            this.EditionTextBox.Size = new System.Drawing.Size(110, 29);
            this.EditionTextBox.TabIndex = 42;
            this.EditionTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EditionTextBox_KeyUp);
            // 
            // YearPublishedTextBox
            // 
            this.YearPublishedTextBox.Location = new System.Drawing.Point(196, 342);
            this.YearPublishedTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.YearPublishedTextBox.Name = "YearPublishedTextBox";
            this.YearPublishedTextBox.Size = new System.Drawing.Size(110, 29);
            this.YearPublishedTextBox.TabIndex = 41;
            this.YearPublishedTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.YearPublishedTextBox_KeyUp);
            // 
            // PublisherTextBox
            // 
            this.PublisherTextBox.Location = new System.Drawing.Point(196, 260);
            this.PublisherTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.PublisherTextBox.Name = "PublisherTextBox";
            this.PublisherTextBox.Size = new System.Drawing.Size(296, 29);
            this.PublisherTextBox.TabIndex = 40;
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Location = new System.Drawing.Point(196, 186);
            this.AuthorTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(296, 29);
            this.AuthorTextBox.TabIndex = 39;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(196, 105);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(296, 29);
            this.TitleTextBox.TabIndex = 38;
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(321, 37);
            this.QuantityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(85, 25);
            this.QuantityLabel.TabIndex = 37;
            this.QuantityLabel.Text = "Quantity";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(33, 528);
            this.PriceLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(56, 25);
            this.PriceLabel.TabIndex = 36;
            this.PriceLabel.Text = "Price";
            // 
            // EditionLabel
            // 
            this.EditionLabel.AutoSize = true;
            this.EditionLabel.Location = new System.Drawing.Point(31, 443);
            this.EditionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EditionLabel.Name = "EditionLabel";
            this.EditionLabel.Size = new System.Drawing.Size(71, 25);
            this.EditionLabel.TabIndex = 35;
            this.EditionLabel.Text = "Edition";
            // 
            // YearPublishedLabel
            // 
            this.YearPublishedLabel.AutoSize = true;
            this.YearPublishedLabel.Location = new System.Drawing.Point(33, 354);
            this.YearPublishedLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.YearPublishedLabel.Name = "YearPublishedLabel";
            this.YearPublishedLabel.Size = new System.Drawing.Size(144, 25);
            this.YearPublishedLabel.TabIndex = 34;
            this.YearPublishedLabel.Text = "Year Published";
            // 
            // BookIDLabel
            // 
            this.BookIDLabel.AutoSize = true;
            this.BookIDLabel.Location = new System.Drawing.Point(33, 37);
            this.BookIDLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BookIDLabel.Name = "BookIDLabel";
            this.BookIDLabel.Size = new System.Drawing.Size(81, 25);
            this.BookIDLabel.TabIndex = 33;
            this.BookIDLabel.Text = "Book ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Publisher";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Author";
            // 
            // BookTypeLabel
            // 
            this.BookTypeLabel.AutoSize = true;
            this.BookTypeLabel.Location = new System.Drawing.Point(576, 35);
            this.BookTypeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BookTypeLabel.Name = "BookTypeLabel";
            this.BookTypeLabel.Size = new System.Drawing.Size(113, 25);
            this.BookTypeLabel.TabIndex = 30;
            this.BookTypeLabel.Text = "Book Type:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(31, 118);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(49, 25);
            this.TitleLabel.TabIndex = 29;
            this.TitleLabel.Text = "Title";
            // 
            // BacktoMainButton
            // 
            this.BacktoMainButton.Location = new System.Drawing.Point(363, 528);
            this.BacktoMainButton.Margin = new System.Windows.Forms.Padding(6);
            this.BacktoMainButton.Name = "BacktoMainButton";
            this.BacktoMainButton.Size = new System.Drawing.Size(215, 42);
            this.BacktoMainButton.TabIndex = 49;
            this.BacktoMainButton.Text = "Back to Main";
            this.BacktoMainButton.UseVisualStyleBackColor = true;
            this.BacktoMainButton.Click += new System.EventHandler(this.BacktoMainButton_Click);
            // 
            // Edit_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 637);
            this.Controls.Add(this.BacktoMainButton);
            this.Controls.Add(this.NewBookGroupBox);
            this.Controls.Add(this.BookIDLabelBox);
            this.Controls.Add(this.BookTypeListBox);
            this.Controls.Add(this.UpdateBookGroupBox);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.EditionTextBox);
            this.Controls.Add(this.YearPublishedTextBox);
            this.Controls.Add(this.PublisherTextBox);
            this.Controls.Add(this.AuthorTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.EditionLabel);
            this.Controls.Add(this.YearPublishedLabel);
            this.Controls.Add(this.BookIDLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BookTypeLabel);
            this.Controls.Add(this.TitleLabel);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Edit_Details";
            this.Text = "Edit Book Details";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Edit_Details_Load_1);
            this.NewBookGroupBox.ResumeLayout(false);
            this.UpdateBookGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox NewBookGroupBox;
        private System.Windows.Forms.Button NewBookButton;
        private System.Windows.Forms.Button SaveNewBookButton;
        private System.Windows.Forms.Label BookIDLabelBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ListBox BookTypeListBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.GroupBox UpdateBookGroupBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.TextBox EditionTextBox;
        private System.Windows.Forms.TextBox YearPublishedTextBox;
        private System.Windows.Forms.TextBox PublisherTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label EditionLabel;
        private System.Windows.Forms.Label YearPublishedLabel;
        private System.Windows.Forms.Label BookIDLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BookTypeLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Button BacktoMainButton;
    }
}