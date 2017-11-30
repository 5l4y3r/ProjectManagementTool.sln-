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
    public partial class AssignResourcePerson : Form
    {
        static string managerName;
        public AssignResourcePerson()
        {
            InitializeComponent();
            SetGridView();
            setProjectBindingSource();
            setUserBindingSource();
        }
        
        public AssignResourcePerson(string name)
        {
            managerName = name;
            InitializeComponent();
            SetGridView();
            setProjectBindingSource();
            setUserBindingSource();



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string s1, s2;
            s2 = cboxSelectProject.Text;
            s1 = cboxSelectResourcePerson.Text;
            BusinessLayer.AddResourcePerson.AddResource_Person(s1, s2,managerName);
            SetGridView();
            MessageBox.Show("Added successfully");
        }


        private void SetGridView()
        {
            dataGridView1.DataSource = new PmtContext().ResourcePersons.ToList();
        }

        private void setProjectBindingSource()
        {
            cboxSelectProject.DataSource = new PmtContext().Projects.ToList();

        }

        private void setUserBindingSource()
        {
            cboxSelectResourcePerson.DataSource = new PmtContext().Users.ToList();

        }
    }
}
