namespace SA47_Team9B_UIDesignTemplate
{
    partial class BookSearchMain
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
            this.ViewBookButton = new System.Windows.Forms.Button();
            this.SearchBookDataGrid = new System.Windows.Forms.DataGridView();
            this.ShowAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.SearchTitlesButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SearchAuthorTextBox = new System.Windows.Forms.TextBox();
            this.SearchAuthorButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SearchPubTextbox = new System.Windows.Forms.TextBox();
            this.SearchPublishersButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBookDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewBookButton
            // 
            this.ViewBookButton.Location = new System.Drawing.Point(1063, 24);
            this.ViewBookButton.Margin = new System.Windows.Forms.Padding(6);
            this.ViewBookButton.Name = "ViewBookButton";
            this.ViewBookButton.Size = new System.Drawing.Size(158, 42);
            this.ViewBookButton.TabIndex = 13;
            this.ViewBookButton.Text = "View Selected";
            this.ViewBookButton.UseVisualStyleBackColor = true;
            this.ViewBookButton.Click += new System.EventHandler(this.ViewBookButton_Click_1);
            // 
            // SearchBookDataGrid
            // 
            this.SearchBookDataGrid.AllowUserToAddRows = false;
            this.SearchBookDataGrid.AllowUserToDeleteRows = false;
            this.SearchBookDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SearchBookDataGrid.Location = new System.Drawing.Point(22, 347);
            this.SearchBookDataGrid.Margin = new System.Windows.Forms.Padding(6);
            this.SearchBookDataGrid.Name = "SearchBookDataGrid";
            this.SearchBookDataGrid.ReadOnly = true;
            this.SearchBookDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SearchBookDataGrid.Size = new System.Drawing.Size(1199, 358);
            this.SearchBookDataGrid.TabIndex = 12;
            this.SearchBookDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchBookDataGrid_CellContentClick);
            this.SearchBookDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchBookDataGrid_CellContentClick_1);
            // 
            // ShowAllButton
            // 
            this.ShowAllButton.Location = new System.Drawing.Point(178, 24);
            this.ShowAllButton.Margin = new System.Windows.Forms.Padding(6);
            this.ShowAllButton.Name = "ShowAllButton";
            this.ShowAllButton.Size = new System.Drawing.Size(205, 42);
            this.ShowAllButton.TabIndex = 11;
            this.ShowAllButton.Text = "Show All Books";
            this.ShowAllButton.UseVisualStyleBackColor = true;
            this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 14;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "START HERE";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FindTextBox);
            this.groupBox1.Controls.Add(this.SearchTitlesButton);
            this.groupBox1.Location = new System.Drawing.Point(22, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(326, 185);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(11, 35);
            this.FindTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(283, 29);
            this.FindTextBox.TabIndex = 1;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // SearchTitlesButton
            // 
            this.SearchTitlesButton.Location = new System.Drawing.Point(13, 111);
            this.SearchTitlesButton.Margin = new System.Windows.Forms.Padding(6);
            this.SearchTitlesButton.Name = "SearchTitlesButton";
            this.SearchTitlesButton.Size = new System.Drawing.Size(191, 42);
            this.SearchTitlesButton.TabIndex = 0;
            this.SearchTitlesButton.Text = "Search by Title";
            this.SearchTitlesButton.UseVisualStyleBackColor = true;
            this.SearchTitlesButton.Click += new System.EventHandler(this.SearchButton_Click_2);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SearchAuthorTextBox);
            this.groupBox2.Controls.Add(this.SearchAuthorButton);
            this.groupBox2.Location = new System.Drawing.Point(381, 127);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox2.Size = new System.Drawing.Size(326, 185);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // SearchAuthorTextBox
            // 
            this.SearchAuthorTextBox.Location = new System.Drawing.Point(11, 35);
            this.SearchAuthorTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.SearchAuthorTextBox.Name = "SearchAuthorTextBox";
            this.SearchAuthorTextBox.Size = new System.Drawing.Size(283, 29);
            this.SearchAuthorTextBox.TabIndex = 1;
            this.SearchAuthorTextBox.TextChanged += new System.EventHandler(this.SearchAuthorTextBox_TextChanged);
            // 
            // SearchAuthorButton
            // 
            this.SearchAuthorButton.Location = new System.Drawing.Point(13, 111);
            this.SearchAuthorButton.Margin = new System.Windows.Forms.Padding(6);
            this.SearchAuthorButton.Name = "SearchAuthorButton";
            this.SearchAuthorButton.Size = new System.Drawing.Size(191, 42);
            this.SearchAuthorButton.TabIndex = 0;
            this.SearchAuthorButton.Text = "Search by Author";
            this.SearchAuthorButton.UseVisualStyleBackColor = true;
            this.SearchAuthorButton.Click += new System.EventHandler(this.SearchAuthorButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SearchPubTextbox);
            this.groupBox3.Controls.Add(this.SearchPublishersButton);
            this.groupBox3.Location = new System.Drawing.Point(743, 127);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(326, 185);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // SearchPubTextbox
            // 
            this.SearchPubTextbox.Location = new System.Drawing.Point(11, 35);
            this.SearchPubTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.SearchPubTextbox.Name = "SearchPubTextbox";
            this.SearchPubTextbox.Size = new System.Drawing.Size(283, 29);
            this.SearchPubTextbox.TabIndex = 1;
            this.SearchPubTextbox.TextChanged += new System.EventHandler(this.SearchPubTextbox_TextChanged);
            // 
            // SearchPublishersButton
            // 
            this.SearchPublishersButton.Location = new System.Drawing.Point(13, 111);
            this.SearchPublishersButton.Margin = new System.Windows.Forms.Padding(6);
            this.SearchPublishersButton.Name = "SearchPublishersButton";
            this.SearchPublishersButton.Size = new System.Drawing.Size(211, 42);
            this.SearchPublishersButton.TabIndex = 0;
            this.SearchPublishersButton.Text = "Search by Publisher";
            this.SearchPublishersButton.UseVisualStyleBackColor = true;
            this.SearchPublishersButton.Click += new System.EventHandler(this.SearchPublishersButton_Click);
            // 
            // BookSearchMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 727);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ViewBookButton);
            this.Controls.Add(this.SearchBookDataGrid);
            this.Controls.Add(this.ShowAllButton);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BookSearchMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Search";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.BookSearchMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchBookDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ViewBookButton;
        private System.Windows.Forms.DataGridView SearchBookDataGrid;
        private System.Windows.Forms.Button ShowAllButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Button SearchTitlesButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox SearchAuthorTextBox;
        private System.Windows.Forms.Button SearchAuthorButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox SearchPubTextbox;
        private System.Windows.Forms.Button SearchPublishersButton;
    }
}