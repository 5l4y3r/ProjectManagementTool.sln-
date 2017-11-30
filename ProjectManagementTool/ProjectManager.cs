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
    public partial class ProjectManager : Form
    {
        public string managerName;
        public ProjectManager()
        {
            InitializeComponent();
        }

        public ProjectManager(string name)
        {
            
            managerName = name;
            InitializeComponent();
            lblManger.Text = managerName;
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            
            AddOrUpdateProject a1= new AddOrUpdateProject(managerName);
            a1.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            
            AssignResourcePerson a1 = new AssignResourcePerson(managerName);
            a1.Show();
        }

        private void btnProjectList_Click(object sender, EventArgs e)
        {
            ViewProjects v1 = new ViewProjects(managerName);
            v1.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Hide();
            login a1 = new login();
            a1.Show();
        }
    }
}
