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
        static string managerName;
        public ProjectManager()
        {
            InitializeComponent();
        }

        public ProjectManager(string name)
        {
            managerName = name;
            InitializeComponent();
            
        }

        private void btnProject_Click(object sender, EventArgs e)
        {
            Hide();
            AddOrUpdateProject a1= new AddOrUpdateProject(managerName);
            a1.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Hide();
            AssignResourcePerson a1 = new AssignResourcePerson(managerName);
            a1.Show();
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            Hide();
            AddOrUpdateTask a1= new AddOrUpdateTask();
            a1.Show();
        }
    }
}
