using EntityClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementTool
{
    public partial class ProjectDetails : Form
    {

        string protectName;
        public ProjectDetails()
        {
            InitializeComponent();
            setProjectDetails();
            SetGridView();
        }
        public ProjectDetails(string s1)
        {
            var con = new PmtContext();

            projectBindingSource.DataSource = con.Projects.SingleOrDefault(t => t.ProjectName == s1) as Project;

            taskBindingSource.DataSource = con.Projects.SingleOrDefault(t => t.ProjectName == s1) as Project;
            protectName = s1;
            InitializeComponent();
            SetGridView();
        }
        private void txtCreateTask_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddOrUpdateTask a1 = new AddOrUpdateTask();
            a1.Show();
            SetGridView();
        }

        private void SetGridView()
        {
            dataGridView1.DataSource = new PmtContext().Tasks.ToList();
        }

        private void setProjectDetails()
        {
            var con = new PmtContext();
            var tempo = con.Projects.SingleOrDefault(t => t.ProjectName == protectName) as Project;
            txtPName.Text = tempo.ProjectName;
            txtCName.Text = "";
            txtDuration.Text = tempo.ProjectDuration.ToString();
            txtStatus.Text = tempo.ProjectStatus;
            txtPED.Text = tempo.ProjectPed.ToString();
            txtDesc.Text = tempo.ProjectDescription; 
            txtDuration.Text =tempo.ProjectDuration.ToString();
        }

        private void taskBindingSource_CurrentChanged(object sender, EventArgs e)
        {
         
        }

        private void projectBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           
        }
    }
}
