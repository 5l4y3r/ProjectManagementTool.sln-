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
        public ViewProjects()
        {
            InitializeComponent();
            SetGridView();
        }

        private void projectBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var con = new PmtContext();

            projectBindingSource.DataSource = con.Projects.SingleOrDefault(t => t.ProjectManager == "pial") as Project;
            
        }
        private void SetGridView()
        {
            var con = new PmtContext();

            dataGridView1.DataSource= con.Projects.SingleOrDefault(t => t.ProjectManager == "pial") as Project;
            
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            string s1;
            s1 = cboxSelectProject.SelectedText;
            ProjectDetails p1= new ProjectDetails();
            p1.Show();
        }
    }
}
