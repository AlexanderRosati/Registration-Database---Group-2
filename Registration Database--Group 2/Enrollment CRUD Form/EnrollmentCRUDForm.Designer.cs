namespace Enrollment_CRUD_Form
{
    partial class enrollmentCRUDForm
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
            this.sectionComboBox = new System.Windows.Forms.ComboBox();
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.gradeComboBox = new System.Windows.Forms.ComboBox();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.studentLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.EnrollmentListBox = new System.Windows.Forms.ListBox();
            this.addEnrollmentButton = new System.Windows.Forms.Button();
            this.updateEnrollmentButton = new System.Windows.Forms.Button();
            this.deleteEnrollmentButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.enrollmentLabel = new System.Windows.Forms.Label();
            this.sectionsListBox = new System.Windows.Forms.ListBox();
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.sectionListBoxLabel = new System.Windows.Forms.Label();
            this.studentsListBoxLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sectionComboBox
            // 
            this.sectionComboBox.FormattingEnabled = true;
            this.sectionComboBox.Location = new System.Drawing.Point(64, 32);
            this.sectionComboBox.Name = "sectionComboBox";
            this.sectionComboBox.Size = new System.Drawing.Size(121, 21);
            this.sectionComboBox.TabIndex = 0;
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(64, 62);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(121, 21);
            this.studentComboBox.TabIndex = 1;
            // 
            // gradeComboBox
            // 
            this.gradeComboBox.FormattingEnabled = true;
            this.gradeComboBox.Location = new System.Drawing.Point(64, 95);
            this.gradeComboBox.Name = "gradeComboBox";
            this.gradeComboBox.Size = new System.Drawing.Size(121, 21);
            this.gradeComboBox.TabIndex = 2;
            // 
            // sectionLabel
            // 
            this.sectionLabel.AutoSize = true;
            this.sectionLabel.Location = new System.Drawing.Point(12, 32);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(46, 13);
            this.sectionLabel.TabIndex = 3;
            this.sectionLabel.Text = "Section:";
            // 
            // studentLabel
            // 
            this.studentLabel.AutoSize = true;
            this.studentLabel.Location = new System.Drawing.Point(11, 62);
            this.studentLabel.Name = "studentLabel";
            this.studentLabel.Size = new System.Drawing.Size(47, 13);
            this.studentLabel.TabIndex = 4;
            this.studentLabel.Text = "Student:";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Location = new System.Drawing.Point(12, 95);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(39, 13);
            this.gradeLabel.TabIndex = 5;
            this.gradeLabel.Text = "Grade:";
            // 
            // EnrollmentListBox
            // 
            this.EnrollmentListBox.FormattingEnabled = true;
            this.EnrollmentListBox.Location = new System.Drawing.Point(202, 32);
            this.EnrollmentListBox.Name = "EnrollmentListBox";
            this.EnrollmentListBox.Size = new System.Drawing.Size(442, 238);
            this.EnrollmentListBox.TabIndex = 6;
            this.EnrollmentListBox.SelectedIndexChanged += new System.EventHandler(this.EnrollmentListBox_SelectedIndexChanged);
            // 
            // addEnrollmentButton
            // 
            this.addEnrollmentButton.Location = new System.Drawing.Point(15, 122);
            this.addEnrollmentButton.Name = "addEnrollmentButton";
            this.addEnrollmentButton.Size = new System.Drawing.Size(170, 23);
            this.addEnrollmentButton.TabIndex = 11;
            this.addEnrollmentButton.Text = "Add Enrollment";
            this.addEnrollmentButton.UseVisualStyleBackColor = true;
            this.addEnrollmentButton.Click += new System.EventHandler(this.addEnrollmentButton_Click);
            // 
            // updateEnrollmentButton
            // 
            this.updateEnrollmentButton.Location = new System.Drawing.Point(15, 151);
            this.updateEnrollmentButton.Name = "updateEnrollmentButton";
            this.updateEnrollmentButton.Size = new System.Drawing.Size(170, 23);
            this.updateEnrollmentButton.TabIndex = 12;
            this.updateEnrollmentButton.Text = "Update Enrollment";
            this.updateEnrollmentButton.UseVisualStyleBackColor = true;
            this.updateEnrollmentButton.Click += new System.EventHandler(this.updateEnrollmentButton_Click);
            // 
            // deleteEnrollmentButton
            // 
            this.deleteEnrollmentButton.Location = new System.Drawing.Point(15, 209);
            this.deleteEnrollmentButton.Name = "deleteEnrollmentButton";
            this.deleteEnrollmentButton.Size = new System.Drawing.Size(170, 23);
            this.deleteEnrollmentButton.TabIndex = 13;
            this.deleteEnrollmentButton.Text = "Remove Enrollment";
            this.deleteEnrollmentButton.UseVisualStyleBackColor = true;
            this.deleteEnrollmentButton.Click += new System.EventHandler(this.deleteEnrollmentButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(15, 180);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(170, 23);
            this.ClearButton.TabIndex = 15;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 235);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(173, 57);
            this.ErrorLabel.TabIndex = 16;
            this.ErrorLabel.Text = "Error";
            // 
            // enrollmentLabel
            // 
            this.enrollmentLabel.AutoSize = true;
            this.enrollmentLabel.Location = new System.Drawing.Point(205, 13);
            this.enrollmentLabel.Name = "enrollmentLabel";
            this.enrollmentLabel.Size = new System.Drawing.Size(64, 13);
            this.enrollmentLabel.TabIndex = 17;
            this.enrollmentLabel.Text = "Enrollments:";
            // 
            // sectionsListBox
            // 
            this.sectionsListBox.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionsListBox.FormattingEnabled = true;
            this.sectionsListBox.ItemHeight = 12;
            this.sectionsListBox.Location = new System.Drawing.Point(202, 295);
            this.sectionsListBox.Name = "sectionsListBox";
            this.sectionsListBox.Size = new System.Drawing.Size(741, 160);
            this.sectionsListBox.TabIndex = 18;
            // 
            // studentsListBox
            // 
            this.studentsListBox.Font = new System.Drawing.Font("Courier New", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.ItemHeight = 12;
            this.studentsListBox.Location = new System.Drawing.Point(650, 32);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(293, 232);
            this.studentsListBox.TabIndex = 19;
            // 
            // sectionListBoxLabel
            // 
            this.sectionListBoxLabel.AutoSize = true;
            this.sectionListBoxLabel.Location = new System.Drawing.Point(205, 279);
            this.sectionListBoxLabel.Name = "sectionListBoxLabel";
            this.sectionListBoxLabel.Size = new System.Drawing.Size(51, 13);
            this.sectionListBoxLabel.TabIndex = 20;
            this.sectionListBoxLabel.Text = "Sections:";
            // 
            // studentsListBoxLabel
            // 
            this.studentsListBoxLabel.AutoSize = true;
            this.studentsListBoxLabel.Location = new System.Drawing.Point(647, 13);
            this.studentsListBoxLabel.Name = "studentsListBoxLabel";
            this.studentsListBoxLabel.Size = new System.Drawing.Size(52, 13);
            this.studentsListBoxLabel.TabIndex = 21;
            this.studentsListBoxLabel.Text = "Students:";
            // 
            // enrollmentCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 465);
            this.Controls.Add(this.studentsListBoxLabel);
            this.Controls.Add(this.sectionListBoxLabel);
            this.Controls.Add(this.studentsListBox);
            this.Controls.Add(this.sectionsListBox);
            this.Controls.Add(this.enrollmentLabel);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.deleteEnrollmentButton);
            this.Controls.Add(this.updateEnrollmentButton);
            this.Controls.Add(this.addEnrollmentButton);
            this.Controls.Add(this.EnrollmentListBox);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.studentLabel);
            this.Controls.Add(this.sectionLabel);
            this.Controls.Add(this.gradeComboBox);
            this.Controls.Add(this.studentComboBox);
            this.Controls.Add(this.sectionComboBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(971, 504);
            this.MinimumSize = new System.Drawing.Size(971, 335);
            this.Name = "enrollmentCRUDForm";
            this.Text = "Enrollment CRUD Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sectionComboBox;
        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.ComboBox gradeComboBox;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Label studentLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.ListBox EnrollmentListBox;
        private System.Windows.Forms.Button addEnrollmentButton;
        private System.Windows.Forms.Button updateEnrollmentButton;
        private System.Windows.Forms.Button deleteEnrollmentButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label enrollmentLabel;
        private System.Windows.Forms.ListBox sectionsListBox;
        private System.Windows.Forms.ListBox studentsListBox;
        private System.Windows.Forms.Label sectionListBoxLabel;
        private System.Windows.Forms.Label studentsListBoxLabel;
    }
}

