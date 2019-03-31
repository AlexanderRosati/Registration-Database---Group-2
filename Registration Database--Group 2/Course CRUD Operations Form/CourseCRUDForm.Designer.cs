namespace Course_CRUD_Operations_Form
{
	partial class CourseCRUDForm
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
			this.courseNameTextBox = new System.Windows.Forms.TextBox();
			this.courseNumTextBox = new System.Windows.Forms.TextBox();
			this.courseCreditsTextBox = new System.Windows.Forms.TextBox();
			this.courseDepartmentTextBox = new System.Windows.Forms.TextBox();
			this.courseListBox = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.addCourseButton = new System.Windows.Forms.Button();
			this.courseErrorLabel = new System.Windows.Forms.Label();
			this.courseClearButton = new System.Windows.Forms.Button();
			this.deleteCourseButton = new System.Windows.Forms.Button();
			this.courseUpdateNameTextBox = new System.Windows.Forms.TextBox();
			this.courseUpdateNumberTextBox = new System.Windows.Forms.TextBox();
			this.courseUpdateCreditsTextBox = new System.Windows.Forms.TextBox();
			this.courseUpdateDepartmentTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.updateCourseButton = new System.Windows.Forms.Button();
			this.updateCourseClearButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// courseNameTextBox
			// 
			this.courseNameTextBox.Location = new System.Drawing.Point(82, 46);
			this.courseNameTextBox.Name = "courseNameTextBox";
			this.courseNameTextBox.Size = new System.Drawing.Size(203, 20);
			this.courseNameTextBox.TabIndex = 1;
			// 
			// courseNumTextBox
			// 
			this.courseNumTextBox.Location = new System.Drawing.Point(82, 72);
			this.courseNumTextBox.Name = "courseNumTextBox";
			this.courseNumTextBox.Size = new System.Drawing.Size(203, 20);
			this.courseNumTextBox.TabIndex = 2;
			// 
			// courseCreditsTextBox
			// 
			this.courseCreditsTextBox.Location = new System.Drawing.Point(82, 98);
			this.courseCreditsTextBox.Name = "courseCreditsTextBox";
			this.courseCreditsTextBox.Size = new System.Drawing.Size(203, 20);
			this.courseCreditsTextBox.TabIndex = 3;
			// 
			// courseDepartmentTextBox
			// 
			this.courseDepartmentTextBox.Location = new System.Drawing.Point(82, 124);
			this.courseDepartmentTextBox.Name = "courseDepartmentTextBox";
			this.courseDepartmentTextBox.Size = new System.Drawing.Size(203, 20);
			this.courseDepartmentTextBox.TabIndex = 4;
			// 
			// courseListBox
			// 
			this.courseListBox.FormattingEnabled = true;
			this.courseListBox.Location = new System.Drawing.Point(37, 244);
			this.courseListBox.Name = "courseListBox";
			this.courseListBox.Size = new System.Drawing.Size(520, 186);
			this.courseListBox.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 75);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Number";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 101);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Credits";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 127);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Department";
			// 
			// addCourseButton
			// 
			this.addCourseButton.Location = new System.Drawing.Point(204, 155);
			this.addCourseButton.Name = "addCourseButton";
			this.addCourseButton.Size = new System.Drawing.Size(80, 31);
			this.addCourseButton.TabIndex = 11;
			this.addCourseButton.Text = "Add";
			this.addCourseButton.UseVisualStyleBackColor = true;
			this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
			// 
			// courseErrorLabel
			// 
			this.courseErrorLabel.AutoSize = true;
			this.courseErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.courseErrorLabel.Location = new System.Drawing.Point(35, 217);
			this.courseErrorLabel.Name = "courseErrorLabel";
			this.courseErrorLabel.Size = new System.Drawing.Size(29, 13);
			this.courseErrorLabel.TabIndex = 12;
			this.courseErrorLabel.Text = "Error";
			// 
			// courseClearButton
			// 
			this.courseClearButton.Location = new System.Drawing.Point(82, 155);
			this.courseClearButton.Name = "courseClearButton";
			this.courseClearButton.Size = new System.Drawing.Size(80, 31);
			this.courseClearButton.TabIndex = 13;
			this.courseClearButton.Text = "Clear";
			this.courseClearButton.UseVisualStyleBackColor = true;
			this.courseClearButton.Click += new System.EventHandler(this.CourseClearButton_Click);
			// 
			// deleteCourseButton
			// 
			this.deleteCourseButton.Location = new System.Drawing.Point(578, 399);
			this.deleteCourseButton.Name = "deleteCourseButton";
			this.deleteCourseButton.Size = new System.Drawing.Size(80, 31);
			this.deleteCourseButton.TabIndex = 14;
			this.deleteCourseButton.Text = "Delete";
			this.deleteCourseButton.UseVisualStyleBackColor = true;
			this.deleteCourseButton.Click += new System.EventHandler(this.deleteCourseButton_Click);
			// 
			// courseUpdateNameTextBox
			// 
			this.courseUpdateNameTextBox.Location = new System.Drawing.Point(455, 46);
			this.courseUpdateNameTextBox.Name = "courseUpdateNameTextBox";
			this.courseUpdateNameTextBox.Size = new System.Drawing.Size(203, 20);
			this.courseUpdateNameTextBox.TabIndex = 15;
			// 
			// courseUpdateNumberTextBox
			// 
			this.courseUpdateNumberTextBox.Location = new System.Drawing.Point(455, 75);
			this.courseUpdateNumberTextBox.Name = "courseUpdateNumberTextBox";
			this.courseUpdateNumberTextBox.Size = new System.Drawing.Size(203, 20);
			this.courseUpdateNumberTextBox.TabIndex = 16;
			// 
			// courseUpdateCreditsTextBox
			// 
			this.courseUpdateCreditsTextBox.Location = new System.Drawing.Point(455, 101);
			this.courseUpdateCreditsTextBox.Name = "courseUpdateCreditsTextBox";
			this.courseUpdateCreditsTextBox.Size = new System.Drawing.Size(203, 20);
			this.courseUpdateCreditsTextBox.TabIndex = 17;
			// 
			// courseUpdateDepartmentTextBox
			// 
			this.courseUpdateDepartmentTextBox.Location = new System.Drawing.Point(455, 127);
			this.courseUpdateDepartmentTextBox.Name = "courseUpdateDepartmentTextBox";
			this.courseUpdateDepartmentTextBox.Size = new System.Drawing.Size(203, 20);
			this.courseUpdateDepartmentTextBox.TabIndex = 18;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(379, 130);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 22;
			this.label1.Text = "Department";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(400, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 13);
			this.label6.TabIndex = 21;
			this.label6.Text = "Credits";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(397, 78);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(44, 13);
			this.label7.TabIndex = 20;
			this.label7.Text = "Number";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(404, 52);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 13);
			this.label8.TabIndex = 19;
			this.label8.Text = "Name";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(14, 9);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(137, 16);
			this.label9.TabIndex = 23;
			this.label9.Text = "Add A New Course";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(379, 9);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(234, 16);
			this.label10.TabIndex = 24;
			this.label10.Text = "Modify a Course (select from list)";
			// 
			// updateCourseButton
			// 
			this.updateCourseButton.Location = new System.Drawing.Point(578, 155);
			this.updateCourseButton.Name = "updateCourseButton";
			this.updateCourseButton.Size = new System.Drawing.Size(80, 31);
			this.updateCourseButton.TabIndex = 25;
			this.updateCourseButton.Text = "Update";
			this.updateCourseButton.UseVisualStyleBackColor = true;
			this.updateCourseButton.Click += new System.EventHandler(this.updateCourseButton_Click);
			// 
			// updateCourseClearButton
			// 
			this.updateCourseClearButton.Location = new System.Drawing.Point(455, 155);
			this.updateCourseClearButton.Name = "updateCourseClearButton";
			this.updateCourseClearButton.Size = new System.Drawing.Size(80, 31);
			this.updateCourseClearButton.TabIndex = 26;
			this.updateCourseClearButton.Text = "Clear";
			this.updateCourseClearButton.UseVisualStyleBackColor = true;
			this.updateCourseClearButton.Click += new System.EventHandler(this.UpdateCourseClearButton_Click);
			// 
			// CourseCRUDForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(683, 450);
			this.Controls.Add(this.updateCourseClearButton);
			this.Controls.Add(this.updateCourseButton);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.courseUpdateDepartmentTextBox);
			this.Controls.Add(this.courseUpdateCreditsTextBox);
			this.Controls.Add(this.courseUpdateNumberTextBox);
			this.Controls.Add(this.courseUpdateNameTextBox);
			this.Controls.Add(this.deleteCourseButton);
			this.Controls.Add(this.courseClearButton);
			this.Controls.Add(this.courseErrorLabel);
			this.Controls.Add(this.addCourseButton);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.courseListBox);
			this.Controls.Add(this.courseDepartmentTextBox);
			this.Controls.Add(this.courseCreditsTextBox);
			this.Controls.Add(this.courseNumTextBox);
			this.Controls.Add(this.courseNameTextBox);
			this.Name = "CourseCRUDForm";
			this.Text = "Add/Modify Courses";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox courseNameTextBox;
		private System.Windows.Forms.TextBox courseNumTextBox;
		private System.Windows.Forms.TextBox courseCreditsTextBox;
		private System.Windows.Forms.TextBox courseDepartmentTextBox;
		private System.Windows.Forms.ListBox courseListBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button addCourseButton;
		private System.Windows.Forms.Label courseErrorLabel;
		private System.Windows.Forms.Button courseClearButton;
		private System.Windows.Forms.Button deleteCourseButton;
		private System.Windows.Forms.TextBox courseUpdateNameTextBox;
		private System.Windows.Forms.TextBox courseUpdateNumberTextBox;
		private System.Windows.Forms.TextBox courseUpdateCreditsTextBox;
		private System.Windows.Forms.TextBox courseUpdateDepartmentTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button updateCourseButton;
		private System.Windows.Forms.Button updateCourseClearButton;
	}
}

