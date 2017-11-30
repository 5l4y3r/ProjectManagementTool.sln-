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
    public partial class AddOrUpdateTask : Form
    {
        public string projectSelection;
        public AddOrUpdateTask()
        {
            var con = new PmtContext();
            
            InitializeComponent();
            projectBindingSource.DataSource = con.Projects.ToList();
            userBindingSource.DataSource = con.Users.ToList();
            //cboxSelectProject.DataSource = projectBindingSource.DataSource;
            //cboxSelectResourcePerson.DataSource = userBindingSource.DataSource;
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            string s1, s2, s3,s5;
            DateTime s4;
            s2 = cboxSelectResourcePerson.Text;
            s1 = cboxSelectProject.Text;
            s3 = txtDescription.Text;
            s4 = dateTimePicker1.Value;
            s5 = listBox1.Text;
            BusinessLayer.AddOrUpdateTask.AddTask(s1,s2,s3,s4,s5);
            MessageBox.Show("Task added");
            

        }
    }
}
