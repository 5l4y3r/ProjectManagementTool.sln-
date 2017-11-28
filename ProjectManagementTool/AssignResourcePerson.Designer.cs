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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxSelectProject = new System.Windows.Forms.ComboBox();
            this.cboxSelectResourcePerson = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.cboxSelectProject.FormattingEnabled = true;
            this.cboxSelectProject.Location = new System.Drawing.Point(220, 74);
            this.cboxSelectProject.Name = "cboxSelectProject";
            this.cboxSelectProject.Size = new System.Drawing.Size(230, 21);
            this.cboxSelectProject.TabIndex = 9;
            // 
            // cboxSelectResourcePerson
            // 
            this.cboxSelectResourcePerson.FormattingEnabled = true;
            this.cboxSelectResourcePerson.Location = new System.Drawing.Point(220, 111);
            this.cboxSelectResourcePerson.Name = "cboxSelectResourcePerson";
            this.cboxSelectResourcePerson.Size = new System.Drawing.Size(230, 21);
            this.cboxSelectResourcePerson.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(35, 166);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 263);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 33);
            this.label3.TabIndex = 20;
            this.label3.Text = "Edit after DB Done--> ";
            // 
            // AssignResourcePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cboxSelectResourcePerson);
            this.Controls.Add(this.cboxSelectProject);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AssignResourcePerson";
            this.Text = "Assign Resource Person";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxSelectProject;
        private System.Windows.Forms.ComboBox cboxSelectResourcePerson;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}