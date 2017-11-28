namespace ProjectManagementTool
{
    partial class AddOrUpdateProject
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPSD = new System.Windows.Forms.TextBox();
            this.txtPED = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtUpload = new System.Windows.Forms.TextBox();
            this.brnBrowse = new System.Windows.Forms.Button();
            this.rbtnNotStarted = new System.Windows.Forms.RadioButton();
            this.rbtnStarted = new System.Windows.Forms.RadioButton();
            this.rbtnComplited = new System.Windows.Forms.RadioButton();
            this.rbtnCanceled = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add/Update Project";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Duration (in Days)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Possible End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Possible Start Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Code Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(102, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Status";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 310);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Upload File";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(220, 74);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(333, 20);
            this.txtPName.TabIndex = 9;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(220, 106);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(188, 20);
            this.txtCName.TabIndex = 10;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(220, 139);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(333, 67);
            this.txtDescription.TabIndex = 11;
            // 
            // txtPSD
            // 
            this.txtPSD.Location = new System.Drawing.Point(220, 224);
            this.txtPSD.Name = "txtPSD";
            this.txtPSD.Size = new System.Drawing.Size(188, 20);
            this.txtPSD.TabIndex = 12;
            // 
            // txtPED
            // 
            this.txtPED.Location = new System.Drawing.Point(220, 251);
            this.txtPED.Name = "txtPED";
            this.txtPED.Size = new System.Drawing.Size(188, 20);
            this.txtPED.TabIndex = 13;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(220, 278);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(188, 20);
            this.txtDuration.TabIndex = 14;
            // 
            // txtUpload
            // 
            this.txtUpload.Location = new System.Drawing.Point(220, 304);
            this.txtUpload.Name = "txtUpload";
            this.txtUpload.Size = new System.Drawing.Size(238, 20);
            this.txtUpload.TabIndex = 15;
            // 
            // brnBrowse
            // 
            this.brnBrowse.Location = new System.Drawing.Point(478, 303);
            this.brnBrowse.Name = "brnBrowse";
            this.brnBrowse.Size = new System.Drawing.Size(75, 23);
            this.brnBrowse.TabIndex = 16;
            this.brnBrowse.Text = "Browse";
            this.brnBrowse.UseVisualStyleBackColor = true;
            // 
            // rbtnNotStarted
            // 
            this.rbtnNotStarted.AutoSize = true;
            this.rbtnNotStarted.Location = new System.Drawing.Point(222, 331);
            this.rbtnNotStarted.Name = "rbtnNotStarted";
            this.rbtnNotStarted.Size = new System.Drawing.Size(79, 17);
            this.rbtnNotStarted.TabIndex = 17;
            this.rbtnNotStarted.TabStop = true;
            this.rbtnNotStarted.Text = "Not Started";
            this.rbtnNotStarted.UseVisualStyleBackColor = true;
            // 
            // rbtnStarted
            // 
            this.rbtnStarted.AutoSize = true;
            this.rbtnStarted.Location = new System.Drawing.Point(222, 354);
            this.rbtnStarted.Name = "rbtnStarted";
            this.rbtnStarted.Size = new System.Drawing.Size(59, 17);
            this.rbtnStarted.TabIndex = 18;
            this.rbtnStarted.TabStop = true;
            this.rbtnStarted.Text = "Started";
            this.rbtnStarted.UseVisualStyleBackColor = true;
            // 
            // rbtnComplited
            // 
            this.rbtnComplited.AutoSize = true;
            this.rbtnComplited.Location = new System.Drawing.Point(222, 377);
            this.rbtnComplited.Name = "rbtnComplited";
            this.rbtnComplited.Size = new System.Drawing.Size(71, 17);
            this.rbtnComplited.TabIndex = 19;
            this.rbtnComplited.TabStop = true;
            this.rbtnComplited.Text = "Complited";
            this.rbtnComplited.UseVisualStyleBackColor = true;
            // 
            // rbtnCanceled
            // 
            this.rbtnCanceled.AutoSize = true;
            this.rbtnCanceled.Location = new System.Drawing.Point(222, 400);
            this.rbtnCanceled.Name = "rbtnCanceled";
            this.rbtnCanceled.Size = new System.Drawing.Size(70, 17);
            this.rbtnCanceled.TabIndex = 20;
            this.rbtnCanceled.TabStop = true;
            this.rbtnCanceled.Text = "Canceled";
            this.rbtnCanceled.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(380, 433);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // AddOrUpdateProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 468);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rbtnCanceled);
            this.Controls.Add(this.rbtnComplited);
            this.Controls.Add(this.rbtnStarted);
            this.Controls.Add(this.rbtnNotStarted);
            this.Controls.Add(this.brnBrowse);
            this.Controls.Add(this.txtUpload);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtPED);
            this.Controls.Add(this.txtPSD);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddOrUpdateProject";
            this.Text = "Add or Update Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPSD;
        private System.Windows.Forms.TextBox txtPED;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtUpload;
        private System.Windows.Forms.Button brnBrowse;
        private System.Windows.Forms.RadioButton rbtnNotStarted;
        private System.Windows.Forms.RadioButton rbtnStarted;
        private System.Windows.Forms.RadioButton rbtnComplited;
        private System.Windows.Forms.RadioButton rbtnCanceled;
        private System.Windows.Forms.Button btnSave;
    }
}