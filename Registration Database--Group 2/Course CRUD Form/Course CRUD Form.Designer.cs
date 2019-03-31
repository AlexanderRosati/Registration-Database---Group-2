namespace Course_CRUD_Form
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
			this.CourseNameTextBox = new System.Windows.Forms.TextBox();
			this.CourseNumberTextBox = new System.Windows.Forms.TextBox();
			this.CourseCreditsTextBox = new System.Windows.Forms.TextBox();
			this.CourseDepartmentTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.CourseListBox = new System.Windows.Forms.ListBox();
			this.ErrorLabel = new System.Windows.Forms.Label();
			this.AddCourseButton = new System.Windows.Forms.Button();
			this.DeleteCourseButton = new System.Windows.Forms.Button();
			this.UpdateCourseButton = new System.Windows.Forms.Button();
			this.ClearCourseInputButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CourseNameTextBox
			// 
			this.CourseNameTextBox.Location = new System.Drawing.Point(105, 38);
			this.CourseNameTextBox.Name = "CourseNameTextBox";
			this.CourseNameTextBox.Size = new System.Drawing.Size(251, 20);
			this.CourseNameTextBox.TabIndex = 0;
			// 
			// CourseNumberTextBox
			// 
			this.CourseNumberTextBox.Location = new System.Drawing.Point(105, 64);
			this.CourseNumberTextBox.Name = "CourseNumberTextBox";
			this.CourseNumberTextBox.Size = new System.Drawing.Size(251, 20);
			this.CourseNumberTextBox.TabIndex = 1;
			// 
			// CourseCreditsTextBox
			// 
			this.CourseCreditsTextBox.Location = new System.Drawing.Point(105, 90);
			this.CourseCreditsTextBox.Name = "CourseCreditsTextBox";
			this.CourseCreditsTextBox.Size = new System.Drawing.Size(251, 20);
			this.CourseCreditsTextBox.TabIndex = 2;
			// 
			// CourseDepartmentTextBox
			// 
			this.CourseDepartmentTextBox.Location = new System.Drawing.Point(105, 116);
			this.CourseDepartmentTextBox.Name = "CourseDepartmentTextBox";
			this.CourseDepartmentTextBox.Size = new System.Drawing.Size(251, 20);
			this.CourseDepartmentTextBox.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(37, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Number";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(37, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Credits";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(37, 119);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Department";
			// 
			// CourseListBox
			// 
			this.CourseListBox.FormattingEnabled = true;
			this.CourseListBox.Location = new System.Drawing.Point(38, 218);
			this.CourseListBox.Name = "CourseListBox";
			this.CourseListBox.Size = new System.Drawing.Size(458, 199);
			this.CourseListBox.TabIndex = 8;
			this.CourseListBox.SelectedIndexChanged += new System.EventHandler(this.CourseListBox_SelectedIndexChanged);
			// 
			// ErrorLabel
			// 
			this.ErrorLabel.AutoSize = true;
			this.ErrorLabel.ForeColor = System.Drawing.Color.Red;
			this.ErrorLabel.Location = new System.Drawing.Point(41, 197);
			this.ErrorLabel.Name = "ErrorLabel";
			this.ErrorLabel.Size = new System.Drawing.Size(29, 13);
			this.ErrorLabel.TabIndex = 9;
			this.ErrorLabel.Text = "Error";
			// 
			// AddCourseButton
			// 
			this.AddCourseButton.Location = new System.Drawing.Point(404, 41);
			this.AddCourseButton.Name = "AddCourseButton";
			this.AddCourseButton.Size = new System.Drawing.Size(92, 27);
			this.AddCourseButton.TabIndex = 10;
			this.AddCourseButton.Text = "Add";
			this.AddCourseButton.UseVisualStyleBackColor = true;
			this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
			// 
			// DeleteCourseButton
			// 
			this.DeleteCourseButton.Location = new System.Drawing.Point(404, 183);
			this.DeleteCourseButton.Name = "DeleteCourseButton";
			this.DeleteCourseButton.Size = new System.Drawing.Size(92, 27);
			this.DeleteCourseButton.TabIndex = 11;
			this.DeleteCourseButton.Text = "Delete";
			this.DeleteCourseButton.UseVisualStyleBackColor = true;
			this.DeleteCourseButton.Click += new System.EventHandler(this.DeleteCourseButton_Click);
			// 
			// UpdateCourseButton
			// 
			this.UpdateCourseButton.Location = new System.Drawing.Point(404, 72);
			this.UpdateCourseButton.Name = "UpdateCourseButton";
			this.UpdateCourseButton.Size = new System.Drawing.Size(92, 27);
			this.UpdateCourseButton.TabIndex = 12;
			this.UpdateCourseButton.Text = "Update";
			this.UpdateCourseButton.UseVisualStyleBackColor = true;
			this.UpdateCourseButton.Click += new System.EventHandler(this.UpdateCourseButton_Click);
			// 
			// ClearCourseInputButton
			// 
			this.ClearCourseInputButton.Location = new System.Drawing.Point(404, 105);
			this.ClearCourseInputButton.Name = "ClearCourseInputButton";
			this.ClearCourseInputButton.Size = new System.Drawing.Size(92, 27);
			this.ClearCourseInputButton.TabIndex = 13;
			this.ClearCourseInputButton.Text = "Clear";
			this.ClearCourseInputButton.UseVisualStyleBackColor = true;
			this.ClearCourseInputButton.Click += new System.EventHandler(this.ClearCourseInputButton_Click);
			// 
			// CourseCRUDForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 450);
			this.Controls.Add(this.ClearCourseInputButton);
			this.Controls.Add(this.UpdateCourseButton);
			this.Controls.Add(this.DeleteCourseButton);
			this.Controls.Add(this.AddCourseButton);
			this.Controls.Add(this.ErrorLabel);
			this.Controls.Add(this.CourseListBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CourseDepartmentTextBox);
			this.Controls.Add(this.CourseCreditsTextBox);
			this.Controls.Add(this.CourseNumberTextBox);
			this.Controls.Add(this.CourseNameTextBox);
			this.Name = "CourseCRUDForm";
			this.Text = "Course Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox CourseNameTextBox;
		private System.Windows.Forms.TextBox CourseNumberTextBox;
		private System.Windows.Forms.TextBox CourseCreditsTextBox;
		private System.Windows.Forms.TextBox CourseDepartmentTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ListBox CourseListBox;
		private System.Windows.Forms.Label ErrorLabel;
		private System.Windows.Forms.Button AddCourseButton;
		private System.Windows.Forms.Button DeleteCourseButton;
		private System.Windows.Forms.Button UpdateCourseButton;
		private System.Windows.Forms.Button ClearCourseInputButton;
	}
}

