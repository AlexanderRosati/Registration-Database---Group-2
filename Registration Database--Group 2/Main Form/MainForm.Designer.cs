namespace Main_Form
{
    partial class mainForm
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
            this.courseCRUDButton = new System.Windows.Forms.Button();
            this.enrollmentCRUDButton = new System.Windows.Forms.Button();
            this.sectionFilteringBySemesterButton = new System.Windows.Forms.Button();
            this.studentCRUDButton = new System.Windows.Forms.Button();
            this.enrollmentFilteringByStudent = new System.Windows.Forms.Button();
            this.majorCRUDButton = new System.Windows.Forms.Button();
            this.sectionCRUDButton = new System.Windows.Forms.Button();
            this.studentFilteringByMajorButton = new System.Windows.Forms.Button();
            this.courseFilteringByDepartment = new System.Windows.Forms.Button();
            this.facultyCRUDButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // courseCRUDButton
            // 
            this.courseCRUDButton.Location = new System.Drawing.Point(12, 26);
            this.courseCRUDButton.MaximumSize = new System.Drawing.Size(100, 100);
            this.courseCRUDButton.MinimumSize = new System.Drawing.Size(100, 100);
            this.courseCRUDButton.Name = "courseCRUDButton";
            this.courseCRUDButton.Size = new System.Drawing.Size(100, 100);
            this.courseCRUDButton.TabIndex = 0;
            this.courseCRUDButton.Text = "CRUD Operations for Course Table";
            this.courseCRUDButton.UseVisualStyleBackColor = true;
            // 
            // enrollmentCRUDButton
            // 
            this.enrollmentCRUDButton.Location = new System.Drawing.Point(542, 26);
            this.enrollmentCRUDButton.MaximumSize = new System.Drawing.Size(100, 100);
            this.enrollmentCRUDButton.MinimumSize = new System.Drawing.Size(100, 100);
            this.enrollmentCRUDButton.Name = "enrollmentCRUDButton";
            this.enrollmentCRUDButton.Size = new System.Drawing.Size(100, 100);
            this.enrollmentCRUDButton.TabIndex = 1;
            this.enrollmentCRUDButton.Text = "CRUD Operations for Enrollment Table";
            this.enrollmentCRUDButton.UseVisualStyleBackColor = true;
            this.enrollmentCRUDButton.Click += new System.EventHandler(this.enrollmentCRUDButton_Click);
            // 
            // sectionFilteringBySemesterButton
            // 
            this.sectionFilteringBySemesterButton.Location = new System.Drawing.Point(118, 132);
            this.sectionFilteringBySemesterButton.MaximumSize = new System.Drawing.Size(100, 100);
            this.sectionFilteringBySemesterButton.MinimumSize = new System.Drawing.Size(100, 100);
            this.sectionFilteringBySemesterButton.Name = "sectionFilteringBySemesterButton";
            this.sectionFilteringBySemesterButton.Size = new System.Drawing.Size(100, 100);
            this.sectionFilteringBySemesterButton.TabIndex = 2;
            this.sectionFilteringBySemesterButton.Text = "Section filtering by semester";
            this.sectionFilteringBySemesterButton.UseVisualStyleBackColor = true;
            // 
            // studentCRUDButton
            // 
            this.studentCRUDButton.Location = new System.Drawing.Point(330, 26);
            this.studentCRUDButton.MaximumSize = new System.Drawing.Size(100, 100);
            this.studentCRUDButton.MinimumSize = new System.Drawing.Size(100, 100);
            this.studentCRUDButton.Name = "studentCRUDButton";
            this.studentCRUDButton.Size = new System.Drawing.Size(100, 100);
            this.studentCRUDButton.TabIndex = 3;
            this.studentCRUDButton.Text = "CRUD Operations for Student Table";
            this.studentCRUDButton.UseVisualStyleBackColor = true;
            this.studentCRUDButton.Click += new System.EventHandler(this.studentCRUDButton_Click);
            // 
            // enrollmentFilteringByStudent
            // 
            this.enrollmentFilteringByStudent.Location = new System.Drawing.Point(224, 132);
            this.enrollmentFilteringByStudent.MaximumSize = new System.Drawing.Size(100, 100);
            this.enrollmentFilteringByStudent.MinimumSize = new System.Drawing.Size(100, 100);
            this.enrollmentFilteringByStudent.Name = "enrollmentFilteringByStudent";
            this.enrollmentFilteringByStudent.Size = new System.Drawing.Size(100, 100);
            this.enrollmentFilteringByStudent.TabIndex = 4;
            this.enrollmentFilteringByStudent.Text = "Enrollment filtering by student";
            this.enrollmentFilteringByStudent.UseVisualStyleBackColor = true;
            // 
            // majorCRUDButton
            // 
            this.majorCRUDButton.Location = new System.Drawing.Point(436, 26);
            this.majorCRUDButton.MaximumSize = new System.Drawing.Size(100, 100);
            this.majorCRUDButton.MinimumSize = new System.Drawing.Size(100, 100);
            this.majorCRUDButton.Name = "majorCRUDButton";
            this.majorCRUDButton.Size = new System.Drawing.Size(100, 100);
            this.majorCRUDButton.TabIndex = 5;
            this.majorCRUDButton.Text = "CRUD Operations for Major Table";
            this.majorCRUDButton.UseVisualStyleBackColor = true;
            this.majorCRUDButton.Click += new System.EventHandler(this.majorCRUDButton_Click);
            // 
            // sectionCRUDButton
            // 
            this.sectionCRUDButton.Location = new System.Drawing.Point(118, 26);
            this.sectionCRUDButton.MaximumSize = new System.Drawing.Size(100, 100);
            this.sectionCRUDButton.MinimumSize = new System.Drawing.Size(100, 100);
            this.sectionCRUDButton.Name = "sectionCRUDButton";
            this.sectionCRUDButton.Size = new System.Drawing.Size(100, 100);
            this.sectionCRUDButton.TabIndex = 6;
            this.sectionCRUDButton.Text = "CRUD Operations for Section Table";
            this.sectionCRUDButton.UseVisualStyleBackColor = true;
            // 
            // studentFilteringByMajorButton
            // 
            this.studentFilteringByMajorButton.Location = new System.Drawing.Point(330, 132);
            this.studentFilteringByMajorButton.MaximumSize = new System.Drawing.Size(100, 100);
            this.studentFilteringByMajorButton.MinimumSize = new System.Drawing.Size(100, 100);
            this.studentFilteringByMajorButton.Name = "studentFilteringByMajorButton";
            this.studentFilteringByMajorButton.Size = new System.Drawing.Size(100, 100);
            this.studentFilteringByMajorButton.TabIndex = 7;
            this.studentFilteringByMajorButton.Text = "Student filtering by major";
            this.studentFilteringByMajorButton.UseVisualStyleBackColor = true;
            // 
            // courseFilteringByDepartment
            // 
            this.courseFilteringByDepartment.Location = new System.Drawing.Point(436, 132);
            this.courseFilteringByDepartment.MaximumSize = new System.Drawing.Size(100, 100);
            this.courseFilteringByDepartment.MinimumSize = new System.Drawing.Size(100, 100);
            this.courseFilteringByDepartment.Name = "courseFilteringByDepartment";
            this.courseFilteringByDepartment.Size = new System.Drawing.Size(100, 100);
            this.courseFilteringByDepartment.TabIndex = 8;
            this.courseFilteringByDepartment.Text = "Course Filtering by Department";
            this.courseFilteringByDepartment.UseVisualStyleBackColor = true;
            // 
            // facultyCRUDButton
            // 
            this.facultyCRUDButton.Location = new System.Drawing.Point(224, 26);
            this.facultyCRUDButton.MaximumSize = new System.Drawing.Size(100, 100);
            this.facultyCRUDButton.MinimumSize = new System.Drawing.Size(100, 100);
            this.facultyCRUDButton.Name = "facultyCRUDButton";
            this.facultyCRUDButton.Size = new System.Drawing.Size(100, 100);
            this.facultyCRUDButton.TabIndex = 9;
            this.facultyCRUDButton.Text = "CRUD Operations for Faculty Table";
            this.facultyCRUDButton.UseVisualStyleBackColor = true;
            this.facultyCRUDButton.Click += new System.EventHandler(this.facultyCRUDButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 261);
            this.Controls.Add(this.facultyCRUDButton);
            this.Controls.Add(this.courseFilteringByDepartment);
            this.Controls.Add(this.studentFilteringByMajorButton);
            this.Controls.Add(this.sectionCRUDButton);
            this.Controls.Add(this.majorCRUDButton);
            this.Controls.Add(this.enrollmentFilteringByStudent);
            this.Controls.Add(this.studentCRUDButton);
            this.Controls.Add(this.sectionFilteringBySemesterButton);
            this.Controls.Add(this.enrollmentCRUDButton);
            this.Controls.Add(this.courseCRUDButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(670, 300);
            this.MinimumSize = new System.Drawing.Size(670, 300);
            this.Name = "mainForm";
            this.Text = "Registration Database";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button courseCRUDButton;
        private System.Windows.Forms.Button enrollmentCRUDButton;
        private System.Windows.Forms.Button sectionFilteringBySemesterButton;
        private System.Windows.Forms.Button studentCRUDButton;
        private System.Windows.Forms.Button enrollmentFilteringByStudent;
        private System.Windows.Forms.Button majorCRUDButton;
        private System.Windows.Forms.Button sectionCRUDButton;
        private System.Windows.Forms.Button studentFilteringByMajorButton;
        private System.Windows.Forms.Button courseFilteringByDepartment;
        private System.Windows.Forms.Button facultyCRUDButton;
    }
}

