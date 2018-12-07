using SA47_Team9B_UIDesignTemplate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SA47_Team9B_UIDesignTemplate
{
    

    public partial class main : Form
    {

        public main()
        {
            InitializeComponent();

            timer1.Enabled = true;
            timer1.Interval = 200;


        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox hb = new AboutBox();
            hb.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {
          


        }
  

        private void button3_Click(object sender, EventArgs e)
        {
            Form1_Members fmm = new Form1_Members();
            fmm.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logInToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void borrowReturnBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueReturn ir = new IssueReturn();
            
            ir.Show();
           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpWindow hw = new HelpWindow();
            hw.ShowDialog();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       
                datelabel.Text = DateTime.Now.ToLongTimeString();
                clocklabel.Text = DateTime.Now.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IssueReturn ir = new IssueReturn();
            ir.ShowDialog();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Edit_Details mb = new Edit_Details();
            mb.ShowDialog();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BookSearchMain bs = new BookSearchMain();
            bs.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmBook fm= new frmBook();
            fm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmMem rr = new frmMem();
            rr.ShowDialog();
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            ReturnBooks rb = new ReturnBooks();
            rb.ShowDialog();
        }

        private void enrolNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewMember NewMember = new AddNewMember();

            NewMember.Show();
        }

        private void logInToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            BookSearchMain bs = new BookSearchMain();
            bs.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewMember an = new AddNewMember();
            an.ShowDialog();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1_Members fz = new Form1_Members();
            fz.ShowDialog();
        }

        private void bookInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBook fm = new frmBook();
            fm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            frmTran ft = new frmTran();
            ft.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Edit_Details nw = new Edit_Details();
            nw.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTran ft = new frmTran();
            ft.ShowDialog();
        }

        private void membershipCategoryStatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMem fv = new frmMem();
            fv.ShowDialog();

        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReturnBooks ir = new ReturnBooks();

            ir.Show();
        }
    }
}
