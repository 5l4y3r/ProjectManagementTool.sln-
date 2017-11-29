namespace ProjectManagementTool
{
    partial class AssignResourcePerson
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
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxSelectProject = new System.Windows.Forms.ComboBox();
            this.projectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboxSelectResourcePerson = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.resourcePersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resourcePersonProjectNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourcePersonNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resourcePersonDesignationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcePersonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assign Resource Person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Select Resource person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Project";
            // 
            // cboxSelectProject
            // 
            this.cboxSelectProject.DataSource = this.projectBindingSource;
            this.cboxSelectProject.DisplayMember = "ProjectName";
            this.cboxSelectProject.FormattingEnabled = true;
            this.cboxSelectProject.Location = new System.Drawing.Point(220, 74);
            this.cboxSelectProject.Name = "cboxSelectProject";
            this.cboxSelectProject.Size = new System.Drawing.Size(230, 21);
            this.cboxSelectProject.TabIndex = 9;
            this.cboxSelectProject.ValueMember = "ProjectName";
            // 
            // projectBindingSource
            // 
            this.projectBindingSource.DataSource = typeof(EntityClasses.Project);
            // 
            // cboxSelectResourcePerson
            // 
            this.cboxSelectResourcePerson.DataSource = this.userBindingSource;
            this.cboxSelectResourcePerson.DisplayMember = "UserName";
            this.cboxSelectResourcePerson.FormattingEnabled = true;
            this.cboxSelectResourcePerson.Location = new System.Drawing.Point(220, 111);
            this.cboxSelectResourcePerson.Name = "cboxSelectResourcePerson";
            this.cboxSelectResourcePerson.Size = new System.Drawing.Size(230, 21);
            this.cboxSelectResourcePerson.TabIndex = 10;
            this.cboxSelectResourcePerson.ValueMember = "UserName";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(EntityClasses.User);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(375, 137);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resourcePersonProjectNameDataGridViewTextBoxColumn,
            this.resourcePersonNameDataGridViewTextBoxColumn,
            this.resourcePersonDesignationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resourcePersonBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(71, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 215);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(35, 186);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 235);
            this.panel1.TabIndex = 11;
            // 
            // resourcePersonBindingSource
            // 
            this.resourcePersonBindingSource.DataSource = typeof(EntityClasses.ResourcePerson);
            // 
            // resourcePersonProjectNameDataGridViewTextBoxColumn
            // 
            this.resourcePersonProjectNameDataGridViewTextBoxColumn.DataPropertyName = "ResourcePersonProjectName";
            this.resourcePersonProjectNameDataGridViewTextBoxColumn.HeaderText = "Project Name";
            this.resourcePersonProjectNameDataGridViewTextBoxColumn.Name = "resourcePersonProjectNameDataGridViewTextBoxColumn";
            // 
            // resourcePersonNameDataGridViewTextBoxColumn
            // 
            this.resourcePersonNameDataGridViewTextBoxColumn.DataPropertyName = "ResourcePersonName";
            this.resourcePersonNameDataGridViewTextBoxColumn.HeaderText = "Resource Person";
            this.resourcePersonNameDataGridViewTextBoxColumn.Name = "resourcePersonNameDataGridViewTextBoxColumn";
            // 
            // resourcePersonDesignationDataGridViewTextBoxColumn
            // 
            this.resourcePersonDesignationDataGridViewTextBoxColumn.DataPropertyName = "ResourcePersonDesignation";
            this.resourcePersonDesignationDataGridViewTextBoxColumn.HeaderText = "Designation";
            this.resourcePersonDesignationDataGridViewTextBoxColumn.Name = "resourcePersonDesignationDataGridViewTextBoxColumn";
            // 
            // AssignResourcePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 441);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboxSelectResourcePerson);
            this.Controls.Add(this.cboxSelectProject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssignResourcePerson";
            this.Text = "Assign Resource Person";
            ((System.ComponentModel.ISupportInitialize)(this.projectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourcePersonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxSelectProject;
        private System.Windows.Forms.ComboBox cboxSelectResourcePerson;
        private System.Windows.Forms.BindingSource projectBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourcePersonProjectNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourcePersonNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resourcePersonDesignationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource resourcePersonBindingSource;
    }
}