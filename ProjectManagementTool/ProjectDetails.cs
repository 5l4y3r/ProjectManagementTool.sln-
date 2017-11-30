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

        string projectName;
        public ProjectDetails()
        {
            InitializeComponent();
            setProjectDetails();
            SetGridView();
        }
        public ProjectDetails(string s1)
        {
            MessageBox.Show(s1);
            var con = new PmtContext();

            InitializeComponent();
            projectBindingSource.DataSource = con.Projects.ToList().Where(t => t.ProjectName == s1);

            taskBindingSource.DataSource = con.Tasks.ToList().Where(t => t.TasksProjectName == s1);
            projectName = s1;
            
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
            dataGridView1.DataSource = taskBindingSource;
        }

        private void setProjectDetails()
        {
            
         
           
        }

        private void taskBindingSource_CurrentChanged(object sender, EventArgs e)
        {
         
        }

        private void projectBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetGridView();
        }
    }
}
