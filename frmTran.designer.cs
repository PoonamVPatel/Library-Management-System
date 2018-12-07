namespace SA47_Team9B_UIDesignTemplate
{
    partial class frmTran
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
            this.cRVtran = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crBook1 = new SA47_Team9B_UIDesignTemplate.crBook();
            this.crTransactions1 = new SA47_Team9B_UIDesignTemplate.crTransactions();
            this.crTransactions2 = new SA47_Team9B_UIDesignTemplate.crTransactions();
            this.SuspendLayout();
            // 
            // cRVtran
            // 
            this.cRVtran.ActiveViewIndex = -1;
            this.cRVtran.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cRVtran.Cursor = System.Windows.Forms.Cursors.Default;
            this.cRVtran.DisplayBackgroundEdge = false;
            this.cRVtran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cRVtran.Location = new System.Drawing.Point(0, 0);
            this.cRVtran.Name = "cRVtran";
            this.cRVtran.Size = new System.Drawing.Size(1434, 906);
            this.cRVtran.TabIndex = 0;
            this.cRVtran.ToolPanelWidth = 199;
            this.cRVtran.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frmTran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 906);
            this.Controls.Add(this.cRVtran);
            this.Name = "frmTran";
            this.Text = "Transaction Receipts";
            this.Load += new System.EventHandler(this.frmTran_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cRVtran;
        private crTransactions crTransactions1;
        private crTransactions crTransactions2;
        private crBook crBook1;
    }
}