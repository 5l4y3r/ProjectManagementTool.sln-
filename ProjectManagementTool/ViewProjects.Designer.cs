namespace ProjectManagementTool
{
    partial class ViewProjects
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectShortNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectPsdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectPedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboxSelectProject = new System.Windows.Forms.ComboBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(568, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "View All Projects That You Are Involved";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 278);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.projectNameDataGridViewTextBoxColumn,
            this.projectShortNameDataGridViewTextBoxColumn,
            this.projectDescriptionDataGridViewTextBoxColumn,
            this.projectPsdDataGridViewTextBoxColumn,
            this.projectPedDataGridViewTextBoxColumn,
            this.projectDurationDataGridViewTextBoxColumn,
            this.projectStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.projectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(602, 254);
            this.dataGridView1.TabIndex = 0;
            // 
            // projectNameDataGridViewTextBoxColumn
            // 
            this.projectNameDataGridViewTextBoxColumn.DataPropertyName = "ProjectName";
            this.projectNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.projectNameDataGridViewTextBoxColumn.Name = "projectNameDataGridViewTextBoxColumn";
            // 
            // projectShortNameDataGridViewTextBoxColumn
            // 
            this.projectShortNameDataGridViewTextBoxColumn.DataPropertyName = "ProjectShortName";
            this.projectShortNameDataGridViewTextBoxColumn.HeaderText = "ShortName";
            this.projectShortNameDataGridViewTextBoxColumn.Name = "projectShortNameDataGridViewTextBoxColumn";
            // 
            // projectDescriptionDataGridViewTextBoxColumn
            // 
            this.projectDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ProjectDescription";
            this.projectDescriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.projectDescriptionDataGridViewTextBoxColumn.Name = "projectDescriptionDataGridViewTextBoxColumn";
            // 
            // projectPsdDataGridViewTextBoxColumn
            // 
            this.projectPsdDataGridViewTextBoxColumn.DataPropertyName = "ProjectPsd";
            this.projectPsdDataGridViewTextBoxColumn.HeaderText = "Start Date";
            this.projectPsdDataGridViewTextBoxColumn.Name = "projectPsdDataGridViewTextBoxColumn";
            // 
            // projectPedDataGridViewTextBoxColumn
            // 
            this.projectPedDataGridViewTextBoxColumn.DataPropertyName = "ProjectPed";
            this.projectPedDataGridViewTextBoxColumn.HeaderText = "End Date";
            this.projectPedDataGridViewTextBoxColumn.Name = "projectPedDataGridViewTextBoxColumn";
            // 
            // projectDurationDataGridViewTextBoxColumn
            // 
            this.projectDurationDataGridViewTextBoxColumn.DataPropertyName = "ProjectDuration";
            this.projectDurationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.projectDurationDataGridViewTextBoxColumn.Name = "projectDurationDataGridViewTextBoxColumn";
            // 
            // projectStatusDataGridViewTextBoxColumn
            // 
            this.projectStatusDataGridViewTextBoxColumn.DataPropertyName = "ProjectStatus";
            this.projectStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.projectStatusDataGridViewTextBoxColumn.Name = "projectStatusDataGridViewTextBoxColumn";
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(EntityClasses.Project);
            this.projectBindingSource.CurrentChanged += new System.EventHandler(this.projectBindingSource_CurrentChanged);
            // 
            // cboxSelectProject
            // 
            this.cboxSelectProject.DataSource = this.projectBindingSource;
            this.cboxSelectProject.DisplayMember = "ProjectName";
            this.cboxSelectProject.FormattingEnabled = true;
            this.cboxSelectProject.Location = new System.Drawing.Point(44, 75);
            this.cboxSelectProject.Name = "cboxSelectProject";
            this.cboxSelectProject.Size = new System.Drawing.Size(385, 21);
            this.cboxSelectProject.TabIndex = 10;
            this.cboxSelectProject.ValueMember = "ProjectName";
            this.cboxSelectProject.SelectedIndexChanged += new System.EventHandler(this.cboxSelectProject_SelectedIndexChanged);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(483, 75);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 11;
            this.btnDetails.Text = "See Datails";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // ViewProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 431);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.cboxSelectProject);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ViewProjects";
            this.Text = "ViewProjects";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectShortNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectPsdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectPedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.ComboBox cboxSelectProject;
        private System.Windows.Forms.Button btnDetails;
    }
}