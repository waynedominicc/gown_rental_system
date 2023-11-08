using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gown_rental_system
{
    public partial class ManageGownForm : Form
    {
        public ManageGownForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ManageGownModuleForm moduleForm = new ManageGownModuleForm();
            moduleForm.btnSave.Enabled = true;
            moduleForm.btnCancel.Enabled = true;
            moduleForm.ShowDialog();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            IssueForm moduleForm = new IssueForm();
            moduleForm.btnNext.Enabled = true;
            moduleForm.ShowDialog();
            //LoadClient();
        }
    }
}
