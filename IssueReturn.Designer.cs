namespace SA47_Team9B_UIDesignTemplate
{
    partial class IssueReturn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.memlookupButton = new System.Windows.Forms.Button();
            this.BIDTextBox = new System.Windows.Forms.TextBox();
            this.MIDTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Code";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.memlookupButton);
            this.groupBox1.Controls.Add(this.BIDTextBox);
            this.groupBox1.Controls.Add(this.MIDTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(103, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 223);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Issue";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(440, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // memlookupButton
            // 
            this.memlookupButton.Location = new System.Drawing.Point(440, 57);
            this.memlookupButton.Name = "memlookupButton";
            this.memlookupButton.Size = new System.Drawing.Size(61, 36);
            this.memlookupButton.TabIndex = 5;
            this.memlookupButton.Text = "...";
            this.memlookupButton.UseVisualStyleBackColor = true;
            this.memlookupButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // BIDTextBox
            // 
            this.BIDTextBox.Location = new System.Drawing.Point(227, 141);
            this.BIDTextBox.Name = "BIDTextBox";
            this.BIDTextBox.Size = new System.Drawing.Size(186, 29);
            this.BIDTextBox.TabIndex = 4;
            // 
            // MIDTextBox
            // 
            this.MIDTextBox.Location = new System.Drawing.Point(227, 60);
            this.MIDTextBox.Name = "MIDTextBox";
            this.MIDTextBox.Size = new System.Drawing.Size(186, 29);
            this.MIDTextBox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(530, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "Issue Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(754, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 64);
            this.button2.TabIndex = 3;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // IssueReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 630);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "IssueReturn";
            this.Text = "Issue Book";
            this.Load += new System.EventHandler(this.IssueReturn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button memlookupButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox BIDTextBox;
        public System.Windows.Forms.TextBox MIDTextBox;
    }
}