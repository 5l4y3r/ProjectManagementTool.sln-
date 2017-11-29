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
            this.btnTask = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(170, 233);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(185, 61);
            this.btnTask.TabIndex = 2;
            this.btnTask.Text = "Add Task";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
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
            // ProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTask);
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
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Label label1;
    }
}