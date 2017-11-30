using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityClasses;

namespace ProjectManagementTool
{
    public partial class ViewProjects : Form
    {
        public string loggedInName;
        public ViewProjects()
        {
            InitializeComponent();
            SetGridView();
        }
        public ViewProjects(string s1)
        {
            loggedInName = s1;
            InitializeComponent();
            SetGridView();
            var con = new PmtContext();
            projectBindingSource.DataSource = con.Projects.ToList().Where(t => t.ProjectManager == loggedInName);
            cboxSelectProject.DataSource = projectBindingSource;
        }

        private void projectBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           
        }
        private void SetGridView()
        {
            var con = new PmtContext();

            dataGridView1.DataSource= con.Projects.ToList();
            
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            string s1;
            s1 = cboxSelectProject.Text;
            ProjectDetails p1= new ProjectDetails(s1);
            p1.Show();
        }

        private void cboxSelectProject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
