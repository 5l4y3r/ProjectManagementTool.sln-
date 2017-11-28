using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityClasses;

namespace ProjectManagementTool
{
    public partial class AddOrUpdateUser : Form
    {
        public AddOrUpdateUser()
        {
            InitializeComponent();
            SetGridView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string s1 = txtName.Text;
            string s2 = txtEmail.Text;
            string s3 = txtPassword.Text;
            bool s4;
            if (rbActive.Checked)
            {
                s4 = rbActive.Checked;
            }
            else
            {
                s4 = rbActive.Checked;
            }
            string s5 = listBox1.Text;

            BusinessLayer.AddOrUpdateUser.AddUser(s1,s2,s3,s4,s5);

            SetGridView();
        }

        private void rbActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbActive.Checked)
            {
                rbInactive.Checked = false;
            }

        }

        private void rbInactive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInactive.Checked)
            {
                rbActive.Checked = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SetGridView()
        {
            dataGridView1.DataSource = new PmtContext().Users.ToList();
        }
    }
}
