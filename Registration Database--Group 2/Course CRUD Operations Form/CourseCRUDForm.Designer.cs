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
			this.SuspendLayout();
			// 
			// courseNameTextBox
			// 
			this.courseNameTextBox.Location = new System.Drawing.Point(82, 26);
			this.courseNameTextBox.Name = "courseNameTextBox";
			this.courseNameTextBox.Size = new System.Drawing.Size(203, 20);
			this.courseNameTextBox.TabIndex = 1;
			// 
			// courseNumTextBox
			// 
			this.courseNumTextBox.Location = new System.Drawing.Point(82, 52);
			this.courseNumTextBox.Name = "courseNumTextBox";
			this.courseNumTextBox.Size = new System.Drawing.Size(203, 20);
			this.courseNumTextBox.TabIndex = 2;
			// 
			// courseCreditsTextBox
			// 
			this.courseCreditsTextBox.Location = new System.Drawing.Point(82, 78);
			this.courseCreditsTextBox.Name = "courseCreditsTextBox";
			this.courseCreditsTextBox.Size = new System.Drawing.Size(203, 20);
			this.courseCreditsTextBox.TabIndex = 3;
			// 
			// courseDepartmentTextBox
			// 
			this.courseDepartmentTextBox.Location = new System.Drawing.Point(82, 104);
			this.courseDepartmentTextBox.Name = "courseDepartmentTextBox";
			this.courseDepartmentTextBox.Size = new System.Drawing.Size(203, 20);
			this.courseDepartmentTextBox.TabIndex = 4;
			// 
			// courseListBox
			// 
			this.courseListBox.FormattingEnabled = true;
			this.courseListBox.Location = new System.Drawing.Point(37, 224);
			this.courseListBox.Name = "courseListBox";
			this.courseListBox.Size = new System.Drawing.Size(520, 186);
			this.courseListBox.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 55);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Number";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Credits";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 107);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Department";
			// 
			// addCourseButton
			// 
			this.addCourseButton.Location = new System.Drawing.Point(204, 135);
			this.addCourseButton.Name = "addCourseButton";
			this.addCourseButton.Size = new System.Drawing.Size(80, 31);
			this.addCourseButton.TabIndex = 11;
			this.addCourseButton.Text = "Add Course";
			this.addCourseButton.UseVisualStyleBackColor = true;
			this.addCourseButton.Click += new System.EventHandler(this.addCourseButton_Click);
			// 
			// courseErrorLabel
			// 
			this.courseErrorLabel.AutoSize = true;
			this.courseErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.courseErrorLabel.Location = new System.Drawing.Point(35, 197);
			this.courseErrorLabel.Name = "courseErrorLabel";
			this.courseErrorLabel.Size = new System.Drawing.Size(29, 13);
			this.courseErrorLabel.TabIndex = 12;
			this.courseErrorLabel.Text = "Error";
			// 
			// courseClearButton
			// 
			this.courseClearButton.Location = new System.Drawing.Point(82, 135);
			this.courseClearButton.Name = "courseClearButton";
			this.courseClearButton.Size = new System.Drawing.Size(80, 31);
			this.courseClearButton.TabIndex = 13;
			this.courseClearButton.Text = "Clear";
			this.courseClearButton.UseVisualStyleBackColor = true;
			this.courseClearButton.Click += new System.EventHandler(this.courseClearButton_Click);
			// 
			// CourseCRUDForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
	}
}

