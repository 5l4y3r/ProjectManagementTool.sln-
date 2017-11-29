namespace ProjectManagementTool
{
    partial class ProjectManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProject = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblManger = new System.Windows.Forms.Label();
            this.btnProjectList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProject
            // 
            this.btnProject.Location = new System.Drawing.Point(173, 64);
            this.btnProject.Name = "btnProject";
            this.btnProject.Size = new System.Drawing.Size(185, 61);
            this.btnProject.TabIndex = 0;
            this.btnProject.Text = "Add Project";
            this.btnProject.UseVisualStyleBackColor = true;
            this.btnProject.Click += new System.EventHandler(this.btnProject_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(173, 144);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(185, 61);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Assign resource Person";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manager Name :";
            // 
            // lblManger
            // 
            this.lblManger.AutoSize = true;
            this.lblManger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManger.Location = new System.Drawing.Point(120, 13);
            this.lblManger.Name = "lblManger";
            this.lblManger.Size = new System.Drawing.Size(0, 20);
            this.lblManger.TabIndex = 4;
            // 
            // btnProjectList
            // 
            this.btnProjectList.Location = new System.Drawing.Point(124, 227);
            this.btnProjectList.Name = "btnProjectList";
            this.btnProjectList.Size = new System.Drawing.Size(278, 84);
            this.btnProjectList.TabIndex = 5;
            this.btnProjectList.Text = "See project List";
            this.btnProjectList.UseVisualStyleBackColor = true;
            this.btnProjectList.Click += new System.EventHandler(this.btnProjectList_Click);
            // 
            // ProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 341);
            this.Controls.Add(this.btnProjectList);
            this.Controls.Add(this.lblManger);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnProject);
            this.Name = "ProjectManager";
            this.Text = "ProjectManager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProject;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblManger;
        private System.Windows.Forms.Button btnProjectList;
    }
}