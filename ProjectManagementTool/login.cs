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


            if (userLogin != null && userLogin.UserPassword == txtPassword.Text)
            {
                Hide();
                AddOrUpdateUser a1 = new AddOrUpdateUser();
                a1.Show();
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }
    }
}
