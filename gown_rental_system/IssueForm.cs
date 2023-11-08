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
    public partial class IssueForm : Form
    {
        public IssueForm()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelIssue.Controls.Add(childForm);
            panelIssue.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            openChildForm(new IssueNextForm());
            //LoadClient();
        }
    }
}
