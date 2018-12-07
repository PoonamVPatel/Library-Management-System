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
    public partial class frmMem : Form
    {
        public frmMem()
        {
            InitializeComponent();
        }

        private void crvMem_Load(object sender, EventArgs e)
        {
            LibraryEntities lib = new LibraryEntities();
            members1 cr = new members1();
            cr.SetDataSource(lib.Members);
            crystalReportViewer1.ReportSource = cr;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void frmMem_Load(object sender, EventArgs e)
        {

        }
    }
}
