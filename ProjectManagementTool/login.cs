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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var con = new PmtContext();

            var userLogin = con.Users.SingleOrDefault(t => t.UserName == txtUserName.Text) as User;

            if (txtUserName.Text == "it" && txtPassword.Text == "it123")
            {
                MessageBox.Show("IT Admin logged In Successfully");
                Hide();
                AddOrUpdateUser a1 = new AddOrUpdateUser();
                a1.Show();

            }

            else if (userLogin != null && userLogin.UserPassword == txtPassword.Text)
            {
                string deg = userLogin.UserDesignation;

                if (deg == "Project Manager")
                {
                    Hide();
                    ProjectManager p1 = new ProjectManager(userLogin.UserName);
                    p1.Show();
                }
                else
                {
                    Hide();
                    ViewProjects v1 = new ViewProjects();
                    v1.Show();

                }
                MessageBox.Show(deg + " logged In Successfully");

              
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }
    }
}
