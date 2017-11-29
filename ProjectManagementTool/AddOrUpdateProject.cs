using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagementTool
{
    public partial class AddOrUpdateProject : Form
    {
       public static string managerName;
        public AddOrUpdateProject(string s)
        {
            managerName = s;
            InitializeComponent();
            
        }

        private void brnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult button1_Click = folderBrowserDialog1.ShowDialog();
            if (button1_Click == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
                MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
            }
            string path;
            path = folderBrowserDialog1.SelectedPath; 
            txtUpload.Text = path;
        }

        private void rbtnNotStarted_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnNotStarted.Checked)
            {
                rbtnCanceled.Checked = false;
                rbtnComplited.Checked = false;
                rbtnStarted.Checked = false;
            }
        }

        private void rbtnStarted_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnStarted.Checked)
            {
                rbtnCanceled.Checked = false;
                rbtnComplited.Checked = false;
                rbtnNotStarted.Checked = false;
            }

        }

        private void rbtnComplited_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnComplited.Checked)
            {
                rbtnCanceled.Checked = false;
                rbtnStarted.Checked = false;
                rbtnNotStarted.Checked = false;
            }

        }

        private void rbtnCanceled_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCanceled.Checked)
            {
                rbtnComplited.Checked = false;
                rbtnStarted.Checked = false;
                rbtnNotStarted.Checked = false;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string s1 = txtPName.Text;
            string s2 = txtCName.Text;
            string s3 = txtDescription.Text;
            DateTime s4 = txtPSD.Value;
            DateTime s5 = txtPED.Value;
            int s6 = Convert.ToInt32(txtDuration.Text);
            string s7 = txtUpload.Text;
            string s8 = txtPriority.Text;
            string s9;
            if (rbtnComplited.Checked)
            {
                s9 = rbtnComplited.Text;
            }
            else if (rbtnStarted.Checked)
            {
                s9 = rbtnStarted.Text;}
            else if (rbtnNotStarted.Checked)
            {
                s9 = rbtnNotStarted.Text;
            }
            else
            {
                s9 = rbtnCanceled.Text; }

            string s10 = "";

            foreach (var part in s1.Split(' '))
            {
                s10 += part.Substring(0, 1);
            }
            

            BusinessLayer.AddOrUpdateProject.AddProject(s1,s10,s3,managerName,s7,s4,s5,s6,s8,s9);
            MessageBox.Show("project Added Successfully");
            Hide();
        }
    }
}
