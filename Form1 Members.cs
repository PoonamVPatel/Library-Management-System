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
    public partial class Form1_Members : Form
    {
        SqlConnection con = new SqlConnection("data source = (local); integrated security = SSPI; initial catalog = Library ");

        public Form1_Members()
        {
            InitializeComponent();
        }

        private void Form1_Members_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();
            dataGridView1.DataSource = context.Members.ToList();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ReadOnly = true;
            dataGridView1.MultiSelect = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AddNewMember NewMember = new AddNewMember();

            NewMember.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LibraryEntities context = new LibraryEntities();

            var p = context.Members.Select(x => new { x.MemberID, x.MemberType }).ToList();
            bool searchstatus = false;

            //search by MemberID
            foreach (var item in p)
            {

                if (item.MemberID.ToString() == textBox1.Text)
                {
                    var q = context.Members.Where(x => x.MemberID.ToString() == textBox1.Text);
                    dataGridView1.DataSource = q.ToList();
                    searchstatus = true;
                }
            }
            //search by MemberType
            foreach (var item in p)
            {


                if (item.MemberType == textBox1.Text)
                {
                    var q = context.Members.Where(x => x.MemberType == textBox1.Text);
                    dataGridView1.DataSource = q.ToList();
                    searchstatus = true;
                }
            }
            if (!searchstatus)
                MessageBox.Show("Cannot find this Member");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count < 1)
            {
                LibraryEntities context = new LibraryEntities();
                dataGridView1.DataSource = context.Members.ToList();
                MessageBox.Show("Please select Member from Member List");
                return;
            }
            EditMemberDetails EditMember = new EditMemberDetails();
            EditMember.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Hide();


            EditMemberDetails Form = new EditMemberDetails();

            Form.textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Form.textBox2.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            Form.textBox3.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Form.textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Form.textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            Form.textBox6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Form.textBox7.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            Form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
