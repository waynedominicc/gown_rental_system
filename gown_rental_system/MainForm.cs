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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //to show subform forms in mainform
        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnClients_Click_1(object sender, EventArgs e)
        {
            openChildForm(new ClientForm());
        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            openChildForm(new DashboardForm());
        }

        private void btnGowns_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageGownForm());
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {

        }
    }
}
